using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class StorageUnit
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_reference;
        public String Reference { get { return m_reference; } set { m_reference = value; } }

        private Int32 m_totalCapacity;
        public Int32 TotalCapacity { get { return m_totalCapacity; } set { m_totalCapacity = value; } }

        private Int32 m_currentCapacity;
        public Int32 CurrentCapacity { get { return m_currentCapacity; } set { m_currentCapacity = value; } }

        private int m_cropId;
        public int CropId { get { return m_cropId; } set { m_cropId = value; } }
    }
}
