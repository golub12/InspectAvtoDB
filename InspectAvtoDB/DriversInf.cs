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
    public partial class DriversInf : Form
    {
        Model1 db = new Model1(); 
        public DriversInf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Close();
        }

        private void DriversInf_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriversAddEdit frm = new DriversAddEdit();
            frm.db = db;
            frm.dri = null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drivers dri = (Drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show("Delete this ?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Drivers.Remove(dri);
                try
                {
                    db.SaveChanges();
                    driversBindingSource.DataSource = db.Drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivers dri = (Drivers)driversBindingSource.Current;
            DriversAddEdit frm = new DriversAddEdit();
            frm.db = db;
            frm.dri = dri;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }
    }
}
