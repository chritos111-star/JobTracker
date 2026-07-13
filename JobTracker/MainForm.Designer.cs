namespace JobTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabCompanies = new TabControl();
            tabCompanierPage = new TabPage();
            dgvCompanies = new DataGridView();
            txtSearch = new TextBox();
            CompanyName = new Label();
            btnDelete = new Button();
            Citylbl = new Label();
            btnClear = new Button();
            lblWebsite = new Label();
            btnUpdate = new Button();
            txtWebsite = new TextBox();
            btnAdd = new Button();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            tabApplicationsPage = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnUpdateApplication = new Button();
            btnDeleteApplication = new Button();
            dgvApplications = new DataGridView();
            btnAddApplication = new Button();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            txtPosition = new TextBox();
            cmbCompany = new ComboBox();
            tabCompanies.SuspendLayout();
            tabCompanierPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).BeginInit();
            tabApplicationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 350);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Keresés:";
            // 
            // tabCompanies
            // 
            tabCompanies.Controls.Add(tabCompanierPage);
            tabCompanies.Controls.Add(tabApplicationsPage);
            tabCompanies.Location = new Point(12, 12);
            tabCompanies.Name = "tabCompanies";
            tabCompanies.SelectedIndex = 0;
            tabCompanies.Size = new Size(960, 503);
            tabCompanies.TabIndex = 26;
            // 
            // tabCompanierPage
            // 
            tabCompanierPage.Controls.Add(dgvCompanies);
            tabCompanierPage.Controls.Add(label1);
            tabCompanierPage.Controls.Add(txtSearch);
            tabCompanierPage.Controls.Add(CompanyName);
            tabCompanierPage.Controls.Add(btnDelete);
            tabCompanierPage.Controls.Add(Citylbl);
            tabCompanierPage.Controls.Add(btnClear);
            tabCompanierPage.Controls.Add(lblWebsite);
            tabCompanierPage.Controls.Add(btnUpdate);
            tabCompanierPage.Controls.Add(txtWebsite);
            tabCompanierPage.Controls.Add(btnAdd);
            tabCompanierPage.Controls.Add(txtCity);
            tabCompanierPage.Controls.Add(txtCompanyName);
            tabCompanierPage.Location = new Point(4, 24);
            tabCompanierPage.Name = "tabCompanierPage";
            tabCompanierPage.Padding = new Padding(3);
            tabCompanierPage.Size = new Size(952, 475);
            tabCompanierPage.TabIndex = 0;
            tabCompanierPage.Text = "Cégek";
            tabCompanierPage.UseVisualStyleBackColor = true;
            // 
            // dgvCompanies
            // 
            dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanies.Location = new Point(6, 6);
            dgvCompanies.Name = "dgvCompanies";
            dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanies.Size = new Size(744, 245);
            dgvCompanies.TabIndex = 14;
            dgvCompanies.CellClick += dgvCompanies_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(498, 342);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 23);
            txtSearch.TabIndex = 25;
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Location = new Point(6, 265);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(97, 15);
            CompanyName.TabIndex = 15;
            CompanyName.Text = "Company Name:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(263, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Citylbl
            // 
            Citylbl.AutoSize = true;
            Citylbl.Location = new Point(6, 309);
            Citylbl.Name = "Citylbl";
            Citylbl.Size = new Size(31, 15);
            Citylbl.TabIndex = 17;
            Citylbl.Text = "City:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(177, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(6, 350);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(52, 15);
            lblWebsite.TabIndex = 19;
            lblWebsite.Text = "Website:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(96, 405);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(117, 342);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(221, 23);
            txtWebsite.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 405);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(117, 301);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(221, 23);
            txtCity.TabIndex = 18;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(117, 257);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(221, 23);
            txtCompanyName.TabIndex = 16;
            // 
            // tabApplicationsPage
            // 
            tabApplicationsPage.Controls.Add(label5);
            tabApplicationsPage.Controls.Add(label4);
            tabApplicationsPage.Controls.Add(label3);
            tabApplicationsPage.Controls.Add(label2);
            tabApplicationsPage.Controls.Add(btnUpdateApplication);
            tabApplicationsPage.Controls.Add(btnDeleteApplication);
            tabApplicationsPage.Controls.Add(dgvApplications);
            tabApplicationsPage.Controls.Add(btnAddApplication);
            tabApplicationsPage.Controls.Add(dtpDate);
            tabApplicationsPage.Controls.Add(cmbStatus);
            tabApplicationsPage.Controls.Add(txtPosition);
            tabApplicationsPage.Controls.Add(cmbCompany);
            tabApplicationsPage.Location = new Point(4, 24);
            tabApplicationsPage.Name = "tabApplicationsPage";
            tabApplicationsPage.Padding = new Padding(3);
            tabApplicationsPage.Size = new Size(952, 475);
            tabApplicationsPage.TabIndex = 1;
            tabApplicationsPage.Text = "Jelentkezések";
            tabApplicationsPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 224);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 11;
            label5.Text = "Dátum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 158);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Státusz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 94);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Pozíció:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 30);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Cég:";
            // 
            // btnUpdateApplication
            // 
            btnUpdateApplication.Location = new Point(564, 291);
            btnUpdateApplication.Name = "btnUpdateApplication";
            btnUpdateApplication.Size = new Size(75, 23);
            btnUpdateApplication.TabIndex = 7;
            btnUpdateApplication.Text = "Módosítás";
            btnUpdateApplication.UseVisualStyleBackColor = true;
            btnUpdateApplication.Click += btnUpdateApplication_Click;
            // 
            // btnDeleteApplication
            // 
            btnDeleteApplication.Location = new Point(661, 291);
            btnDeleteApplication.Name = "btnDeleteApplication";
            btnDeleteApplication.Size = new Size(75, 23);
            btnDeleteApplication.TabIndex = 6;
            btnDeleteApplication.Text = "Törlés";
            btnDeleteApplication.UseVisualStyleBackColor = true;
            // 
            // dgvApplications
            // 
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Location = new Point(19, 22);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.Size = new Size(296, 292);
            dgvApplications.TabIndex = 5;
            dgvApplications.CellClick += dgvApplications_CellClick;
            // 
            // btnAddApplication
            // 
            btnAddApplication.Location = new Point(471, 291);
            btnAddApplication.Name = "btnAddApplication";
            btnAddApplication.Size = new Size(75, 23);
            btnAddApplication.TabIndex = 4;
            btnAddApplication.Text = "Hozzáadás";
            btnAddApplication.UseVisualStyleBackColor = true;
            btnAddApplication.Click += btnAddApplication_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(471, 216);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(265, 23);
            dtpDate.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(471, 150);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(265, 23);
            cmbStatus.TabIndex = 2;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(471, 86);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(265, 23);
            txtPosition.TabIndex = 1;
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(471, 22);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(265, 23);
            cmbCompany.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 587);
            Controls.Add(tabCompanies);
            Name = "MainForm";
            Text = "Form1";
            tabCompanies.ResumeLayout(false);
            tabCompanierPage.ResumeLayout(false);
            tabCompanierPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).EndInit();
            tabApplicationsPage.ResumeLayout(false);
            tabApplicationsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabCompanies;
        private TabPage tabCompanierPage;
        private DataGridView dgvCompanies;
        private TextBox txtSearch;
        private Label CompanyName;
        private Button btnDelete;
        private Label Citylbl;
        private Button btnClear;
        private Label lblWebsite;
        private Button btnUpdate;
        private TextBox txtWebsite;
        private Button btnAdd;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TabPage tabApplicationsPage;
        private DataGridView dgvApplications;
        private Button btnAddApplication;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;
        private TextBox txtPosition;
        private ComboBox cmbCompany;
        private Button btnDeleteApplication;
        private Button btnUpdateApplication;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
