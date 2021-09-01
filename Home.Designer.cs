
namespace Fifa_StatRandomizer
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset_Btn = new System.Windows.Forms.Button();
            this.generate_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.position_dropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weight_dropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.potential_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.height_dropDown = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potential_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset_Btn);
            this.groupBox1.Controls.Add(this.generate_Btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.position_dropDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.weight_dropDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.potential_numericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.height_dropDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Data";
            // 
            // reset_Btn
            // 
            this.reset_Btn.Location = new System.Drawing.Point(12, 378);
            this.reset_Btn.Name = "reset_Btn";
            this.reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.reset_Btn.TabIndex = 9;
            this.reset_Btn.Text = "Reset";
            this.reset_Btn.UseVisualStyleBackColor = true;
            this.reset_Btn.Click += new System.EventHandler(this.reset_Btn_Click);
            // 
            // generate_Btn
            // 
            this.generate_Btn.Location = new System.Drawing.Point(92, 378);
            this.generate_Btn.Name = "generate_Btn";
            this.generate_Btn.Size = new System.Drawing.Size(75, 23);
            this.generate_Btn.TabIndex = 8;
            this.generate_Btn.Text = "Generate";
            this.generate_Btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Position";
            // 
            // position_dropDown
            // 
            this.position_dropDown.FormattingEnabled = true;
            this.position_dropDown.Location = new System.Drawing.Point(11, 164);
            this.position_dropDown.Name = "position_dropDown";
            this.position_dropDown.Size = new System.Drawing.Size(121, 21);
            this.position_dropDown.TabIndex = 6;
            this.position_dropDown.Text = "--Select--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // weight_dropDown
            // 
            this.weight_dropDown.FormattingEnabled = true;
            this.weight_dropDown.Location = new System.Drawing.Point(10, 122);
            this.weight_dropDown.Name = "weight_dropDown";
            this.weight_dropDown.Size = new System.Drawing.Size(121, 21);
            this.weight_dropDown.TabIndex = 4;
            this.weight_dropDown.Text = "--Select--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // potential_numericUpDown
            // 
            this.potential_numericUpDown.Location = new System.Drawing.Point(10, 42);
            this.potential_numericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.potential_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.potential_numericUpDown.Name = "potential_numericUpDown";
            this.potential_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.potential_numericUpDown.TabIndex = 2;
            this.potential_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Potential";
            // 
            // height_dropDown
            // 
            this.height_dropDown.FormattingEnabled = true;
            this.height_dropDown.Location = new System.Drawing.Point(9, 81);
            this.height_dropDown.Name = "height_dropDown";
            this.height_dropDown.Size = new System.Drawing.Size(121, 21);
            this.height_dropDown.TabIndex = 0;
            this.height_dropDown.Text = "--Select--";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "FIFA Stat Randomizer";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potential_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox height_dropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown potential_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox position_dropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox weight_dropDown;
        private System.Windows.Forms.Button reset_Btn;
        private System.Windows.Forms.Button generate_Btn;
    }
}