﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Vehicle
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_type;
        public String Type { get { return m_type; } set { m_type = value; } }

        private String m_description;
        public String Description { get { return m_description; } set { m_description = value; } }

        private String m_Status;
        public String Status { get { return m_Status; } set { m_Status = value; } }

        public override string ToString()
        {
            return m_type;
        }
        
    }
}
