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

        // Could just have a set of static helper methods rather than a singleton!
        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT employeeId AS ID, lastName+', '+firstName AS Name, postCode AS Address, contactNumber AS Phone, emailAddress AS Email, accessPrivilage AS Privilage, dateCreated AS Created FROM Employees;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = dr.GetInt32(0);
                    employee.Name = dr.GetString(1);
                    employee.Phone = dr.GetInt32(2);
                    employee.Address = dr.GetString(3);
                    employee.Email = dr.GetString(4);
                    employee.Privilage = dr.GetBoolean(5);
                    //employee.Created = dr.GetDateTime(6);
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
