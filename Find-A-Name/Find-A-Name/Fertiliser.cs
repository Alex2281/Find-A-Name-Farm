﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Fertiliser
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_name;
        public String Name { get { return m_name; } set { m_name = value; } }

        private Int32 m_stockQuantity;
        public Int32 StockQuantity { get { return m_stockQuantity; } set { m_stockQuantity = value; } }

    }
}
