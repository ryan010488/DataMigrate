using System.Net.Mail;
using DataMigrate.Domain.Entities.ViewModels;

namespace DataMigrate.UI.Main.Forms
{
    public partial class frmUpdatePatient : Form
    {
        public PatientVM Patient { get; set; }

        public frmUpdatePatient()
        {
            InitializeComponent();
        }

        private void frmUpdatePatient_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = Patient.Firstname;
            txtMiddleName.Text = Patient.Middlename;
            txtLastName.Text = Patient.Lastname;

            if (DateTime.TryParse(Patient.DateOfBirth, out var resultDOB))
            {
                dtpDateOfBirth.Value = DateTime.Parse(Patient.DateOfBirth);
            }

            cmbGender.SelectedItem = Patient.Gender;
            txtEmail.Text = Patient.Email;
            txtMobile.Text = Patient.Mobile;
            txtPhone.Text = Patient.HomePhone;
            txtStreet.Text = Patient.Street;
            txtSuburb.Text = Patient.Suburb;
            txtState.Text = Patient.State;
            txtPostCode.Text = Patient.Postcode;

            txtFirstName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)) {
                MessageBox.Show($"The 'First Name' field is required to have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show($"The 'Last Name' field is required to have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show($"The 'Email' field is not a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient.Firstname = txtFirstName.Text;
            Patient.Middlename = txtMiddleName.Text;
            Patient.Lastname = txtLastName.Text;

            if (dtpDateOfBirth.Checked && DateTime.TryParse(dtpDateOfBirth.Value.ToString(), out var resultDOB))
            {
                Patient.DateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            }
            else if (!dtpDateOfBirth.Checked && !string.IsNullOrEmpty(Patient.DateOfBirth))
            {
                Patient.DateOfBirth = "";
            }

            Patient.Gender = cmbGender.SelectedItem.ToString();
            Patient.Email = txtEmail.Text;
            Patient.Mobile = txtMobile.Text;
            Patient.HomePhone = txtPhone.Text;
            Patient.Suburb = txtSuburb.Text;
            Patient.State = txtState.Text;
            Patient.Postcode = txtPostCode.Text;

            Patient.ErrorMessage.Clear();
            Patient.HasError = false;

            Patient.ErrorMessage.Clear();

            this.DialogResult = DialogResult.OK;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            try
            {
                var addr = new MailAddress(email);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
