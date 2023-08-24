namespace TrackerUI
{
    partial class createTeamForm
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
            teamNameLabel = new Label();
            createTeameHeaderLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            teamNameValue = new TextBox();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            createNewMemberGroupBox = new GroupBox();
            addNewMemberButton = new Button();
            cellPhoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            createNewteamGroupBox = new GroupBox();
            teamMemberListBox = new ListBox();
            deleteSelectedButton = new Button();
            createTeamButton = new Button();
            createNewMemberGroupBox.SuspendLayout();
            createNewteamGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(6, 48);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(158, 37);
            teamNameLabel.TabIndex = 20;
            teamNameLabel.Text = "Team  Name";
            teamNameLabel.Click += tournamentNameLabel_Click;
            // 
            // createTeameHeaderLabel
            // 
            createTeameHeaderLabel.AutoSize = true;
            createTeameHeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeameHeaderLabel.Location = new Point(12, 9);
            createTeameHeaderLabel.Name = "createTeameHeaderLabel";
            createTeameHeaderLabel.Size = new Size(213, 50);
            createTeameHeaderLabel.TabIndex = 19;
            createTeameHeaderLabel.Text = "Create Team";
            createTeameHeaderLabel.Click += headerLabel_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(9, 138);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(455, 45);
            selectTeamMemberDropDown.TabIndex = 22;
            // 
            // teamNameValue
            // 
            teamNameValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameValue.Location = new Point(170, 42);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(291, 43);
            teamNameValue.TabIndex = 21;
            teamNameValue.TextChanged += tournamentNameDropdown_TextChanged;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.Location = new Point(9, 98);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(253, 37);
            selectTeamMemberLabel.TabIndex = 23;
            selectTeamMemberLabel.Text = "Select Team Member";
            selectTeamMemberLabel.Click += label1_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.Location = new Point(117, 189);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(238, 56);
            addMemberButton.TabIndex = 25;
            addMemberButton.Text = "Add Team Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // createNewMemberGroupBox
            // 
            createNewMemberGroupBox.Controls.Add(addNewMemberButton);
            createNewMemberGroupBox.Controls.Add(cellPhoneValue);
            createNewMemberGroupBox.Controls.Add(cellphoneLabel);
            createNewMemberGroupBox.Controls.Add(emailValue);
            createNewMemberGroupBox.Controls.Add(emailLabel);
            createNewMemberGroupBox.Controls.Add(lastNameValue);
            createNewMemberGroupBox.Controls.Add(lastNameLabel);
            createNewMemberGroupBox.Controls.Add(firstNameValue);
            createNewMemberGroupBox.Controls.Add(firstNameLabel);
            createNewMemberGroupBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createNewMemberGroupBox.Location = new Point(18, 362);
            createNewMemberGroupBox.Name = "createNewMemberGroupBox";
            createNewMemberGroupBox.Size = new Size(474, 330);
            createNewMemberGroupBox.TabIndex = 26;
            createNewMemberGroupBox.TabStop = false;
            createNewMemberGroupBox.Text = "Create New Member";
            createNewMemberGroupBox.Enter += createNewMemberGroupBox_Enter;
            // 
            // addNewMemberButton
            // 
            addNewMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addNewMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addNewMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addNewMemberButton.FlatStyle = FlatStyle.Flat;
            addNewMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addNewMemberButton.Location = new Point(117, 268);
            addNewMemberButton.Name = "addNewMemberButton";
            addNewMemberButton.Size = new Size(254, 56);
            addNewMemberButton.TabIndex = 27;
            addNewMemberButton.Text = "Create New Member";
            addNewMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(153, 210);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(311, 43);
            cellPhoneValue.TabIndex = 24;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.Location = new Point(9, 208);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(139, 37);
            cellphoneLabel.TabIndex = 23;
            cellphoneLabel.Text = "Cell Phone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(153, 161);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(311, 43);
            emailValue.TabIndex = 22;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(9, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 37);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(153, 107);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(311, 43);
            lastNameValue.TabIndex = 20;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(6, 105);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(135, 37);
            lastNameLabel.TabIndex = 19;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(153, 48);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(311, 43);
            firstNameValue.TabIndex = 18;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(6, 46);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(138, 37);
            firstNameLabel.TabIndex = 17;
            firstNameLabel.Text = "First Name";
            // 
            // createNewteamGroupBox
            // 
            createNewteamGroupBox.Controls.Add(teamNameLabel);
            createNewteamGroupBox.Controls.Add(teamNameValue);
            createNewteamGroupBox.Controls.Add(addMemberButton);
            createNewteamGroupBox.Controls.Add(selectTeamMemberLabel);
            createNewteamGroupBox.Controls.Add(selectTeamMemberDropDown);
            createNewteamGroupBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createNewteamGroupBox.Location = new Point(18, 80);
            createNewteamGroupBox.Name = "createNewteamGroupBox";
            createNewteamGroupBox.Size = new Size(480, 255);
            createNewteamGroupBox.TabIndex = 28;
            createNewteamGroupBox.TabStop = false;
            createNewteamGroupBox.Text = "Create New Team";
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMemberListBox.ForeColor = Color.FromArgb(51, 153, 255);
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 30;
            teamMemberListBox.Location = new Point(530, 133);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(345, 482);
            teamMemberListBox.TabIndex = 30;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedButton.Location = new Point(530, 630);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(345, 56);
            deleteSelectedButton.TabIndex = 28;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.Location = new Point(530, 26);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(345, 56);
            createTeamButton.TabIndex = 31;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // createTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(913, 714);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedButton);
            Controls.Add(teamMemberListBox);
            Controls.Add(createNewteamGroupBox);
            Controls.Add(createNewMemberGroupBox);
            Controls.Add(createTeameHeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Margin = new Padding(5, 6, 5, 6);
            Name = "createTeamForm";
            Text = "Create Team Form";
            createNewMemberGroupBox.ResumeLayout(false);
            createNewMemberGroupBox.PerformLayout();
            createNewteamGroupBox.ResumeLayout(false);
            createNewteamGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label teamNameLabel;
        private Label createTeameHeaderLabel;
        private ComboBox selectTeamMemberDropDown;
        private TextBox teamNameValue;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox createNewMemberGroupBox;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellPhoneValue;
        private Label cellphoneLabel;
        private Button addNewMemberButton;
        private GroupBox createNewteamGroupBox;
        private ListBox teamMemberListBox;
        private Button deleteSelectedButton;
        private Button createTeamButton;
    }
}