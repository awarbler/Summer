namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            headerLabel = new Label();
            loadTournmentTableLabel = new Label();
            loadTournamentTableDropDown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(53, 50);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(385, 50);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadTournmentTableLabel
            // 
            loadTournmentTableLabel.AutoSize = true;
            loadTournmentTableLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournmentTableLabel.Location = new Point(94, 120);
            loadTournmentTableLabel.Name = "loadTournmentTableLabel";
            loadTournmentTableLabel.Size = new Size(303, 37);
            loadTournmentTableLabel.TabIndex = 25;
            loadTournmentTableLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentTableDropDown
            // 
            loadTournamentTableDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentTableDropDown.FormattingEnabled = true;
            loadTournamentTableDropDown.Location = new Point(53, 177);
            loadTournamentTableDropDown.Name = "loadTournamentTableDropDown";
            loadTournamentTableDropDown.Size = new Size(385, 45);
            loadTournamentTableDropDown.TabIndex = 24;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.Location = new Point(118, 242);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(254, 56);
            loadTournamentButton.TabIndex = 33;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(73, 318);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(345, 56);
            createTournamentButton.TabIndex = 34;
            createTournamentButton.Text = "Create Tournament ";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 438);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadTournmentTableLabel);
            Controls.Add(loadTournamentTableDropDown);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label loadTournmentTableLabel;
        private ComboBox loadTournamentTableDropDown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}