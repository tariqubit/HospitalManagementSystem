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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from PatientDiagnosis", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "PatientDiagnosis");
                    DGPatDiag.DataSource = ds.Tables["PatientDiagnosis"];
                    listPatDiag.DataSource = ds.Tables["PatientDiagnosis"];
                    listPatDiag.DisplayMember = "DiagDetails";
                    listPatDiag.ValueMember = "DiagNo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPDinsert_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from PatientDiagnosis", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "PatientDiagnosis");

                    DataRow dr = ds.Tables["PatientDiagnosis"].NewRow();
                    dr["DiagNo"] = txtPDdiagno.Text;
                    dr["DiagDetails"] = txtPDdiagDetails.Text;
                    dr["Remark"] = txtPDremark.Text;
                    dr["DiagDate"] = (DateTime)dtppd.Value;
                    dr["PatID"] = txtPDpatid.Text;
                    

                    ds.Tables["PatientDiagnosis"].Rows.Add(dr);

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "PatientDiagnosis");
                    txtPDdiagno.Text = txtPDdiagDetails.Text = txtPDpatid.Text = txtPDremark.Text = "";
                    MessageBox.Show("Insert Successfully");
                    UpdateForm();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void btnPDupdate_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from PatientDiagnosis where DiagNo=" + listPatDiag.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "PatientDiagnosis");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["DiagNo"] = txtPDdiagno.Text;
                        dr["DiagDetails"] = txtPDdiagDetails.Text;
                        dr["Remark"] = txtPDremark.Text;
                        dr["DiagDate"] = (DateTime)dtppd.Value;
                        dr["PatID"] = txtPDpatid.Text;

                    }

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "PatientDiagnosis");
                    txtPDdiagno.Text = txtPDdiagDetails.Text = txtPDpatid.Text =txtPDremark.Text= "";
                    MessageBox.Show("Successfully Updated");
                    UpdateForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listPatDiag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPatDiag_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from PatientDiagnosis where DiagNo=" + listPatDiag.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "PatientDiagnosis");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        txtPDdiagno.Text = dr["DiagNo"].ToString();
                        txtPDdiagDetails.Text = dr["DiagDetails"].ToString();
                        txtPDremark.Text = dr["Remark"].ToString();
                        txtPDpatid.Text = dr["PatID"].ToString();
                     
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPDdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try
                    {
                        var adpt = new SqlDataAdapter(" Select * from PatientDiagnosis where DiagNo=" + listPatDiag.SelectedValue, conn);
                        var ds = new DataSet();
                        adpt.Fill(ds, "PatientDiagnosis");

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dr.Delete();
                        }

                        var build = new SqlCommandBuilder(adpt);
                        adpt.Update(ds, "PatientDiagnosis");
                        txtPDdiagno.Text = txtPDdiagDetails.Text = txtPDpatid.Text = txtPDremark.Text = ""; 
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

        private void btnPDReset_Click(object sender, EventArgs e)
        {
            txtPDdiagno.Text = txtPDdiagDetails.Text = txtPDpatid.Text = txtPDremark.Text = "";
            
        }
    }
}
