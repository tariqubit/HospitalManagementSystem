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
    public partial class Bills : MetroFramework.Forms.MetroForm
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Bill", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Bill");
                    DGBills.DataSource = ds.Tables["Bill"];
                    listBills.DataSource = ds.Tables["Bill"];
                    listBills.DisplayMember = "PatName";
                    listBills.ValueMember = "BillNo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBinsert_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Bill", conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Bill");

                    DataRow dr = ds.Tables["Bill"].NewRow();
                    dr["BillNo"] = txtBbillNo.Text;
                    dr["PatName"] = txtBpatname.Text;
                    dr["DocName"] = txtBdocname.Text;
                    dr["DateTime"] = (DateTime)dtpbill.Value;
                    dr["Amount"] = txtBamount.Text;
                    dr["PatID"] = txtBpatid.Text;

                    ds.Tables["Bill"].Rows.Add(dr);

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Bill");
                    txtBbillNo.Text = txtBpatname.Text = txtBdocname.Text = txtBamount.Text = txtBpatid.Text = "";
                    MessageBox.Show("Insert Successfully");
                    UpdateForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBills_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Bill where BillNo=" + listBills.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Bill");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        txtBbillNo.Text = dr["BillNo"].ToString();
                        txtBpatname.Text = dr["PatName"].ToString();
                        txtBdocname.Text = dr["DocName"].ToString();
                        txtBamount.Text = dr["Amount"].ToString();
                        txtBpatid.Text = dr["PatID"].ToString();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBupdate_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    var adpt = new SqlDataAdapter(" Select * from Bill where BillNo=" + listBills.SelectedValue, conn);
                    var ds = new DataSet();
                    adpt.Fill(ds, "Bill");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["BillNo"] = txtBbillNo.Text;
                        dr["PatName"] = txtBpatname.Text;
                        dr["DocName"] = txtBdocname.Text;
                        dr["DateTime"] = (DateTime)dtpbill.Value;
                        dr["Amount"] = txtBamount.Text;
                        dr["PatID"] = txtBpatid.Text;
                    }

                    var build = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Bill");
                    txtBbillNo.Text = txtBpatname.Text = txtBdocname.Text = txtBamount.Text = txtBpatid.Text = "";
                    MessageBox.Show("Successfully Updated");
                    UpdateForm();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var conn = new SqlConnection(@"Data Source=ALTAIR-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    try
                    {
                        var adpt = new SqlDataAdapter(" Select * from Bill where BillNo=" + listBills.SelectedValue, conn);
                        var ds = new DataSet();
                        adpt.Fill(ds, "Bill");

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dr.Delete();
                        }

                        var build = new SqlCommandBuilder(adpt);
                        adpt.Update(ds, "Bill");
                        txtBbillNo.Text = txtBpatname.Text = txtBdocname.Text = txtBamount.Text = txtBpatid.Text = "";
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

        private void btnBReset_Click(object sender, EventArgs e)
        {
            txtBbillNo.Text = txtBpatname.Text = txtBdocname.Text = txtBamount.Text = txtBpatid.Text = "";

        }
    }
}
