using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class TaskType
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_name;
        public String Name { get { return m_name; } set { m_name = value; } }

        private String m_description;
        public String Description { get { return m_description; } set { m_description = value; } }
 
        public override string ToString()
        {
            return m_name;
        }
    }
}
