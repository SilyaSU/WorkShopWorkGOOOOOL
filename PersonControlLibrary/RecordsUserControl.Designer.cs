namespace WorkShopControlLib
{
    partial class RecordsUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idText = new TextBox();
            IDLabel = new Label();
            DateLabel = new Label();
            Datetextbox = new TextBox();
            DeviceLabel = new Label();
            DeviceTextBox = new TextBox();
            DescriptionLabel = new Label();
            DescTextBox = new TextBox();
            ErrorLabel = new Label();
            ErrorTextBox = new TextBox();
            buttonEdit = new Button();
            buttonDel = new Button();
            ClientLabel = new Label();
            ClientTextBox = new TextBox();
            EMPlabel = new Label();
            EMPtextbox = new TextBox();
            Statuslabel = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // idText
            // 
            idText.BackColor = Color.White;
            idText.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(28, 40);
            idText.Margin = new Padding(3, 2, 3, 2);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(47, 30);
            idText.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(28, 10);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(31, 23);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(88, 10);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(46, 23);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Дата";
            // 
            // Datetextbox
            // 
            Datetextbox.BackColor = Color.White;
            Datetextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Datetextbox.Location = new Point(88, 40);
            Datetextbox.Margin = new Padding(3, 2, 3, 2);
            Datetextbox.Name = "Datetextbox";
            Datetextbox.ReadOnly = true;
            Datetextbox.Size = new Size(146, 30);
            Datetextbox.TabIndex = 2;
            // 
            // DeviceLabel
            // 
            DeviceLabel.AutoSize = true;
            DeviceLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceLabel.Location = new Point(240, 10);
            DeviceLabel.Name = "DeviceLabel";
            DeviceLabel.Size = new Size(97, 23);
            DeviceLabel.TabIndex = 5;
            DeviceLabel.Text = "Устройство";
            // 
            // DeviceTextBox
            // 
            DeviceTextBox.BackColor = Color.White;
            DeviceTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceTextBox.Location = new Point(240, 40);
            DeviceTextBox.Margin = new Padding(3, 2, 3, 2);
            DeviceTextBox.Name = "DeviceTextBox";
            DeviceTextBox.ReadOnly = true;
            DeviceTextBox.Size = new Size(132, 30);
            DeviceTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(385, 10);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(86, 23);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Описание";
            // 
            // DescTextBox
            // 
            DescTextBox.BackColor = Color.White;
            DescTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTextBox.Location = new Point(385, 40);
            DescTextBox.Margin = new Padding(3, 2, 3, 2);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.ReadOnly = true;
            DescTextBox.Size = new Size(132, 30);
            DescTextBox.TabIndex = 6;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(529, 10);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(81, 23);
            ErrorLabel.TabIndex = 9;
            ErrorLabel.Text = "Поломка";
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.BackColor = Color.White;
            ErrorTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorTextBox.Location = new Point(529, 40);
            ErrorTextBox.Margin = new Padding(3, 2, 3, 2);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.ReadOnly = true;
            ErrorTextBox.Size = new Size(112, 30);
            ErrorTextBox.TabIndex = 8;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(1027, 19);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(104, 28);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(1027, 51);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(104, 28);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientLabel.Location = new Point(647, 10);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(65, 23);
            ClientLabel.TabIndex = 13;
            ClientLabel.Text = "Клиент";
            // 
            // ClientTextBox
            // 
            ClientTextBox.BackColor = Color.White;
            ClientTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientTextBox.Location = new Point(647, 40);
            ClientTextBox.Margin = new Padding(3, 2, 3, 2);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.ReadOnly = true;
            ClientTextBox.Size = new Size(114, 30);
            ClientTextBox.TabIndex = 12;
            // 
            // EMPlabel
            // 
            EMPlabel.AutoSize = true;
            EMPlabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPlabel.Location = new Point(767, 10);
            EMPlabel.Name = "EMPlabel";
            EMPlabel.Size = new Size(91, 23);
            EMPlabel.TabIndex = 15;
            EMPlabel.Text = "Сотрудник";
            // 
            // EMPtextbox
            // 
            EMPtextbox.BackColor = Color.White;
            EMPtextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPtextbox.Location = new Point(767, 40);
            EMPtextbox.Margin = new Padding(3, 2, 3, 2);
            EMPtextbox.Name = "EMPtextbox";
            EMPtextbox.ReadOnly = true;
            EMPtextbox.Size = new Size(114, 30);
            EMPtextbox.TabIndex = 14;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Statuslabel.Location = new Point(887, 10);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(61, 23);
            Statuslabel.TabIndex = 22;
            Statuslabel.Text = "Статус";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(887, 40);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(134, 31);
            cmbStatus.TabIndex = 21;
            // 
            // RecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(Statuslabel);
            Controls.Add(cmbStatus);
            Controls.Add(EMPlabel);
            Controls.Add(EMPtextbox);
            Controls.Add(ClientLabel);
            Controls.Add(ClientTextBox);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(ErrorLabel);
            Controls.Add(ErrorTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescTextBox);
            Controls.Add(DeviceLabel);
            Controls.Add(DeviceTextBox);
            Controls.Add(DateLabel);
            Controls.Add(Datetextbox);
            Controls.Add(IDLabel);
            Controls.Add(idText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecordsUserControl";
            Size = new Size(1147, 99);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private Label IDLabel;
        private Label DateLabel;
        private TextBox Datetextbox;
        private Label DeviceLabel;
        private TextBox DeviceTextBox;
        private Label DescriptionLabel;
        private TextBox DescTextBox;
        private Label ErrorLabel;
        private TextBox ErrorTextBox;
        private Button buttonEdit;
        private Button buttonDel;
        private Label ClientLabel;
        private TextBox ClientTextBox;
        private Label EMPlabel;
        private TextBox EMPtextbox;
        private Label Statuslabel;
        public ComboBox cmbStatus;
    }
}