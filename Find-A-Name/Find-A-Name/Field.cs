using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Field
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private string m_reference;
        public string Reference { get { return m_reference; } set { m_reference = value; } }

        private int m_size;
        public int Size { get { return m_size; } set { m_size = value; } }

        private string m_status;
        public string Status { get { return m_status; } set { m_status = value; } }

        public override string ToString()
        {
            return m_reference;
        }
    }
}
