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
    public partial class PatientDiagnoses : MetroFramework.Forms.MetroForm
    {
        public PatientDiagnoses()
        {
            InitializeComponent();
        }

        private void PatientDiagnoses_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Patient", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Patient");
                    DGPat.DataSource = ds.Tables["Patient"];
                    listPat.DataSource = ds.Tables["Patient"];
                    listPat.DisplayMember = "PatName";
                    listPat.ValueMember = "PatID";
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPinsert_Click(object sender, EventArgs e)
        {

            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Patient", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Patient");

                    DataRow dr = ds.Tables["Patient"].NewRow();
                    dr["PatID"] = txtPpatid.Text;
                    dr["PatName"] = txtPpatname.Text;
                    dr["Fname"] = txtPFname.Text;
                    dr["Gendar"] = txtPgendar.Text;
                    dr["Address"] = txtPaddre.Text;
                    dr["Tell#"] = txtPtell.Text;
                    dr["DocID"] = txtPdocid.Text;

                    ds.Tables["Patient"].Rows.Add(dr);

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Patient");
                    txtPpatid.Text = txtPpatname.Text = txtPFname.Text = txtPgendar.Text = txtPaddre.Text = txtPtell.Text = txtPdocid.Text = "";
                    MessageBox.Show("Insert Successfully");
                    UpdateForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btnPupdate_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Patient where PatID=" + listPat.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Patient");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["PatID"] = txtPpatid.Text;
                        dr["PatName"] = txtPpatname.Text;
                        dr["Fname"] = txtPFname.Text;
                        dr["Gendar"] = txtPgendar.Text;
                        dr["Address"] = txtPaddre.Text;
                        dr["Tell#"] = txtPtell.Text;
                        dr["DocID"] = txtPdocid.Text;
                    }

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Patient");
                    txtPpatid.Text = txtPpatname.Text = txtPFname.Text = txtPgendar.Text = txtPaddre.Text = txtPtell.Text = txtPdocid.Text = "";
                    MessageBox.Show("Successfully Updated");
                    UpdateForm();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try
                    {
                        var adpt = new SqlDataAdapter(" Select * from Patient where PatID=" + listPat.SelectedValue, conn);
                        var ds = new DataSet();
                        adpt.Fill(ds, "Patient");

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dr.Delete();
                        }

                        var build = new SqlCommandBuilder(adpt);
                        adpt.Update(ds, "Patient");
                        txtPpatid.Text = txtPpatname.Text = txtPFname.Text = txtPgendar.Text = txtPaddre.Text = txtPtell.Text = txtPdocid.Text = "";
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

        private void btnPReset_Click(object sender, EventArgs e)
        {
            txtPaddre.Text = "";
            txtPpatid.Text = "";
            txtPpatname.Text = "";
            txtPFname.Text = "";
            txtPgendar.Text = "";
            txtPtell.Text = "";
            txtPdocid.Text = "";
            UpdateForm();
        }

        private void listPat_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Patient where PatID=" + listPat.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Patient");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        txtPpatid.Text = dr["PatID"].ToString();
                        txtPpatname.Text = dr["PatName"].ToString();
                        txtPFname.Text = dr["Fname"].ToString();
                        txtPgendar.Text = dr["Gendar"].ToString();
                        txtPtell.Text = dr["Tell#"].ToString();
                        txtPaddre.Text = dr["Address"].ToString();
                        txtPdocid.Text = dr["DocID"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
