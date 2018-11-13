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

        public int farmLogin(String txtUsername, String txtPassword)
        {
            string message = "";
            int retv = -1;
            DbConection con = DbFactory.instance();
            
            if (con.OpenConnection())
            {
                String sql = "SELECT * from Employees where userName='"+ txtUsername + "' AND password='" + txtPassword +"'";
                DbDataReader reader = con.Select(sql);
                
                       
                int count = 0;
                //Read the data and store them in the list
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    message = "Username and password is correct";
                }
                else if (count > 1)
                {
                    message = "Duplicate username and password";

                }
                else
                {
                    message = "Username and password is not correct";
                }
                //close Data Reader
                reader.Close();
                con.CloseConnection();
            }
            return retv;
        }

        // Could just have a set of static helper methods rather than a singleton!
        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT employeeId AS ID, lastName+', '+firstName AS Name, postCode AS Address, contactNumber AS Phone, emailAddress AS Email, userName AS Username, password AS Secret, accessPrivilage AS Privilage, dateCreated AS Created FROM Employees;");

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
                    //employee.Created = dr.GetDateTime(8);
                    employees.Add(employee);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return employees;
        }
    }
}
