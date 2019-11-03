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
    public partial class Staff : MetroFramework.Forms.MetroForm
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Staff", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Staff");
                    DGStaff.DataSource = ds.Tables["Staff"];
                    listStaff.DataSource = ds.Tables["Staff"];
                    listStaff.DisplayMember = "StaffName";
                    listStaff.ValueMember = "StaffID";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSinsert_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Staff", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Staff");

                    DataRow dr = ds.Tables["Staff"].NewRow();
                    dr["StaffID"] = txtSstaffid.Text;
                    dr["StaffName"] = txtSstaffname.Text;
                    dr["Depart"] = txtSdepart.Text;
                    dr["Gendar"] = txtSgendar.Text;
                    dr["Address"] = txtSaddre.Text;
                    dr["Cell#"] = txtScell.Text;
                    dr["DocID"] = txtSdocid.Text;

                    ds.Tables["Staff"].Rows.Add(dr);

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Staff");
                    txtSstaffid.Text = txtSstaffname.Text = txtSdepart.Text = txtSaddre.Text = txtScell.Text = txtSdocid.Text = txtSgendar.Text = "";
                    MessageBox.Show("Insert Successfully");
                    UpdateForm();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
           using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Staff where StaffID=" + listStaff.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Staff");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                    dr["StaffID"] = txtSstaffid.Text;
                    dr["StaffName"] = txtSstaffname.Text;
                    dr["Depart"] = txtSdepart.Text;
                    dr["Gendar"] = txtSgendar.Text;
                    dr["Address"] = txtSaddre.Text;
                    dr["Cell#"] = txtScell.Text;
                    dr["DocID"] = txtSdocid.Text;

                    }

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Staff");
                    txtSstaffid.Text = txtSstaffname.Text = txtSdepart.Text = txtSaddre.Text = txtScell.Text = txtSdocid.Text = txtSgendar.Text = "";
                    MessageBox.Show("Successfully Updated");
                    UpdateForm();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try
                    {
                        var adpt = new SqlDataAdapter(" Select * from Staff where StaffID=" + listStaff.SelectedValue, conn);
                        var ds = new DataSet();
                        adpt.Fill(ds, "Staff");

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dr.Delete();
                        }

                        var build = new SqlCommandBuilder(adpt);
                        adpt.Update(ds, "Staff");
                        txtSstaffid.Text = txtSstaffname.Text = txtSdepart.Text = txtSaddre.Text = txtScell.Text = txtSdocid.Text = txtSgendar.Text = "";
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

        private void btnSReset_Click(object sender, EventArgs e)
        {
            txtSstaffid.Text = txtSstaffname.Text = txtSdepart.Text = txtSaddre.Text = txtScell.Text = txtSdocid.Text = txtSgendar.Text = "";

        }

        private void listStaff_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Staff where StaffID=" + listStaff.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Staff");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        txtSstaffid.Text = dr["StaffID"].ToString();
                        txtSstaffname.Text = dr["StaffName"].ToString();
                        txtSdepart.Text = dr["Depart"].ToString();
                        txtSgendar.Text = dr["Gendar"].ToString();
                        txtScell.Text = dr["Cell#"].ToString();
                        txtSaddre.Text = dr["Address"].ToString();
                        txtSdocid.Text = dr["DocID"].ToString();

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
