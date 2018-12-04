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

        private string m_name;
        public string Name { get { return m_name; } set { m_name = value; } }

        private int m_cultivaionTime;
        public int CultivationTime { get { return m_cultivaionTime; } set { m_cultivaionTime = value; } }

        private int m_fertiliserFrequency;
        public int FertiliserFrequency { get { return m_fertiliserFrequency; } set { m_fertiliserFrequency = value; } }

        private int m_yeildValue;
        public int YieldValue { get { return m_yeildValue; } set { m_yeildValue = value; } }

        private string m_fertiliserName;
        public string FertiliserName { get { return m_fertiliserName; } set { m_fertiliserName = value; } }

        public override string ToString()
        {
            return m_name + ", " + m_id;
        }
    }
}
