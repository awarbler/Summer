namespace TrackerUI
{
    partial class CreateTournamentForm
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
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            seletTeamValue = new ComboBox();
            selectTeamLabel = new Label();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayerlistBox = new ListBox();
            prizeListBox = new ListBox();
            playerTeamListLabel = new Label();
            prizeListBoxLabel = new Label();
            deletePlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            createTournamentHeader = new Label();
            createNewLinkLabel = new LinkLabel();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(26, 92);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(309, 50);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameValue.Location = new Point(26, 145);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(342, 43);
            tournamentNameValue.TabIndex = 22;
            // 
            // entryFeeValue
            // 
            entryFeeValue.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeValue.Location = new Point(156, 206);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 35);
            entryFeeValue.TabIndex = 24;
            entryFeeValue.Text = "$0.00";
            entryFeeValue.TextAlign = HorizontalAlignment.Right;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.Location = new Point(26, 203);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(124, 37);
            entryFeeLabel.TabIndex = 23;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // seletTeamValue
            // 
            seletTeamValue.FormattingEnabled = true;
            seletTeamValue.Location = new Point(26, 304);
            seletTeamValue.Name = "seletTeamValue";
            seletTeamValue.Size = new Size(342, 38);
            seletTeamValue.TabIndex = 26;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(26, 264);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(157, 37);
            selectTeamLabel.TabIndex = 25;
            selectTeamLabel.Text = "Select Team ";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.Location = new Point(26, 393);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(174, 56);
            addTeamButton.TabIndex = 27;
            addTeamButton.Text = "Add Team ";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(224, 393);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(174, 56);
            createPrizeButton.TabIndex = 28;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerlistBox
            // 
            tournamentPlayerlistBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayerlistBox.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayerlistBox.FormattingEnabled = true;
            tournamentPlayerlistBox.ItemHeight = 30;
            tournamentPlayerlistBox.Location = new Point(415, 145);
            tournamentPlayerlistBox.Name = "tournamentPlayerlistBox";
            tournamentPlayerlistBox.Size = new Size(183, 242);
            tournamentPlayerlistBox.TabIndex = 29;
            // 
            // prizeListBox
            // 
            prizeListBox.BorderStyle = BorderStyle.FixedSingle;
            prizeListBox.ForeColor = Color.FromArgb(51, 153, 255);
            prizeListBox.FormattingEnabled = true;
            prizeListBox.ItemHeight = 30;
            prizeListBox.Location = new Point(626, 145);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(183, 242);
            prizeListBox.TabIndex = 30;
            // 
            // playerTeamListLabel
            // 
            playerTeamListLabel.AutoSize = true;
            playerTeamListLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerTeamListLabel.Location = new Point(415, 102);
            playerTeamListLabel.Name = "playerTeamListLabel";
            playerTeamListLabel.Size = new Size(169, 37);
            playerTeamListLabel.TabIndex = 31;
            playerTeamListLabel.Text = "Player / Team";
            // 
            // prizeListBoxLabel
            // 
            prizeListBoxLabel.AutoSize = true;
            prizeListBoxLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizeListBoxLabel.Location = new Point(626, 102);
            prizeListBoxLabel.Name = "prizeListBoxLabel";
            prizeListBoxLabel.Size = new Size(164, 37);
            prizeListBoxLabel.TabIndex = 32;
            prizeListBoxLabel.Text = "Prize List Box";
            // 
            // deletePlayerButton
            // 
            deletePlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deletePlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deletePlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deletePlayerButton.FlatStyle = FlatStyle.Flat;
            deletePlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletePlayerButton.Location = new Point(420, 393);
            deletePlayerButton.Name = "deletePlayerButton";
            deletePlayerButton.Size = new Size(174, 56);
            deletePlayerButton.TabIndex = 33;
            deletePlayerButton.Text = "Delete Player";
            deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.Location = new Point(632, 393);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(174, 56);
            deleteSelectedPrizeButton.TabIndex = 34;
            deleteSelectedPrizeButton.Text = "Delete Prize";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentHeader
            // 
            createTournamentHeader.AutoSize = true;
            createTournamentHeader.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentHeader.Location = new Point(26, 9);
            createTournamentHeader.Name = "createTournamentHeader";
            createTournamentHeader.Size = new Size(317, 50);
            createTournamentHeader.TabIndex = 35;
            createTournamentHeader.Text = "Create Tournament";
            // 
            // createNewLinkLabel
            // 
            createNewLinkLabel.AutoSize = true;
            createNewLinkLabel.Location = new Point(263, 271);
            createNewLinkLabel.Name = "createNewLinkLabel";
            createNewLinkLabel.Size = new Size(114, 30);
            createNewLinkLabel.TabIndex = 36;
            createNewLinkLabel.TabStop = true;
            createNewLinkLabel.Text = "create new";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(525, 30);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(284, 56);
            createTournamentButton.TabIndex = 37;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 473);
            Controls.Add(createTournamentButton);
            Controls.Add(createNewLinkLabel);
            Controls.Add(createTournamentHeader);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(deletePlayerButton);
            Controls.Add(prizeListBoxLabel);
            Controls.Add(playerTeamListLabel);
            Controls.Add(prizeListBox);
            Controls.Add(tournamentPlayerlistBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(seletTeamValue);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox seletTeamValue;
        private Label selectTeamLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayerlistBox;
        private ListBox prizeListBox;
        private Label playerTeamListLabel;
        private Label prizeListBoxLabel;
        private Button deletePlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label createTournamentHeader;
        private LinkLabel createNewLinkLabel;
        private Button createTournamentButton;
    }
}