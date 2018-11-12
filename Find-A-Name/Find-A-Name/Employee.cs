using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Employee
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_name;
        public String Name { get { return m_name; } set { m_name = value; } }

        private String m_address;
        public String Address { get { return m_address; } set { m_address = value; } }

        private Int64 m_phone;
        public Int64 Phone { get { return m_phone; } set { m_phone = value; } }      
        
        private String m_email;
        public String Email { get { return m_email; } set { m_email = value; } }

        private bool m_privilage;
        public bool Privilage { get { return m_privilage; } set { m_privilage = value; } }

        private String m_userName;
        public String UserName { get { return m_userName; } set { m_userName = value; } }

        private String m_secret;
        public String Secret { get { return m_secret; } set { m_secret = value; } }

        private DateTime m_created;
        public DateTime Created { get { return m_created; } set { m_created = value; } }

        public string loginCredentials()
        {
            return m_userName + "," + m_secret;
        }
        public override string ToString()
        {
            return m_name + ", " + m_email;
        }
    }
}
