
using JobTracker.Models;
using JobTracker.Repositories;
using MySql.Data.MySqlClient;
using JobTracker;
using System.ComponentModel.Design.Serialization;
namespace JobTracker
{
    public partial class MainForm : Form
    {
        private readonly CompanyRepository companyRepository = new CompanyRepository();
        private readonly JobApplicationRepository jobApplicationRepository = new JobApplicationRepository();
        private int selectedCompanyId;
        private int selectedApplicationId;
        public MainForm()
        {
            InitializeComponent();
            LoadCompanies();
            LoadCompanyCombo();
            LoadStatusCombo();
            LoadApplications();
            dgvApplications.Columns["Id"].Visible = false;
            dgvApplications.Columns["CompanyId"].Visible = false;

            dgvApplications.Columns["CompanyName"].HeaderText = "Cég";
            dgvApplications.Columns["Position"].HeaderText = "Pozíció";
            dgvApplications.Columns["ApplicationStatus"].HeaderText = "Státusz";
            dgvApplications.Columns["DateApplied"].HeaderText = "Jelentkezés dátuma";
            dgvApplications.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.RowHeadersVisible = false;
            dgvApplications.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dgvApplications.MultiSelect = false;

            dgvCompanies.Columns["Id"].Visible = false;

            dgvCompanies.Columns["CompanyName"].HeaderText = "Cég";
            dgvCompanies.Columns["City"].HeaderText = "Város";
            dgvCompanies.Columns["Website"].HeaderText = "Weboldal";

            dgvCompanies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCompanies.RowHeadersVisible = false;


        }
        private void LoadCompanies()
        {
            dgvCompanies.DataSource = companyRepository.GetAllCompanies();
            dgvCompanies.Columns["Id"].Visible = false;

            dgvCompanies.Columns["CompanyName"].HeaderText = "Cég";
            dgvCompanies.Columns["City"].HeaderText = "Város";
            dgvCompanies.Columns["Website"].HeaderText = "Weboldal";

            dgvCompanies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCompanies.RowHeadersVisible = false;

            dgvCompanies.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCompanies.MultiSelect = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Company company = new Company();
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Add meg a cég nevét!");
                txtCompanyName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Add meg a várost!");
                txtCity.Focus();
                return;
            }

            company.CompanyName = txtCompanyName.Text;
            company.City = txtCity.Text;
            company.Website = txtWebsite.Text;
            companyRepository.AddCompany(company);
            MessageBox.Show("Cég sikeresen hozzáadva!");

            LoadCompanies();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvCompanies.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dgvCompanies.SelectedRows[0].Cells["Id"].Value
                );


                companyRepository.DeleteCompany(id);


                MessageBox.Show("Cég törölve!");


                LoadCompanies();
            }
            else
            {
                MessageBox.Show("Válassz ki egy céget!");
            }
        }
        private void dgvCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCompanies.Rows[e.RowIndex];
                selectedCompanyId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCompanyName.Text = row.Cells["CompanyName"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtWebsite.Text = row.Cells["Website"].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lefutott");
            Company company = new Company();
            company.Id = selectedCompanyId;
            company.CompanyName = txtCompanyName.Text;
            company.City = txtCity.Text;
            company.Website = txtWebsite.Text;
            companyRepository.UpdateCompany(company);
            MessageBox.Show("Cég módosítva!");
            LoadCompanies();

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadCompanies();
                return;
            }


            List<Company> companies =
                companyRepository.SearchCompanies(txtSearch.Text);

            dgvCompanies.DataSource = companies;
        }

        private void LoadCompanyCombo()
        {
            List<Company> companies = companyRepository.GetAllCompanies();
            cmbCompany.DataSource = companies;
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "Id";
        }
        private void LoadStatusCombo()
        {

            cmbStatus.Items.Add("Elküldve");
            cmbStatus.Items.Add("Interjú");
            cmbStatus.Items.Add("Elfogadva");
            cmbStatus.Items.Add("Elutasítva");
            cmbStatus.SelectedIndex = 0;



        }
        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Válassz céget!");
                cmbCompany.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Add meg a pozíciót!");
                txtPosition.Focus();
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Válassz státuszt!");
                cmbStatus.Focus();
                return;
            }
            JobApplication application = new JobApplication();
            application.CompanyId = (int)cmbCompany.SelectedValue;
            application.Position = txtPosition.Text;
            application.ApplicationStatus = cmbStatus.SelectedItem.ToString();
            application.DateApplied = dtpDate.Value;
            jobApplicationRepository.AddApplication(application);
            MessageBox.Show("Jelentkezés sikeresen hozzáadva!");
            LoadApplications();
        }
        private void LoadApplications()
        {
            List<JobApplication> applications = jobApplicationRepository.GetAllApplications();
            dgvApplications.DataSource = applications;

            dgvApplications.Columns["Id"].Visible = false;
            dgvApplications.Columns["CompanyId"].Visible = false;

            dgvApplications.Columns["CompanyName"].HeaderText = "Cég";
            dgvApplications.Columns["Position"].HeaderText = "Pozíció";
            dgvApplications.Columns["ApplicationStatus"].HeaderText = "Státusz";
            dgvApplications.Columns["DateApplied"].HeaderText = "Jelentkezés dátuma";

            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvApplications.RowHeadersVisible = false;

            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.MultiSelect = false;
        }
        private void dgvApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvApplications.Rows[e.RowIndex];
                selectedApplicationId = Convert.ToInt32(row.Cells["Id"].Value);
                cmbCompany.SelectedValue = row.Cells["CompanyId"].Value;

                txtPosition.Text = row.Cells["Position"].Value.ToString();

                cmbStatus.Text = row.Cells["ApplicationStatus"].Value.ToString();

                dtpDate.Value = Convert.ToDateTime(
                    row.Cells["DateApplied"].Value);
            }
        }
        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            if(selectedApplicationId > 0)
            {
                jobApplicationRepository.DeleteApplication(selectedApplicationId);
                MessageBox.Show("Jelentkezés törölve!");
                LoadApplications();
            }
            else
            {
                MessageBox.Show("Válassz ki egy jelentkezést!");
            }
        }
        private void btnUpdateApplication_Click(object sender, EventArgs e)
        {
            JobApplication application = new JobApplication();
            application.Id = selectedApplicationId;
            application.CompanyId = (int)cmbCompany.SelectedValue;
            application.Position = txtPosition.Text;
            application.ApplicationStatus = cmbStatus.Text;
            application.DateApplied = dtpDate.Value;
            jobApplicationRepository.UpdateApplication(application);
            MessageBox.Show("Jelentkezés módosítva");
            LoadApplications();

        }
    }
            
}
