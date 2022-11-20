
namespace FootballAnalyst
{
    partial class ShotForm
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
            this.rightFootShot = new System.Windows.Forms.RadioButton();
            this.leftFootShot = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_minute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.check_successful = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerShot = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightFootShot
            // 
            this.rightFootShot.AutoSize = true;
            this.rightFootShot.Location = new System.Drawing.Point(209, 67);
            this.rightFootShot.Name = "rightFootShot";
            this.rightFootShot.Size = new System.Drawing.Size(102, 24);
            this.rightFootShot.TabIndex = 20;
            this.rightFootShot.TabStop = true;
            this.rightFootShot.Text = "Right Foot";
            this.rightFootShot.UseVisualStyleBackColor = true;
            // 
            // leftFootShot
            // 
            this.leftFootShot.AutoSize = true;
            this.leftFootShot.Location = new System.Drawing.Point(111, 67);
            this.leftFootShot.Name = "leftFootShot";
            this.leftFootShot.Size = new System.Drawing.Size(92, 24);
            this.leftFootShot.TabIndex = 19;
            this.leftFootShot.TabStop = true;
            this.leftFootShot.Text = "Left Foot";
            this.leftFootShot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.leftFootShot.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Method:";
            // 
            // textBox_minute
            // 
            this.textBox_minute.Location = new System.Drawing.Point(111, 17);
            this.textBox_minute.MaxLength = 3;
            this.textBox_minute.Name = "textBox_minute";
            this.textBox_minute.Size = new System.Drawing.Size(35, 26);
            this.textBox_minute.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Minute:";
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(172, 200);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(98, 39);
            this.button_finish.TabIndex = 15;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // check_successful
            // 
            this.check_successful.AutoSize = true;
            this.check_successful.Location = new System.Drawing.Point(111, 107);
            this.check_successful.Name = "check_successful";
            this.check_successful.Size = new System.Drawing.Size(15, 14);
            this.check_successful.TabIndex = 14;
            this.check_successful.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "On Target:";
            // 
            // headerShot
            // 
            this.headerShot.AutoSize = true;
            this.headerShot.Location = new System.Drawing.Point(317, 67);
            this.headerShot.Name = "headerShot";
            this.headerShot.Size = new System.Drawing.Size(80, 24);
            this.headerShot.TabIndex = 21;
            this.headerShot.TabStop = true;
            this.headerShot.Text = "Header";
            this.headerShot.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Goal:";
            // 
            // ShotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 270);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.headerShot);
            this.Controls.Add(this.rightFootShot);
            this.Controls.Add(this.leftFootShot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.check_successful);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShotForm";
            this.Text = "Record a shot:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rightFootShot;
        private System.Windows.Forms.RadioButton leftFootShot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_minute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.CheckBox check_successful;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton headerShot;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
    }
}