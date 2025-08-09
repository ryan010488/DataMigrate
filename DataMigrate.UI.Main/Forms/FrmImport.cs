using DataMigrate.Domain.Entities.ViewModels;
using DataMigrate.Domain.Interfaces.Services;
using DataMigrate.UI.Main.Forms;

namespace DataMigrate
{
    public partial class frmImport : Form
    {
        private readonly IPatientService _patientService;
        private readonly ITreatmentService _treatmentService;

        private List<PatientVM> PatientsList;
        private List<TreatmentVM> TreatmentList;

        #region Events
        public frmImport(IPatientService helloWorldService,
            ITreatmentService treatmentService)
        {
            InitializeComponent();

            _patientService = helloWorldService;
            _treatmentService = treatmentService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>
            {
                new ComboBoxItem("Show All", 0),
                new ComboBoxItem("Show Valid", 1),
                new ComboBoxItem("Show Invalid", 2),
            };

            cmbFilterPatient.DataSource = items;
            cmbFilterPatient.DisplayMember = "DisplayText";
            cmbFilterPatient.ValueMember = "Value";

            cmbFilterTreatment.DataSource = items;
            cmbFilterTreatment.DisplayMember = "DisplayText";
            cmbFilterTreatment.ValueMember = "Value";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void dgvRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row was double-clicked (not the header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvRecord.Rows[e.RowIndex];

                using (var updateForm = new frmUpdatePatient())
                {
                    updateForm.Patient = (PatientVM)selectedRow.DataBoundItem;

                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        int selectedIndex = cmbFilterPatient.SelectedIndex;

                        selectedRow.DefaultCellStyle.BackColor = Color.White;

                        lblPatientInvalid.Text = PatientsList.Count(m => m.HasError).ToString();

                        if (selectedIndex == 0)
                        {
                            dgvRecord.DataSource = PatientsList;
                        }
                        else if (selectedIndex == 1)
                        {
                            dgvRecord.DataSource = PatientsList.Where(m => !m.HasError).ToList();
                        }
                        else if (selectedIndex == 2)
                        {
                            dgvRecord.DataSource = PatientsList.Where(m => m.HasError).ToList();
                        }
                    }
                }
            }
        }

