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

        private DateTime m_entryDate;
        public DateTime EntryDate { get { return m_entryDate; } set { m_entryDate = value; } }

        private DateTime m_scheduledDate;
        public DateTime ScheduledDate { get { return m_scheduledDate; } set { m_scheduledDate = value; } }

        private int m_employeeId;
        public int EmployeeId { get { return m_employeeId; } set { m_employeeId = value; } }

        private int m_taskTypeId;
        public int TaskTypeId { get { return m_taskTypeId; } set { m_taskTypeId = value; } }

        private int m_taskStatusId;
        public int TaskStatusId { get { return m_taskStatusId; } set { m_taskStatusId = value; } }

        private int m_cropId;
        public int CropId { get { return m_cropId; } set { m_cropId = value; } }

        private int m_fieldId;
        public int FieldId { get { return m_fieldId; } set { m_fieldId = value; } }

        private int m_vehicleId;
        public int VehicleId { get { return m_vehicleId; } set { m_vehicleId = value; } }

        private int m_storageUnitId;
        public int StorageUnitId { get { return m_storageUnitId; } set { m_storageUnitId = value; } }
    }
}
