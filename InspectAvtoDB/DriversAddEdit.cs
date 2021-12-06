using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectAvtoDB
{
    public partial class DriversAddEdit : Form
    {
        public Model1 db { get; set; }
        public Drivers dri { get; set; }
        public DriversAddEdit()
        {
            InitializeComponent();
        }

        private void DriversAddEdit_Load(object sender, EventArgs e)
        {
            if (dri == null)
            {
                driversBindingSource.AddNew();
                this.Text = "New driver";
            }
            else
            {
                driversBindingSource.Add(dri);
                this.Text = "Correct";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dri == null)
            {
                dri = (Drivers)driversBindingSource.List[0];
                db.Drivers.Add(dri);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error " + ex.InnerException.InnerException.Message);
            }
        }
    }
}
