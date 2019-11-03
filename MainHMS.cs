using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSDiss
{
    public partial class MainHMS : MetroFramework.Forms.MetroForm
    {
        public MainHMS()
        {
            InitializeComponent();
        }

        private void MainHMS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 pd = new Form2();
            pd.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PatientDiagnoses p = new PatientDiagnoses();
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm d = new DoctorForm();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
} 
