namespace CST_150_Activity14
{
    partial class coffeeBarFrm
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
            this.drinkListBox = new System.Windows.Forms.ListBox();
            this.iceRadioBtn = new System.Windows.Forms.RadioButton();
            this.hotRadioBtn = new System.Windows.Forms.RadioButton();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.sugarCheckBox = new System.Windows.Forms.CheckBox();
            this.vanillaSyrupCheckBox = new System.Windows.Forms.CheckBox();
            this.drinkLbl = new System.Windows.Forms.Label();
            this.iceHotLbl = new System.Windows.Forms.Label();
            this.additivesLbl = new System.Windows.Forms.Label();
            this.orderTxt = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drinkListBox
            // 
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.Items.AddRange(new object[] {
            "Coffee",
            "Tea"});
            this.drinkListBox.Location = new System.Drawing.Point(12, 50);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(120, 30);
            this.drinkListBox.TabIndex = 0;
            // 
            // iceRadioBtn
            // 
            this.iceRadioBtn.AutoSize = true;
            this.iceRadioBtn.Location = new System.Drawing.Point(12, 132);
            this.iceRadioBtn.Name = "iceRadioBtn";
            this.iceRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.iceRadioBtn.TabIndex = 1;
            this.iceRadioBtn.TabStop = true;
            this.iceRadioBtn.Text = "Iced";
            this.iceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hotRadioBtn
            // 
            this.hotRadioBtn.AutoSize = true;
            this.hotRadioBtn.Location = new System.Drawing.Point(12, 155);
            this.hotRadioBtn.Name = "hotRadioBtn";
            this.hotRadioBtn.Size = new System.Drawing.Size(42, 17);
            this.hotRadioBtn.TabIndex = 2;
            this.hotRadioBtn.TabStop = true;
            this.hotRadioBtn.Text = "Hot";
            this.hotRadioBtn.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(12, 225);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(45, 17);
            this.milkCheckBox.TabIndex = 4;
            this.milkCheckBox.Text = "Milk";
            this.milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // sugarCheckBox
            // 
            this.sugarCheckBox.AutoSize = true;
            this.sugarCheckBox.Location = new System.Drawing.Point(12, 248);
            this.sugarCheckBox.Name = "sugarCheckBox";
            this.sugarCheckBox.Size = new System.Drawing.Size(54, 17);
            this.sugarCheckBox.TabIndex = 5;
            this.sugarCheckBox.Text = "Sugar";
            this.sugarCheckBox.UseVisualStyleBackColor = true;
            // 
            // vanillaSyrupCheckBox
            // 
            this.vanillaSyrupCheckBox.AutoSize = true;
            this.vanillaSyrupCheckBox.Location = new System.Drawing.Point(12, 271);
            this.vanillaSyrupCheckBox.Name = "vanillaSyrupCheckBox";
            this.vanillaSyrupCheckBox.Size = new System.Drawing.Size(87, 17);
            this.vanillaSyrupCheckBox.TabIndex = 6;
            this.vanillaSyrupCheckBox.Text = "Vanilla Syrup";
            this.vanillaSyrupCheckBox.UseVisualStyleBackColor = true;
            // 
            // drinkLbl
            // 
            this.drinkLbl.AutoSize = true;
            this.drinkLbl.Location = new System.Drawing.Point(9, 24);
            this.drinkLbl.Name = "drinkLbl";
            this.drinkLbl.Size = new System.Drawing.Size(86, 13);
            this.drinkLbl.TabIndex = 7;
            this.drinkLbl.Text = "Select your drink";
            // 
            // iceHotLbl
            // 
            this.iceHotLbl.AutoSize = true;
            this.iceHotLbl.Location = new System.Drawing.Point(12, 116);
            this.iceHotLbl.Name = "iceHotLbl";
            this.iceHotLbl.Size = new System.Drawing.Size(96, 13);
            this.iceHotLbl.TabIndex = 8;
            this.iceHotLbl.Text = "Select Iced or Hot:";
            // 
            // additivesLbl
            // 
            this.additivesLbl.AutoSize = true;
            this.additivesLbl.Location = new System.Drawing.Point(12, 209);
            this.additivesLbl.Name = "additivesLbl";
            this.additivesLbl.Size = new System.Drawing.Size(53, 13);
            this.additivesLbl.TabIndex = 9;
            this.additivesLbl.Text = "Additives ";
            // 
            // orderTxt
            // 
            this.orderTxt.Location = new System.Drawing.Point(15, 357);
            this.orderTxt.Multiline = true;
            this.orderTxt.Name = "orderTxt";
            this.orderTxt.Size = new System.Drawing.Size(280, 81);
            this.orderTxt.TabIndex = 11;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(15, 337);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 13;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // coffeeBarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST_150_Activity14.Properties.Resources.CST_150_Activity14_Background;
            this.ClientSize = new System.Drawing.Size(612, 444);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.orderTxt);
            this.Controls.Add(this.additivesLbl);
            this.Controls.Add(this.iceHotLbl);
            this.Controls.Add(this.drinkLbl);
            this.Controls.Add(this.vanillaSyrupCheckBox);
            this.Controls.Add(this.sugarCheckBox);
            this.Controls.Add(this.milkCheckBox);
            this.Controls.Add(this.hotRadioBtn);
            this.Controls.Add(this.iceRadioBtn);
            this.Controls.Add(this.drinkListBox);
            this.Name = "coffeeBarFrm";
            this.Text = "Coffee Bar Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox drinkListBox;
        private System.Windows.Forms.RadioButton iceRadioBtn;
        private System.Windows.Forms.RadioButton hotRadioBtn;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.CheckBox sugarCheckBox;
        private System.Windows.Forms.CheckBox vanillaSyrupCheckBox;
        private System.Windows.Forms.Label drinkLbl;
        private System.Windows.Forms.Label iceHotLbl;
        private System.Windows.Forms.Label additivesLbl;
        private System.Windows.Forms.TextBox orderTxt;
        private System.Windows.Forms.Button orderBtn;
    }
}

