namespace Main_Gym
{
    partial class Main
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_scrh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_add.Location = new System.Drawing.Point(172, 81);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(311, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add a new member";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_scrh
            // 
            this.btn_scrh.Location = new System.Drawing.Point(172, 110);
            this.btn_scrh.Name = "btn_scrh";
            this.btn_scrh.Size = new System.Drawing.Size(311, 23);
            this.btn_scrh.TabIndex = 0;
            this.btn_scrh.Text = "Search a Member";
            this.btn_scrh.UseVisualStyleBackColor = true;
            this.btn_scrh.Click += new System.EventHandler(this.btn_scrh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(172, 226);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(311, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change Plan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(311, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete a Member";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(172, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(311, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Equipments";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(665, 449);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_scrh);
            this.Controls.Add(this.btn_add);
            this.Name = "Main";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_srch;
        private System.Windows.Forms.Button button3;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private GymDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_scrh;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}