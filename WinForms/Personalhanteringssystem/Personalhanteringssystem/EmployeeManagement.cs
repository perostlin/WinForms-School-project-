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
    public partial class EmployeeManagement : Form
    {
        //Denna används för att behålla vald anställd markerad i listboxen - lboxEmployees.
        int choosenEmployee = 0;

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        /* Hämtar förnamn & efternamn på anställda ifrån Empoloyee-tabellen, samt andelnings-namn från Department-tabellen.
           Båda listboxarnas första värde/index blir automatiskt markerad när programmet startas.
        */
        public void EmployeeManagement_Load(object sender, EventArgs e)
        {
            FillListboxes();
            lboxEmployees.SelectedIndex = 0;
            lboxDepartments.SelectedIndex = 0;
        }

        public void FillListboxes()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            string empSql = "select Id, Firstname, Lastname " +
                            "from Employee";
            SqlCommand cm1 = new SqlCommand(empSql, cn);

            SqlDataReader dataReaderEmp = null;

            string depSql = "select Name " +
                            "from Department";
            SqlCommand cm2 = new SqlCommand(depSql, cn);

            SqlDataReader dataReaderDep = null;

            try
            {
                cn.Open();

                //Lägger till alla anställda till lboxEmployees från Employee-tabellen.
                dataReaderEmp = cm1.ExecuteReader();

                using (dataReaderEmp)
                {
                    lboxEmployees.Items.Clear();

                    while (dataReaderEmp.Read())
                    {
                        string EID = dataReaderEmp["Id"].ToString();
                        string firstName = dataReaderEmp["Firstname"].ToString();
                        string lastName = dataReaderEmp["Lastname"].ToString();
                        string fullName = firstName + " " + lastName;
                        lboxEmployees.Items.Add(EID + ": " + fullName);
                    }
                }

                //Lägger till alla avdelningar till lboxDepartments från Department-tabellen.
                dataReaderDep = cm2.ExecuteReader();

                using (dataReaderDep)
                {
                    lboxDepartments.Items.Clear();
                    cboxEmpDepartment.Items.Clear();

                    while (dataReaderDep.Read())
                    {
                        string departmentName = dataReaderDep["Name"].ToString();
                        lboxDepartments.Items.Add(departmentName);
                        cboxEmpDepartment.Items.Add(departmentName);
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
        //Metod slut.

        //När man väljer en anställd i lboxEmployees-listboxen så skall all information om personen visas upp i fälten till höger om listboxen.
        private void lboxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEmployeeInfo();
        }

        private void ShowEmployeeInfo()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            choosenEmployee = lboxEmployees.SelectedIndex;
            string name = lboxEmployees.SelectedItem.ToString();
            int quotes = name.IndexOf(":");
            int blankspace = name.IndexOf(" ");
            string EID = name.Substring(0, quotes);

            //Utgår från Anställnings Id:t när man skall hämta ut information angående vald anställd.
            string empSql = "select e.*, d.Name " +
                            "from Employee e " +
                            "join Department d " +
                            "on e.DepartmentId = d.Id " +
                            "where e.Id = " + "'" + EID + "'";
            SqlCommand cm = new SqlCommand(empSql, cn);

            SqlDataReader dr = null;

            try
            {
                cn.Open();

                //All information angående vald anställd läggs till i datareader(dr)-instansen.
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    lbEID.Text = dr["Id"].ToString();

                    string firstName = dr["Firstname"].ToString();
                    string lastName = dr["Lastname"].ToString();
                    string fullName = firstName + " " + lastName;
                    tbName.Text = fullName;

                    tbEmail.Text = dr["Email"].ToString();

                    string date = dr["dateofbirth"].ToString();

                    DateTime dateOfBirth = Convert.ToDateTime(date, CultureInfo.CreateSpecificCulture("en-us").DateTimeFormat);
                    dtpBirthDate.Value = dateOfBirth;

                    cboxEmpDepartment.Text = dr["Name"].ToString();

                    bool isOnParentalLeave = Convert.ToBoolean(dr["OnParentalLeave"]);
                    if (isOnParentalLeave == true)
                    {
                        cboxOnParentalLeave.Checked = true;
                    }
                    else
                    {
                        cboxOnParentalLeave.Checked = false;
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
        //Metod slut.

        //Sparar ner ändringar i vald anställd till databasen.
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            int employeeId = Convert.ToInt32(lbEID.Text);

            string name = tbName.Text;
            string lastname = null;
            string firstname = null;

            string empEmail = tbEmail.Text;
            DateTime empDateOfBirth = dtpBirthDate.Value;
            int empDepartment = cboxEmpDepartment.SelectedIndex + 1;

            int empIsOnParentalLeave = 0;
            if (cboxOnParentalLeave.Checked)
            {
                empIsOnParentalLeave = 1;
            }
            else
            {
                empIsOnParentalLeave = 0;
            }

            try
            {
                cn.Open();

                //OM fält skulle vara tomma så visas det röd-hjälptext för att visa vart felet är.                                
                if (name == "")
                {
                    lbErrSaveFname.Visible = true;
                }
                else if (tbEmail.Text == "")
                {
                    lbErrSaveEmail.Visible = true;
                }
                else if (empDateOfBirth.Year <= 1949 || empDateOfBirth.Year >= 1997)
                {
                    lbErrSaveBirthDate.Visible = true;
                }
                else if (cboxEmpDepartment.Text == "")
                {
                    lbErrSaveBirthDate.Visible = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Är du säker på att du vill spara dina ändringar?", "Varning...", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int blankspace = name.IndexOf(" ");
                        firstname = name.Substring(0, blankspace);
                        lastname = name.Substring(blankspace + 1);

                        string empSql = "update Employee " +
                            "set Firstname = " + "'" + firstname + "'" + ", " + "Lastname = " + "'" + lastname + "'" + ", " +
                            "Email = " + "'" + empEmail + "'" + ", " + "DateOfBirth = " + "'" + empDateOfBirth + "'" + ", " +
                            "OnParentalLeave = " + "'" + empIsOnParentalLeave + "'" + ", " + "DepartmentId = " + "'" + empDepartment + "'" +
                            "where Id = " + employeeId;
                        SqlCommand cm = new SqlCommand(empSql, cn);

                        cm.ExecuteNonQuery();

                        MessageBox.Show("Ändringarna är sparade!", "Lyckades", MessageBoxButtons.OK);

                        FillListboxes();
                        lboxEmployees.SelectedIndex = choosenEmployee;
                    }
                    else if (result == DialogResult.No)
                    {
                        //Gör inget...
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show("Du måste välja en anställd i listan innan du kan spara!" + Environment.NewLine + exep.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        //Metod slut.

        //Tar bort en anställd ur systemet.
        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            RemoveEmployeeFromSystem();
        }

        private void RemoveEmployeeFromSystem()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            int employeeId = Convert.ToInt32(lbEID.Text);

            string empSql = "delete from Employee " +
                            "where Id = " + employeeId;
            SqlCommand cm = new SqlCommand(empSql, cn);

            try
            {
                cn.Open();

                DialogResult result = MessageBox.Show("Är du säker på att du vill tabort denna användare ur systemet?", "Varning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cm.ExecuteNonQuery();
                    DialogResult test = MessageBox.Show("Vald anställd raderad!", "Lyckades", MessageBoxButtons.OK);
                    if (test == DialogResult.OK)
                    {
                        FillListboxes();
                        tbName.Clear();
                        tbEmail.Clear();
                        dtpBirthDate.ResetText();
                        cboxEmpDepartment.ResetText();
                        cboxOnParentalLeave.Checked = false;
                        lboxEmployees.SelectedIndex = 0;
                    }
                }
                else if (result == DialogResult.No)
                {
                    //Gör inget...
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
        //Metod slut.

        //Fyller lboxDepEmployees med vilka som ingår i vald avdelning.
        private void lboxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmployeesWorkingOnDepartment();
        }

        private void FillEmployeesWorkingOnDepartment()
        {
            string db = Properties.Settings.Default.ProjektDBCS;
            SqlConnection cn = new SqlConnection(db);

            string depName = lboxDepartments.SelectedItem.ToString();

            string empSql = "select Firstname, Lastname " +
                            "from Employee e " +
                            "join Department d " +
                            "on e.DepartmentId = d.Id " +
                            "where d.Name = " + "'" + depName + "'";
            SqlCommand cm = new SqlCommand(empSql, cn);

            SqlDataReader dr = null;

            try
            {
                cn.Open();

                //All information angående vald anställd läggs till i datareader(dr)-instansen.
                dr = cm.ExecuteReader();

                lboxDepEmployees.Items.Clear();

                while (dr.Read())
                {
                    string firstName = dr["Firstname"].ToString();
                    string lastName = dr["Lastname"].ToString();
                    string fullName = firstName + " " + lastName;
                    lboxDepEmployees.Items.Add(fullName);
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
        //Metod slut.

        //När knappen klickas så skapas en ny instans av FAddEmployee-form och visar sedan denna med hjälp av Show()-metoden. 
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            ShowAddEmployeeWindow();
        }

        private void ShowAddEmployeeWindow()
        {
            FAddEmployee AddNewEmployee = new FAddEmployee();
            AddNewEmployee.ShowDialog();
        }
        //Metod slut

        /*Metoderna nedan gör:
         *Om man har fått upp den röda-hjälptexten (pga att man glömt skriva in något värde eller glömt välja avdelning)
         *Så försvinner dom genom att man markerar textbox/kontrollen men hjälptext brevid sig och anger/ändrar värdet.
         */
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Focus())
            {
                lbErrSaveFname.Visible = false;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Focus())
            {
                lbErrSaveEmail.Visible = false;
            }
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBirthDate.Focus())
            {
                lbErrSaveBirthDate.Visible = false;
            }
        }
    }
}