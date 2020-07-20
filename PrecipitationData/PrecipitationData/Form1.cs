using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecipitationData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rainFallDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rainFallDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rainFallDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rainFallDataSet1.RainFallData' table. You can move, or remove it, as needed.
            this.rainFallDataTableAdapter.Fill(this.rainFallDataSet1.RainFallData);

        }
    }
}
