namespace WorkShop
{
    partial class RecordsEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            EMPlabel = new Label();
            EMPtextboxdialog = new TextBox();
            ClientLabel = new Label();
            ClientTextBoxdialog = new TextBox();
            ErrorLabel = new Label();
            ErrorTextBoxdialog = new TextBox();
            DescriptionLabel = new Label();
            DescTextBoxdialog = new TextBox();
            DeviceLabel = new Label();
            DeviceTextBoxdialog = new TextBox();
            IDLabel = new Label();
            idTextdialog = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 253);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(155, 34);
            SaveButton.TabIndex = 39;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += okButton_Click;
            // 
            // EMPlabel
            // 
            EMPlabel.AutoSize = true;
            EMPlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPlabel.Location = new Point(183, 167);
            EMPlabel.Name = "EMPlabel";
            EMPlabel.Size = new Size(88, 21);
            EMPlabel.TabIndex = 53;
            EMPlabel.Text = "Сотрудник";
            // 
            // EMPtextboxdialog
            // 
            EMPtextboxdialog.BackColor = Color.White;
            EMPtextboxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPtextboxdialog.Location = new Point(183, 197);
            EMPtextboxdialog.Margin = new Padding(3, 2, 3, 2);
            EMPtextboxdialog.Name = "EMPtextboxdialog";
            EMPtextboxdialog.Size = new Size(114, 29);
            EMPtextboxdialog.TabIndex = 52;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientLabel.Location = new Point(183, 90);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(60, 21);
            ClientLabel.TabIndex = 51;
            ClientLabel.Text = "Клиент";
            // 
            // ClientTextBoxdialog
            // 
            ClientTextBoxdialog.BackColor = Color.White;
            ClientTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientTextBoxdialog.Location = new Point(183, 120);
            ClientTextBoxdialog.Margin = new Padding(3, 2, 3, 2);
            ClientTextBoxdialog.Name = "ClientTextBoxdialog";
            ClientTextBoxdialog.Size = new Size(114, 29);
            ClientTextBoxdialog.TabIndex = 50;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(185, 18);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(74, 21);
            ErrorLabel.TabIndex = 49;
            ErrorLabel.Text = "Поломка";
            // 
            // ErrorTextBoxdialog
            // 
            ErrorTextBoxdialog.BackColor = Color.White;
            ErrorTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorTextBoxdialog.Location = new Point(185, 48);
            ErrorTextBoxdialog.Margin = new Padding(3, 2, 3, 2);
            ErrorTextBoxdialog.Name = "ErrorTextBoxdialog";
            ErrorTextBoxdialog.Size = new Size(112, 29);
            ErrorTextBoxdialog.TabIndex = 48;
            ErrorTextBoxdialog.TextChanged += ErrorTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(12, 164);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(81, 21);
            DescriptionLabel.TabIndex = 47;
            DescriptionLabel.Text = "Описание";
            // 
            // DescTextBoxdialog
            // 
            DescTextBoxdialog.BackColor = Color.White;
            DescTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTextBoxdialog.Location = new Point(12, 194);
            DescTextBoxdialog.Margin = new Padding(3, 2, 3, 2);
            DescTextBoxdialog.Name = "DescTextBoxdialog";
            DescTextBoxdialog.Size = new Size(132, 29);
            DescTextBoxdialog.TabIndex = 46;
            // 
            // DeviceLabel
            // 
            DeviceLabel.AutoSize = true;
            DeviceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceLabel.Location = new Point(12, 90);
            DeviceLabel.Name = "DeviceLabel";
            DeviceLabel.Size = new Size(91, 21);
            DeviceLabel.TabIndex = 45;
            DeviceLabel.Text = "Устройство";
            // 
            // DeviceTextBoxdialog
            // 
            DeviceTextBoxdialog.BackColor = Color.White;
            DeviceTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceTextBoxdialog.Location = new Point(12, 120);
            DeviceTextBoxdialog.Margin = new Padding(3, 2, 3, 2);
            DeviceTextBoxdialog.Name = "DeviceTextBoxdialog";
            DeviceTextBoxdialog.Size = new Size(132, 29);
            DeviceTextBoxdialog.TabIndex = 44;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(12, 18);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 41;
            IDLabel.Text = "ID";
            // 
            // idTextdialog
            // 
            idTextdialog.BackColor = Color.White;
            idTextdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTextdialog.Location = new Point(12, 48);
            idTextdialog.Margin = new Padding(3, 2, 3, 2);
            idTextdialog.Name = "idTextdialog";
            idTextdialog.Size = new Size(47, 29);
            idTextdialog.TabIndex = 40;
            // 
            // RecordsEditDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 316);
            Controls.Add(EMPlabel);
            Controls.Add(EMPtextboxdialog);
            Controls.Add(ClientLabel);
            Controls.Add(ClientTextBoxdialog);
            Controls.Add(ErrorLabel);
            Controls.Add(ErrorTextBoxdialog);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescTextBoxdialog);
            Controls.Add(DeviceLabel);
            Controls.Add(DeviceTextBoxdialog);
            Controls.Add(IDLabel);
            Controls.Add(idTextdialog);
            Controls.Add(SaveButton);
            Name = "RecordsEditDialog";
            Text = "PresonEditDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label EMPlabel;
        private TextBox EMPtextboxdialog;
        private Label ClientLabel;
        private TextBox ClientTextBoxdialog;
        private Label ErrorLabel;
        private TextBox ErrorTextBoxdialog;
        private Label DescriptionLabel;
        private TextBox DescTextBoxdialog;
        private Label DeviceLabel;
        private TextBox DeviceTextBoxdialog;
        private Label IDLabel;
        private TextBox idTextdialog;
    }
}