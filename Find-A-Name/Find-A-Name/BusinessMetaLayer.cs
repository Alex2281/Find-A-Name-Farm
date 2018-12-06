using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Find_A_Name
{
    public class BusinessMetaLayer
    {
        static private BusinessMetaLayer m_instance = null;

        private BusinessMetaLayer() { }

        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;
        }

        DbConection con = DbFactory.instance();

        public int farmLogin(String txtUsername, String txtPassword)
        {
            int retv = -1;  
            
            if (con.OpenConnection())
            {
                String sql = "SELECT accessPrivilage FROM Employees WHERE userName = '" + txtUsername + "' AND password = '" + txtPassword +"'";
                DbDataReader reader = con.Select(sql);

                if (reader.Read())
                {
                    //Read the data
                    string privilage = reader.GetString(0);

                    if (privilage == "Yes")
                    {
                        retv = 0;
                    }
                    else if (privilage == "No")
                    {
                        retv = 1;
                    }
                    else
                    {
                        retv = 2;
                    }
                    //close Data Reader
                    reader.Close();
                }
                con.CloseConnection();
            }
            return retv;
        }
        public List<Task> getTasks()
        {
            List<Task> tasks = new List<Task>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT t.taskId AS TaskId, t.taskDate AS ScheduleDate, e.firstname +','+ e.lastName AS Employee, tt.taskName AS Task, ts.statusType AS Status, c.cropName AS Crop, f.fieldReference AS field, v.vehicleType AS Vehicle, s.storageReference AS StorageUnit FROM Tasks AS t, Employees AS e, TaskType AS tt, TaskStatus AS ts, Crops AS c, Fields AS f, Vehicles AS v, StorageUnits AS s WHERE t.employeeId = e.employeeId AND t.taskTypeId = tt.taskTypeId AND t.taskStatusId = ts.taskStatusId AND t.cropId = c.cropId AND t.fieldId = f.fieldId AND t.vehicleId = v.vehicleId AND t.storageUnitId = s.storageUnitId;");

                while (dr.Read())
                {
                    Task task = new Task();
                    task.Id = dr.GetInt32(0);
                    task.TaskDate = dr.GetDateTime(1);
                    task.Employee = dr.GetString(2);
                    task.TaskType = dr.GetString(3);
                    task.TaskStatus = dr.GetString(4);
                    task.Crop = dr.GetString(5);
                    task.Field =  dr.GetString(6);
                    task.Vehicle = dr.GetString(7);
                    task.StorageUnit = dr.GetString(8);
                    tasks.Add(task);
                }
                dr.Close();
                con.CloseConnection();
            }
            return tasks;
        }
        public List<Task> getDaysTasks(string selectedDate)
        {
            List<Task> daysTasks = new List<Task>();

            if  (con.OpenConnection())
            {
                DbDataReader dt = con.Select("SELECT t.taskId AS TaskId, t.taskDate AS ScheduleDate, e.firstname + ',' + e.lastName AS Employee, tt.taskName AS Task, ts.statusType AS Status, c.cropName AS Crop, f.fieldReference AS field, v.vehicleType AS Vehicle, s.storageReference AS StorageUnit FROM Tasks AS t, Employees AS e, TaskType AS tt, TaskStatus AS ts, Crops AS c, Fields AS f, Vehicles AS v, StorageUnits AS s WHERE ((t.taskDate) = #" + selectedDate + "#) AND t.employeeId = e.employeeId AND t.taskTypeId = tt.taskTypeId AND t.taskStatusId = ts.taskStatusId AND t.cropId = c.cropId AND t.fieldId = f.fieldId AND t.vehicleId = v.vehicleId AND t.storageUnitId = s.storageUnitId;");

                while (dt.Read())
                {
                    Task task = new Task();
                    task.Id = dt.GetInt32(0);
                    task.TaskDate = dt.GetDateTime(1);
                    task.Employee = dt.GetString(2);
                    task.TaskType = dt.GetString(3);
                    task.TaskStatus = dt.GetString(4);
                    task.Crop = dt.GetString(5);
                    task.Field = dt.GetString(6);
                    task.Vehicle = dt.GetString(7);
                    task.StorageUnit = dt.GetString(8);
                    daysTasks.Add(task);
                }
                dt.Close();
                con.CloseConnection();
            }
            return daysTasks;
        }
        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT employeeId AS Id, lastName +','+ firstName AS Name, postCode AS Address, contactNumber AS Phone, emailAddress AS Email, userName AS Username, password AS Secret, accessPrivilage AS Privilage, dateCreated AS Created FROM Employees;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = dr.GetInt32(0);
                    employee.Name = dr.GetString(1);
                    employee.Address = dr.GetString(2);
                    employee.Phone = dr.GetString(3);
                    employee.Email = dr.GetString(4);
                    employee.Username = dr.GetString(5);
                    employee.Password = dr.GetString(6);
                    employee.Privilage = dr.GetString(7);
                    employee.Created = dr.GetString(8);
                    employees.Add(employee);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return employees;
        }
        public List<Vehicle> getVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT vehicleId AS Id, vehicleType AS Name, vehicleDescription AS Details, statusType AS Status FROM VechiclesQuery;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.Id = dr.GetInt32(0);
                    vehicle.Type = dr.GetString(1);
                    vehicle.Description = dr.GetString(2);
                    vehicle.Status = dr.GetString(3);
                    vehicles.Add(vehicle);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return vehicles;
        }
        public List<Field> getFields()
        {
            List<Field> fields = new List<Field>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT f.fieldId AS Id, f.fieldReference AS Locator, f.fieldSize AS Area, fs.statusType AS Status FROM Fields AS f, FieldStatus AS fs WHERE f.fieldStatusId = fs.fieldStatusId;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Field field = new Field();
                    field.Id = dr.GetInt32(0);
                    field.Reference = dr.GetString(1);
                    field.Size = dr.GetInt32(2);
                    field.Status = dr.GetString(3);
                    fields.Add(field);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return fields;
        }
        public List<Crop> getCrops()
        {
            List<Crop> crops = new List<Crop>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT C.cropId AS Id, C.cropName AS Name, C.cultivationTime AS CultivationTime, C.fertiliserFrequency AS FertiliserFrequency, C.yieldvalue AS YealdValue, F.fertiliserName AS Fertiliser FROM Crops AS C,  Fertilisers AS F WHERE C.fertiliserID = F.fertiliserID;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Crop crop = new Crop();
                    crop.Id = dr.GetInt32(0);
                    crop.Name = dr.GetString(1);
                    crop.CultivationTime = dr.GetInt32(2);
                    crop.FertiliserFrequency = dr.GetInt32(3);
                    crop.YieldValue = dr.GetInt32(4);
                    crop.FertiliserName = dr.GetString(5);
                    crops.Add(crop);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return crops;
        }
        public List<Fertiliser> getFertilisers()
        {
            List<Fertiliser> fertilisers = new List<Fertiliser>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT fertiliserId AS Id, fertiliserName AS Name, fertiliserStockQuantity AS Stock FROM Fertilisers;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Fertiliser fertiliser = new Fertiliser();
                    fertiliser.Id = dr.GetInt32(0);
                    fertiliser.Name = dr.GetString(1);
                    fertiliser.StockQuantity = dr.GetInt32(2);
                    fertilisers.Add(fertiliser);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return fertilisers;
        }
        public List<StorageUnit> getStorageUnits()
        {
            List<StorageUnit> storageUnits = new List<StorageUnit>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT s.storageUnitId AS Id, s.storageReference AS Name, s.storageUnitCapacity AS Total, s.storedCapacity AS Stock, c.cropName AS Crop FROM StorageUnits AS s, Crops AS c WHERE s.storedCropId = c.cropId;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    StorageUnit storage = new StorageUnit();
                    storage.Id = dr.GetInt32(0);
                    storage.Reference = dr.GetString(1);
                    storage.TotalCapacity = dr.GetInt32(2);
                    storage.CurrentCapacity = dr.GetInt32(3);
                    storage.StoredCrop = dr.GetString(4);
                    storageUnits.Add(storage);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return storageUnits;
        }

        public List<TaskType> getTaskTypes()
        {
            List<TaskType> taskTypes = new List<TaskType>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT tt.taskTypeId AS Id, tt.taskName AS Name, tt.taskDescription AS Description FROM TaskType AS tt;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    TaskType taskType = new TaskType();
                    taskType.Id = dr.GetInt32(0);
                    taskType.Name = dr.GetString(1);
                    taskType.Description = dr.GetString(2);
                    taskTypes.Add(taskType);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return taskTypes;
        }

        public List<TaskStatus> getTaskStatuses()
        {
            List<TaskStatus> taskStatuses = new List<TaskStatus>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT ts.taskStatusId AS Id, ts.statusType AS Name FROM TaskStatus AS ts;");

                while (dr.Read())
                {
                    TaskStatus taskStatus = new TaskStatus();
                    taskStatus.Id = dr.GetInt32(0);
                    taskStatus.Name = dr.GetString(1);
                    taskStatuses.Add(taskStatus);
                }
                dr.Close();
                con.CloseConnection();
            }
            return taskStatuses;
        }

        /*public List<Crop> getCrops()
        {
            List<Crop> crops = new List<Crop>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT ");
            }
            return crops;
        }*/

        public int addEmployee(String txtFirstname, String txtSurname, String txtPostcode, String txtPhone, String txtEmail, String txtUsername, String txtPassword, String accessPrivilage)
        {

            DateTime createdToday = DateTime.Now.Date;
            string Date = createdToday.ToString();
            int retv = 0;

            if (con.OpenConnection())
            {
                String sql = "INSERT INTO Employees (firstName, lastName, postCode, contactNumber, emailAddress, userName, password, accessPrivilage) VALUES ('"+ txtFirstname +"','"+ txtSurname +"','"+ txtPostcode +"','"+ txtPhone +"','"+ txtEmail +"','"+ txtUsername +"','"+ txtPassword +"','"+ accessPrivilage +"')";
                sql = "INSERT INTO Employees (firstName, lastName, postCode, contactNumber, emailAddress, userName, password, accessPrivilage) VALUES ('" + txtFirstname + "','" + txtSurname + "','" + txtPostcode + "','" + txtPhone + "','" + txtEmail + "','" + txtUsername + "','" + txtPassword + "',)";
                int reader = con.Insert(sql);



                if (reader == 1)
                {
                    retv = 1;
                    
                }
                else
                {
                    retv = 2;
                    
                }
                con.CloseConnection();
            }
            return retv;
        }
        public int addVehicle(String txtType, String txtDescription, int accessPrivilage)
        {
            int success = 0;

            if (con.OpenConnection())
            {
                String sql = "INSERT INTO Vehicles (vehicleType, vehicleDescription, vehicleStatusId) VALUES ('" + txtType + "','" + txtDescription + "','" + accessPrivilage +"')";
                int result = con.Insert(sql);
                


                if (result == 1)
                {
                    success = 1;
                  
                }
                else
                {
                    success = 0;
                    
                }
                con.CloseConnection();
            }
            return success;
        }
        public int addField(String txtReference, int txtSize, int fieldStatus)
        {
            int retv = 0;

            if (con.OpenConnection())
            {
                String sql = "INSERT INTO Fields (fieldReference, fieldSize, fieldStatus) VALUES (" + txtReference + ',' + txtSize + ',' + fieldStatus + ")";
                DbDataReader reader = con.Select(sql);


                if (reader.Read())
                {
                    retv = 1;
                    reader.Close();
                }
                else
                {
                    retv = 2;
                    reader.Close();
                }
                con.CloseConnection();
            }
            return retv;
        }
        public int addCrop(String txtCropName, int txtCultivationTime, int txtFertiliserFrequency, int txtYieldValue, string txtFertiliserName)
        {
            int retv = 0;

            if (con.OpenConnection())
            {
                int reader = con.Insert("INSERT INTO Crops (cropName, cultivationTime, fertiliserFrequency, yieldValue, fertiliserId) VALUES ('" + txtCropName + "','" + txtCultivationTime + ',' + txtFertiliserFrequency + ',' + txtYieldValue + ",1)");


                if (reader == 1)
                {
                    retv = 1;
                }
                else
                {
                    retv = 2;
               }
                con.CloseConnection();
            }
            return retv;
        }
        public int addStorageUnit(String txtReference, int txtTotalCapicity, int txtCurrentCapacity, int txtCurrentCrop)
        {
            int retv = 0;

            if (con.OpenConnection())
            {
                String sql = "INSERT INTO StorageUnits (storageReference, totalCapacity, currentCapacity, currentCrop) VALUES (" + txtReference + ',' + txtTotalCapicity + ',' + txtCurrentCapacity +',' + txtCurrentCrop + ")";
                DbDataReader reader = con.Select(sql);


                if (reader.Read())
                {
                    retv = 1;
                    reader.Close();
                }
                else
                {
                    retv = 2;
                    reader.Close();
                }
                con.CloseConnection();
            }
            return retv;
        }
        public int addTaskType(string txtTaskType, string txtTaskDesc)
        {
            int retv = 0;

            if (con.OpenConnection())
            {
                String sql = "INSERT INTO TaskType (taskName, taskDesc) VALUES (" + txtTaskType + ',' + txtTaskDesc + ")";
                DbDataReader reader = con.Select(sql);

                if (reader.Read())
                {
                    retv = 1;
                    reader.Close();
                }
                else
                {
                    retv = 2;
                    reader.Close();
                }
                con.CloseConnection();
            }
            return retv;
        }

        public int setTask(DateTime taskDate, int employeeId, int taskTypeId, int cropId, int fieldId, int vehicleId, int storageUnitId)
        {
            int success = 0;

            if (con.OpenConnection())
            {
                int taskStatusId = 1;

                int reader = con.Insert("INSERT INTO Tasks (taskDate, employeeId, taskTypeId, taskStatusId, cropId, fieldId, vehicleId, storageUnitId) VALUES ('" + taskDate + "'" + ',' + taskStatusId + ',' + employeeId + ',' + taskTypeId + ',' + cropId + ',' + fieldId + ',' + vehicleId + ',' + storageUnitId + ")");

                if (reader == 1)
                {
                    success = 1;
                }
                else
                {
                    success = 2;
                }
                con.CloseConnection();
            }
            return success;
        }
        public int EditVehicle(String ID, String txtType, String txtDescription, int vehStatusType)
        {
            int success = 0;
            

            if (con.OpenConnection())
            {
                String sql = "UPDATE Vehicles SET vehicleType = '" +txtType+ "', vehicleDescription = '" +txtDescription+"', vehicleStatusId = '"+ vehStatusType +"' WHERE vehicleId = " + ID + "";
                int result = con.Insert(sql);



                if (result == 1)
                {
                    success = 1;

                }
                else
                {
                    success = 0;

                }
                con.CloseConnection();
            }
            return success;
        }
    }
}
