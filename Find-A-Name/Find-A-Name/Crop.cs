using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Name
{
    public class Crop
    {
        private int m_id;
        public int Id { get { return m_id; } set { m_id = value; } }

        private String m_name;
        public String Name { get { return m_name; } set { m_name = value; } }

        private Int16 m_cultivaionTime;
        public Int16 CultivationTime { get { return m_cultivaionTime; } set { m_cultivaionTime = value; } }

        private Int16 m_fertiliserFrequency;
        public Int16 FertiliserFrequency { get { return m_fertiliserFrequency; } set { m_fertiliserFrequency = value; } }

        private int m_yeildValue;
        public int YieldValue { get { return m_yeildValue; } set { m_yeildValue = value; } }
    }
}
