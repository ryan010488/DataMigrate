using DataMigrate.Domain.Entities.ViewModels;

namespace DataMigrate.UI.Main.Forms
{
    public partial class frmUpdateTreatment : Form
    {
        public TreatmentVM Treatment { get; set; }

        public frmUpdateTreatment()
        {
            InitializeComponent();
        }

        private void frmUpdateTreatment_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Parse(Treatment.CompleteDate);
            txtDescription.Text = Treatment.Description;
            txtItemCode.Text = Treatment.ItemCode;
            txtTooth.Text = Treatment.Tooth;
            txtSurface.Text = Treatment.Surface;
            numPrice.Value = Convert.ToDecimal(Treatment.Price);
            numFee.Value = Convert.ToDecimal(Treatment.Fee);

            txtDescription.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show($"The 'Description' field is required to have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show($"The 'Item Code' field is required to have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Treatment.CompleteDate = dtpDate.Value.ToString("yyyy-MM-dd");
            Treatment.Description = txtDescription.Text;
            Treatment.ItemCode = txtItemCode.Text;
            Treatment.Tooth = txtTooth.Text;
            Treatment.Surface = txtSurface.Text;
            Treatment.Price = numPrice.Value.ToString();
            Treatment.Fee = numFee.Value.ToString();

            Treatment.ErrorMessage.Clear();
            Treatment.HasError = false;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
