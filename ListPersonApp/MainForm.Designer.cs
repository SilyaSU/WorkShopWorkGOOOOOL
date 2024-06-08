namespace WorkShop
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
            AddButton = new Button();
            RecordListLabel = new Label();
            Amounttextbox = new TextBox();
            PanelUsers = new FlowLayoutPanel();
            TimeAVG = new TextBox();
            SumAgeLabel = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(32, 18);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(125, 41);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += Add_button;
            // 
            // RecordListLabel
            // 
            RecordListLabel.AutoSize = true;
            RecordListLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RecordListLabel.Location = new Point(196, 34);
            RecordListLabel.Margin = new Padding(2, 0, 2, 0);
            RecordListLabel.Name = "RecordListLabel";
            RecordListLabel.Size = new Size(201, 17);
            RecordListLabel.TabIndex = 1;
            RecordListLabel.Text = "Количество выполненных заявок";
            // 
            // Amounttextbox
            // 
            Amounttextbox.BackColor = Color.White;
            Amounttextbox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Amounttextbox.Location = new Point(401, 31);
            Amounttextbox.Margin = new Padding(2);
            Amounttextbox.Name = "Amounttextbox";
            Amounttextbox.ReadOnly = true;
            Amounttextbox.Size = new Size(110, 24);
            Amounttextbox.TabIndex = 2;
            // 
            // PanelUsers
            // 
            PanelUsers.AutoScroll = true;
            PanelUsers.BackColor = Color.White;
            PanelUsers.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PanelUsers.Location = new Point(22, 95);
            PanelUsers.Margin = new Padding(2);
            PanelUsers.MaximumSize = new Size(1157, 555);
            PanelUsers.Name = "PanelUsers";
            PanelUsers.Size = new Size(1157, 555);
            PanelUsers.TabIndex = 3;
            // 
            // TimeAVG
            // 
            TimeAVG.BackColor = Color.White;
            TimeAVG.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TimeAVG.Location = new Point(683, 31);
            TimeAVG.Margin = new Padding(2);
            TimeAVG.Name = "TimeAVG";
            TimeAVG.ReadOnly = true;
            TimeAVG.Size = new Size(110, 24);
            TimeAVG.TabIndex = 5;
            // 
            // SumAgeLabel
            // 
            SumAgeLabel.AutoSize = true;
            SumAgeLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SumAgeLabel.Location = new Point(517, 34);
            SumAgeLabel.Margin = new Padding(2, 0, 2, 0);
            SumAgeLabel.Name = "SumAgeLabel";
            SumAgeLabel.Size = new Size(166, 17);
            SumAgeLabel.TabIndex = 4;
            SumAgeLabel.Text = "Среднее время выполнения";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1198, 661);
            Controls.Add(TimeAVG);
            Controls.Add(SumAgeLabel);
            Controls.Add(PanelUsers);
            Controls.Add(Amounttextbox);
            Controls.Add(RecordListLabel);
            Controls.Add(AddButton);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Список пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label RecordListLabel;
        private TextBox Amounttextbox;
        private FlowLayoutPanel PanelUsers;
        private TextBox TimeAVG;
        private Label SumAgeLabel;
    }
}