using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

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
                    bool privilage = reader.GetBoolean(0);

                    if (privilage)
                    {
                        retv = 0;
                    }
                    else if (!privilage)
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

        // Could just have a set of static helper methods rather than a singleton!
        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT employeeId AS Id, lastName+', '+firstName AS Name, postCode AS Address, contactNumber AS Phone, emailAddress AS Email, userName AS Username, password AS Secret, accessPrivilage AS Privilage, dateCreated AS Created FROM Employees;");

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
                    employee.Privilage = dr.GetBoolean(7);
                    employee.Created = dr.GetDateTime(8);
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
                DbDataReader dr = con.Select("SELECT vehicleId AS Id, vehicleType AS Name, vehicleDescription AS Details, vehicleStatusId AS Status FROM Vehicles;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.Id = dr.GetInt32(0);
                    vehicle.Type = dr.GetString(1);
                    vehicle.Description = dr.GetString(2);
                    vehicle.VehicleStatusId = dr.GetInt32(3);
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
                DbDataReader dr = con.Select("SELECT fieldId AS Id, fieldReference AS Locator, fieldSize AS Area, fieldStatusId AS Status FROM Fields;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Field field = new Field();
                    field.Id = dr.GetInt32(0);
                    field.Reference = dr.GetString(1);
                    field.Size = dr.GetInt32(2);
                    field.StatusId = dr.GetInt32(3);
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
                DbDataReader dr = con.Select("SELECT cropId AS Id, cropName AS Name, cultivationTime AS CultivationTime, fertiliserFrequency AS FertiniserFrequency, yieldvalue AS YealdValue, fertiliserId AS Fertiliser FROM Crops;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Crop crop = new Crop();
                    crop.Id = dr.GetInt32(0);
                    crop.Name = dr.GetString(1);
                    crop.CultivationTime = dr.GetInt16(2);
                    crop.FertiliserFrequency = dr.GetInt16(3);
                    crop.YieldValue = dr.GetInt32(4);
                    crop.FertiliserId = dr.GetInt32(5);
                    crops.Add(crop);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return crops;
        }
        public List<StorageUnit> getStorageUnits()
        {
            List<StorageUnit> storageUnits = new List<StorageUnit>();

            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT storageUnitId AS Id, storageReference AS Name, storageUnitCapacity AS Total, storedCapacity, storedCropId AS Crop FROM StorageUnits;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    StorageUnit storage = new StorageUnit();
                    storage.Id = dr.GetInt32(0);
                    storage.Reference = dr.GetString(1);
                    storage.TotalCapacity = dr.GetInt16(2);
                    storage.CropId = dr.GetInt16(3);
                    storage.CropId = dr.GetInt32(4);
                    storageUnits.Add(storage);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return storageUnits;
        }
    }
}
