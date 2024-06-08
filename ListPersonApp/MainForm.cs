using WorkShopControlLib;
using WorkShopLogicLib;

namespace WorkShop
{
    public partial class MainForm : Form
    {
        private readonly WorkShopCalculator _calculator;

        public MainForm()
        {
            InitializeComponent();
            AddButton.BackColor = Color.FromArgb(73, 140, 81);
            PanelUsers.BackColor = Color.FromArgb(118, 227, 131);
            _calculator = new WorkShopCalculator();
        }

        private void Add_button(object sender, EventArgs e)
        {
            RecordsUserControl userControl = new RecordsUserControl
            {
                BackColor = Color.FromArgb(118, 227, 131),
                Date = DateTime.Now.ToString()
            };
            userControl.Click += UserControl_Click;
            userControl.StatusChanged += UserControl_StatusChanged;
            PanelUsers.Controls.Add(userControl);
            UpdateCompletedCount();
        }

        private void UserControl_Click(object? sender, EventArgs e)
        {
            var userControl = (RecordsUserControl)((Control)sender).Parent;
            if (((Button)sender).Name == "buttonEdit")
            {
                RecordsEditDialog editDialog = new RecordsEditDialog(userControl)
                {
                    IDDialog = userControl.ID,
                    DeviceDialog = userControl.Device,
                    DescriptionDialog = userControl.Description,
                    ErrorDialog = userControl.ErrorControl,
                    ClientDialog = userControl.Client,
                    EmploymentDialog = userControl.Employment
                };

                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    userControl.ID = editDialog.IDDialog;
                    userControl.Device = editDialog.DeviceDialog;
                    userControl.Description = editDialog.DescriptionDialog;
                    userControl.ErrorControl = editDialog.ErrorDialog;
                    userControl.Client = editDialog.ClientDialog;
                    userControl.Employment = editDialog.EmploymentDialog;
                }
                else
                {
                    PanelUsers.Controls.Remove(userControl);
                }
            }
            else if (((Button)sender).Name == "buttonDel")
            {
                PanelUsers.Controls.Remove(userControl);
                UpdateCompletedCount();
                UpdateAverageCompletionTime();
            }
        }

        private void UpdateCompletedCount()
        {
            int completedCount = _calculator.CalculateCompletedRequests(GetRecordsUserControls());
            Amounttextbox.Text = completedCount.ToString();
        }

        private void UserControl_StatusChanged(object sender, EventArgs e)
        {
            UpdateCompletedCount();
            UpdateAverageCompletionTime();
        }

        private void UpdateAverageCompletionTime()
        {
            TimeSpan averageCompletionTime = _calculator.CalculateAverageCompletionTime(GetRecordsUserControls());
            TimeAVG.Text = averageCompletionTime.ToString();
        }

        private IEnumerable<RecordsUserControl> GetRecordsUserControls()
        {
            foreach (Control control in PanelUsers.Controls)
            {
                if (control is RecordsUserControl userControl)
                {
                    yield return userControl;
                }
            }
        }
    }
}
