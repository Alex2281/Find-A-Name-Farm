using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_A_Name
{
    public partial class editVehicle : Form
    {
        BusinessMetaLayer bml = BusinessMetaLayer.instance();

        List<Vehicle> m_vehicles;
        BindingSource m_ve;

        public editVehicle()
        {
            InitializeComponent();


            m_ve = new BindingSource();
            m_vehicles = bml.getVehicles();
            m_ve.DataSource = m_vehicles;
            txtVehName.DataSource = m_ve;

        }
    }
}
