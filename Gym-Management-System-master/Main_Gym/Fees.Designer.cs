namespace Main_Gym
{
    partial class Fees
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
            this.txt_feeid = new System.Windows.Forms.TextBox();
            this.comboBox_fee = new System.Windows.Forms.ComboBox();
            this.btn_fee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_feeid
            // 
            this.txt_feeid.Location = new System.Drawing.Point(157, 64);
            this.txt_feeid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_feeid.Name = "txt_feeid";
            this.txt_feeid.Size = new System.Drawing.Size(267, 22);
            this.txt_feeid.TabIndex = 1;
            // 
            // comboBox_fee
            // 
            this.comboBox_fee.FormattingEnabled = true;
            this.comboBox_fee.Items.AddRange(new object[] {
            "Yearly",
            "Monthly",
            "Quarterly",
            "Weekly"});
            this.comboBox_fee.Location = new System.Drawing.Point(157, 126);
            this.comboBox_fee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_fee.Name = "comboBox_fee";
            this.comboBox_fee.Size = new System.Drawing.Size(267, 24);
            this.comboBox_fee.TabIndex = 2;
            this.comboBox_fee.Text = "Plan";
            // 
            // btn_fee
            // 
            this.btn_fee.Location = new System.Drawing.Point(212, 201);
            this.btn_fee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fee.Name = "btn_fee";
            this.btn_fee.Size = new System.Drawing.Size(100, 28);
            this.btn_fee.TabIndex = 0;
            this.btn_fee.Text = "Pay";
            this.btn_fee.UseVisualStyleBackColor = true;
            this.btn_fee.Click += new System.EventHandler(this.btn_fee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plan";
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_fee);
            this.Controls.Add(this.txt_feeid);
            this.Controls.Add(this.btn_fee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fees";
            this.Text = "Fees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_feeid;
        private System.Windows.Forms.ComboBox comboBox_fee;
        private System.Windows.Forms.Button btn_fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}