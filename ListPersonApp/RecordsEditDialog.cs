using WorkShopControlLib;

namespace WorkShop
{
    public partial class RecordsEditDialog : Form
    {
        public RecordsEditDialog(RecordsUserControl user)
        {
            InitializeComponent();
            SaveButton.BackColor = Color.FromArgb(73, 140, 81);
        }

        public string IDDialog
        {
            get => idTextdialog.Text;
            set => idTextdialog.Text = value;
        }

        public string DeviceDialog
        {
            get => DeviceTextBoxdialog.Text;
            set => DeviceTextBoxdialog.Text = value;
        }
        public string DescriptionDialog
        {
            get => DescTextBoxdialog.Text;
            set => DescTextBoxdialog.Text = value;
        }
        public string ErrorDialog
        {
            get => ErrorTextBoxdialog.Text;
            set => ErrorTextBoxdialog.Text = value;
        }

        public string ClientDialog
        {
            get => ClientTextBoxdialog.Text;
            set => ClientTextBoxdialog.Text = value;
        }

        public string EmploymentDialog
        {
            get => EMPtextboxdialog.Text;
            set => EMPtextboxdialog.Text = value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ErrorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
