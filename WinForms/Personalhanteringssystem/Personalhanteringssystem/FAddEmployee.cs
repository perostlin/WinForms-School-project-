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
using System.Globalization;

namespace Personalhanteringssystem
{
    public partial class FAddEmployee : Form
    {
        public FAddEmployee()
        {
            InitializeComponent();
        }

        //Stänger ner FAddEmployee-formen.
        private void btnCancelNewEmp_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Lägger till en ny anställd till Employee-tabellen.
        private void btnSaveNewEmp_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }

        private void AddNewEmployee()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            string newEmpFname = tbNewEmpFName.Text;
            string newEmpLname = tbNewEmpLName.Text;
            string newEmpEmail = tbNewEmpEmail.Text;
            DateTime newEmpDateOfBirth = dtpNewEmpBirthdate.Value;

            int newEmpIsOnParentalLeave = 0;
            if (cboxNewEmpOnParentalLeave.Checked)
            {
                newEmpIsOnParentalLeave = 1;
            }
            else
            {
                newEmpIsOnParentalLeave = 0;
            }

            int newEmpDepartment = cboxNewEmpDepartment.SelectedIndex + 1;



            string empSql = "insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId) " +
                          "values(" + "'" + newEmpFname + "'" + ", " + "'" + newEmpLname + "'" + ", " + "'" +
                                  newEmpEmail + "'" + ", " + "'" + newEmpDateOfBirth + "'" + ", " +
                                  newEmpIsOnParentalLeave + ", " + newEmpDepartment + ")";
            SqlCommand cm = new SqlCommand(empSql, cn);

            try
            {
                cn.Open();

                //OM fält skulle vara tomma så visas det röd-hjälptext för att visa vart felet är.                
                if (tbNewEmpFName.Text == "")
                {
                    lbErrFname.Visible = true;
                }
                else if (tbNewEmpLName.Text == "")
                {
                    lbErrLname.Visible = true;
                }
                else if (tbNewEmpEmail.Text == "")
                {
                    lbErrEmail.Visible = true;
                }
                else if(newEmpDateOfBirth.Year <= 1949 || newEmpDateOfBirth.Year >= 1997)
                {
                    lbErrNewEmpDateOfBirth.Visible = true;
                }
                else if (cboxNewEmpDepartment.Text == "Välj avdelning")
                {
                    lbErrDepartment.Visible = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Är du säker på att du vill spara?", "Varning...", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        cm.ExecuteNonQuery();

                        DialogResult close = MessageBox.Show("Ny anställd inlagd!", "Lyckades", MessageBoxButtons.OK);
                        if(close == DialogResult.OK)
                        {
                            //Stänger ner FAddNewEmployee-formen och kör FillListboxes()-metoden i EmployeeManagement-formen.
                            Close();
                            ((EmployeeManagement)Application.OpenForms["EmployeeManagement"]).FillListboxes();
                        }
                        
                    }
                    else if (result == DialogResult.No)
                    {
                        //Gör inget...
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show("Ett fel uppstod. Se följande: " + Environment.NewLine + exep);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        //Fyller cboxNewEmpDepartment-comboboxen med avdelningar från Department-tabellen.
        private void FAddEmployee_Load(object sender, EventArgs e)
        {
            FillDepartmentComboBox();
        }

        private void FillDepartmentComboBox()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            string depSql = "select Name " +
                            "from Department";
            SqlCommand cm2 = new SqlCommand(depSql, cn);

            SqlDataReader dr = null;

            try
            {
                cn.Open();

                //Lägger till alla avdelningar till cboxNewEmpDepartments från Department-tabellen.
                dr = cm2.ExecuteReader();

                while (dr.Read())
                {
                    string departmentName = dr["Name"].ToString();
                    cboxNewEmpDepartment.Items.Add(departmentName);
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show("Ett fel uppstod. Se följande: " + Environment.NewLine + exep);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        /*Metoderna nedan gör:
         *Om man har fått upp den röda-hjälptexten (pga att man glömt skriva in något värde eller glömt välja avdelning)
         *Så försvinner dom genom att man markerar textbox/kontrollen men hjälptext brevid sig och anger/ändrar värdet.
         */
        private void tbNewEmpFName_TextChanged(object sender, EventArgs e)
        {
            if(tbNewEmpFName.Focus())
            {
                lbErrFname.Visible = false;
            }
        }

        private void tbNewEmpLName_TextChanged(object sender, EventArgs e)
        {
            if(tbNewEmpLName.Focus())
            {
                lbErrLname.Visible = false;
            }
        }

        private void tbNewEmpEmail_TextChanged(object sender, EventArgs e)
        {
            if(tbNewEmpEmail.Focus())
            {
                lbErrEmail.Visible = false;
            }
        }

        private void dtpNewEmpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNewEmpBirthdate.Focus())
            {
                lbErrNewEmpDateOfBirth.Visible = false;
            }
        }

        private void cboxNewEmpDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxNewEmpDepartment.Focus())
            {
                lbErrDepartment.Visible = false;
            }
        }
        //Metoder slut.
    }
}