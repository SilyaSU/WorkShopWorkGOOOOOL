namespace WorkShopControlLib
{
    public partial class RecordsUserControl : UserControl
    {

        public string ID
        {
            get => idText.Text;
            set => idText.Text = value;
        }

        public string Date
        {
            get => Datetextbox.Text;
            set
            {
                Datetextbox.Text = value;
                completionTime = DateTime.Parse(value);
            }
        }

        public string Device
        {
            get => DeviceTextBox.Text;
            set => DeviceTextBox.Text = value;
        }
        public string Description
        {
            get => DescTextBox.Text;
            set => DescTextBox.Text = value;
        }
        public string ErrorControl
        {
            get => ErrorTextBox.Text;
            set => ErrorTextBox.Text = value;
        }

        public string Client
        {
            get => ClientTextBox.Text;
            set => ClientTextBox.Text = value;
        }

        public string Employment
        {
            get => EMPtextbox.Text;
            set => EMPtextbox.Text = value;
        }

        public string Status
        {
            get { return cmbStatus.SelectedItem?.ToString(); }
            set
            {
                cmbStatus.SelectedItem = value;
            }
        }

        private DateTime completionTime;

        public DateTime CompletionTime
        {
            get { return completionTime; }
            set { completionTime = value; }
        }

        public RecordsUserControl()
        {
            InitializeComponent();
            buttonDel.BackColor = Color.FromArgb(73, 140, 81);
            buttonEdit.BackColor = Color.FromArgb(73, 140, 81);
            InitializeStatusComboBox();
            Status = "В ожидании";
            OnStatusChanged(EventArgs.Empty);
        }

        private void InitializeStatusComboBox()
        {
            cmbStatus.Items.AddRange(new object[] { "В работе", "Выполнено", "Отменено", "В ожидании" });
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status == "Выполнено")
            {
                CompletionTime = DateTime.Now;
            }
            OnStatusChanged(EventArgs.Empty);
        }

        public event EventHandler StatusChanged;

        protected virtual void OnStatusChanged(EventArgs e)
        {
            StatusChanged?.Invoke(this, e);
        }

        public event EventHandler? Click
        {
            add
            {
                buttonEdit.Click += value;
                buttonDel.Click += value;
            }
            remove
            {
                buttonEdit.Click -= value;
                buttonDel.Click -= value;
            }
        }



    }
}