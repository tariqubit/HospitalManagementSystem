using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMSDiss
{
    public partial class DoctorForm : MetroFramework.Forms.MetroForm
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try { 
                var adpt = new SqlDataAdapter(" Select * from Doctor", conn);
                var ds = new DataSet();
                adpt.Fill(ds, "Doctor");
                DGDoc.DataSource = ds.Tables["Doctor"];
                listDoc.DataSource = ds.Tables["Doctor"];
                listDoc.DisplayMember = "DocName";
                listDoc.ValueMember = "DocID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDinsert_Click(object sender, EventArgs e)
        {

        }

        private void btnDinsert_Click_1(object sender, EventArgs e)
        {
            
                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try
                    {
                        var adpt = new SqlDataAdapter(" Select * from Doctor", conn);
                        var ds = new DataSet();
                        adpt.Fill(ds, "Doctor");

                        DataRow dr = ds.Tables["Doctor"].NewRow();
                        dr["DocID"] = txtDdocid.Text;
                        dr["DocName"] = txtDdocname.Text;
                        dr["Fname"] = txtDFname.Text;
                        dr["Gendar"] = txtDgendar.Text;
                        dr["Address"] = txtDaddre.Text;
                        dr["designation"] = txtDdisg.Text;

                        ds.Tables["Doctor"].Rows.Add(dr);

                        var build = new SqlCommandBuilder(adpt);
                        adpt.Update(ds, "Doctor");
                        txtDdocid.Text = txtDdocname.Text = txtDFname.Text = txtDgendar.Text = txtDaddre.Text = txtDdisg.Text = "";
                        MessageBox.Show("Insert Successfully");
                        UpdateForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            

                
            }
        }

        private void listDoc_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                var adpt = new SqlDataAdapter(" Select * from Doctor where DocID="+listDoc.SelectedValue, conn);
                var ds = new DataSet();
                adpt.Fill(ds, "Doctor");

                foreach (DataRow dr in ds.Tables[0].Rows) 
                {
                    txtDdocid.Text = dr["DocID"].ToString();
                    txtDdocname.Text = dr["DocName"].ToString();
                    txtDFname.Text = dr["Fname"].ToString();
                    txtDdisg.Text = dr["Designation"].ToString();
                    txtDgendar.Text = dr["Gendar"].ToString();
                    txtDaddre.Text = dr["Address"].ToString();
                }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void btnDupdate_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try { 
                var adpt = new SqlDataAdapter(" Select * from Doctor where DocID=" + listDoc.SelectedValue, conn);
                var ds = new DataSet();
                adpt.Fill(ds, "Doctor");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["DocID"] = txtDdocid.Text;
                    dr["DocName"] = txtDdocname.Text;
                    dr["Fname"] = txtDFname.Text;
                    dr["Gendar"] = txtDgendar.Text;
                    dr["Address"] = txtDaddre.Text;
                    dr["designation"] = txtDdisg.Text;
                }

                var build = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "Doctor");
                txtDdocid.Text = txtDdocname.Text = txtDFname.Text = txtDgendar.Text = txtDaddre.Text = txtDdisg.Text = "";
                MessageBox.Show("Successfully Updated");
                UpdateForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try { 
                    var adpt = new SqlDataAdapter(" Select * from Doctor where DocID=" + listDoc.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Doctor");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr.Delete();
                    }

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Doctor");
                    txtDdocid.Text = txtDdocname.Text = txtDFname.Text = txtDgendar.Text = txtDaddre.Text = txtDdisg.Text = "";
                    MessageBox.Show("SuccessfullyDeleted");
                    UpdateForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDaddre.Text = "";
            txtDdocid.Text = "";
            txtDdocname.Text = "";
            txtDFname.Text = "";
            txtDgendar.Text = "";
            txtDdisg.Text = "";
            UpdateForm();
        }

        private void listDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
