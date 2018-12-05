using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Task
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private DateTime m_taskDate;
        public DateTime TaskDate { get { return m_taskDate; } set { m_taskDate = value; } }

        private string m_employee;
        public string Employee { get { return m_employee; } set { m_employee = value; } }

        private string m_taskType;
        public string TaskType { get { return m_taskType; } set { m_taskType = value; } }

        private string m_taskStatus;
        public string TaskStatus { get { return m_taskStatus; } set { m_taskStatus = value; } }

        private string m_crop;
        public string Crop { get { return m_crop; } set { m_crop = value; } }

        private string m_field;
        public string Field { get { return m_field; } set { m_field = value; } }

        private string m_vehicle;
        public string Vehicle { get { return m_vehicle; } set { m_vehicle = value; } }

        private string m_storageUnit;
        public string StorageUnit { get { return m_storageUnit; } set { m_storageUnit = value; } }
    }
}
