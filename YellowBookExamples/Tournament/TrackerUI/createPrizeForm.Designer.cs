namespace TrackerUI
{
    partial class CreatePrizeForm : Form
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
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            prizeAmountLabel = new Label();
            prizeAmountValue = new TextBox();
            prizePercentageLabel = new Label();
            prizePercentageValue = new TextBox();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.Location = new Point(22, 101);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(177, 37);
            placeNumberLabel.TabIndex = 22;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberValue.Location = new Point(232, 95);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(291, 43);
            placeNumberValue.TabIndex = 23;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.Location = new Point(22, 153);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(152, 37);
            placeNameLabel.TabIndex = 24;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameValue.Location = new Point(232, 147);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(291, 43);
            placeNameValue.TabIndex = 25;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.Location = new Point(22, 205);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(171, 37);
            prizeAmountLabel.TabIndex = 26;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountValue.Location = new Point(232, 199);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(291, 43);
            prizeAmountValue.TabIndex = 27;
            prizeAmountValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.Location = new Point(22, 339);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(206, 37);
            prizePercentageLabel.TabIndex = 28;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageValue.Location = new Point(232, 333);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(291, 43);
            prizePercentageValue.TabIndex = 29;
            prizePercentageValue.Text = "0";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.Location = new Point(222, 274);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(77, 37);
            orLabel.TabIndex = 30;
            orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(104, 426);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(345, 56);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 528);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label prizeAmountLabel;
        private TextBox prizeAmountValue;
        private Label prizePercentageLabel;
        private TextBox prizePercentageValue;
        private Label orLabel;
        private Button createPrizeButton;
    }
}