        private void dgvTreatment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row was double-clicked (not the header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTreatment.Rows[e.RowIndex];

                using (var updateForm = new frmUpdateTreatment())
                {
                    updateForm.Treatment = (TreatmentVM)selectedRow.DataBoundItem;

                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        int selectedIndex = cmbFilterTreatment.SelectedIndex;

                        selectedRow.DefaultCellStyle.BackColor = Color.White;

                        lblTreatmentInvalid.Text = TreatmentList.Count(m => m.HasError).ToString();

                        if (selectedIndex == 0)
                        {
                            dgvTreatment.DataSource = TreatmentList;
                        }
                        else if (selectedIndex == 1)
                        {
                            dgvTreatment.DataSource = TreatmentList.Where(m => !m.HasError).ToList();
                        }
                        else if (selectedIndex == 2)
                        {
                            dgvTreatment.DataSource = TreatmentList.Where(m => m.HasError).ToList();
                        }
                    }
                }
            }
        }

        private void dgvRecord_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvRecord.Columns.Contains("Id"))
            {
                dgvRecord.Columns["Id"].Visible = false;
            }
            if (dgvRecord.Columns.Contains("Identifier"))
            {
                dgvRecord.Columns["Identifier"].Visible = false;
            }
            if (dgvRecord.Columns.Contains("HasError"))
            {
                dgvRecord.Columns["HasError"].Visible = false;
            }
        }

        private void dgvTreatment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvTreatment.Columns.Contains("PatientId"))
            {
                dgvTreatment.Columns["PatientId"].Visible = false;
            }
            if (dgvTreatment.Columns.Contains("HasError"))
            {
                dgvTreatment.Columns["HasError"].Visible = false;
            }
        }

        private void dgvRecord_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRecord.Rows.Count)
            {
                var row = dgvRecord.Rows[e.RowIndex];

                if (Convert.ToBoolean(row.Cells["HasError"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void dgvTreatment_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTreatment.Rows.Count)
            {
                var row = dgvTreatment.Rows[e.RowIndex];

                if (Convert.ToBoolean(row.Cells["HasError"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion

        #region Functions
        private void Import()
        {
            var ofdCSV = new OpenFileDialog();

            ofdCSV.Filter = "Comma-Separated Files|*.csv|All Files (*.*)|*.*";
            ofdCSV.InitialDirectory = "C:\\";
            ofdCSV.Title = "Select a File(s)";
            ofdCSV.Multiselect = true;

            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                if (ofdCSV.Multiselect)
                {
                    foreach (string filePath in ofdCSV.FileNames)
                    {
                        if (filePath.ToLower().Contains("patients.csv"))
                        {
                            PatientsList = _patientService.ReadCsvFile(filePath);
                            dgvRecord.DataSource = PatientsList;
                            cmbFilterPatient.Visible = true;

                            lblPatientTotal.Text = PatientsList.Count.ToString();
                            lblPatientInvalid.Text = PatientsList.Count(m => m.HasError).ToString();
                        }
                        else if (filePath.ToLower().Contains("treatments.csv"))
                        {
                            TreatmentList = _treatmentService.ReadCsvFile(filePath);
                            dgvTreatment.DataSource = TreatmentList;
                            cmbFilterTreatment.Visible = true;

                            lblTreatmentTotal.Text = TreatmentList.Count.ToString();
                            lblTreatmentInvalid.Text = TreatmentList.Count(m => m.HasError).ToString();
                        }
                    }
                }
            }
        }

        private async void Save()
        {
            List<PatientVM> patients;
            List<TreatmentVM> treatments;

            int totalPatients = 0;
            int skippedPatients = 0;
            int totalTreatments = 0;
            int skippedTreatments = 0;

            if (dgvRecord.DataSource == null)
            {
                patients = await _patientService.GetAll();
            }
            else
            {
                patients = await _patientService.Post(PatientsList);
                totalPatients = patients.Count;
                skippedPatients = patients.Count(m => m.ErrorMessage.Count > 0);
            }

            if (dgvTreatment.DataSource != null)
            {
                treatments = await _treatmentService.Post(TreatmentList, patients);
                totalTreatments = treatments.Count;
                skippedTreatments = treatments.Count(m => m.ErrorMessage.Count > 0);
            }

            dgvRecord.DataSource = null;
            dgvTreatment.DataSource = null;

            cmbFilterPatient.Visible = false;
            cmbFilterTreatment.Visible = false;

            lblPatientTotal.Text = "0";
            lblPatientInvalid.Text = "0";
            lblTreatmentInvalid.Text = "0";
            lblTreatmentTotal.Text = "0";

            var msgPatient = "";
            var msgTreatment = "";

            if (totalPatients > 0 || skippedPatients > 0)
            {
                msgPatient = "Patients:" + Environment.NewLine +
                    "Total: " + totalPatients + Environment.NewLine +
                    "Skipped: " + skippedPatients;
            }

            if (totalTreatments > 0 || skippedTreatments > 0)
            {
                msgTreatment = (string.IsNullOrEmpty(msgPatient) ? "" : Environment.NewLine + Environment.NewLine) +
                    "Treatments:" + Environment.NewLine +
                    "Total: " + totalTreatments + Environment.NewLine +
                    "Skipped: " + skippedTreatments;
            }

            MessageBox.Show("Imported successfully!" + Environment.NewLine + Environment.NewLine +
                msgPatient + msgTreatment, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void cmbFilterPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatientsList == null) return;

            int selectedIndex = cmbFilterPatient.SelectedIndex;

            if (selectedIndex == 0)
            {
                dgvRecord.DataSource = PatientsList;
            }
            else if (selectedIndex == 1)
            {
                dgvRecord.DataSource = PatientsList.Where(m => !m.HasError).ToList();
            }
            else if (selectedIndex == 2)
            {
                dgvRecord.DataSource = PatientsList.Where(m => m.HasError).ToList();
            }
        }

        private void cmbFilterTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TreatmentList == null) return;

            int selectedIndex = cmbFilterTreatment.SelectedIndex;

            if (selectedIndex == 0)
            {
                dgvTreatment.DataSource = TreatmentList;
            }
            else if (selectedIndex == 1)
            {
                dgvTreatment.DataSource = TreatmentList.Where(m => !m.HasError).ToList();
            }
            else if (selectedIndex == 2)
            {
                dgvTreatment.DataSource = TreatmentList.Where(m => m.HasError).ToList();
            }
        }
        
    }
}
