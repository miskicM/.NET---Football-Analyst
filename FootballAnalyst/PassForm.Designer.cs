
namespace FootballAnalyst
{
    partial class PassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.check_successful = new System.Windows.Forms.CheckBox();
            this.button_finish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_minute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successful:";
            // 
            // check_successful
            // 
            this.check_successful.AutoSize = true;
            this.check_successful.Checked = true;
            this.check_successful.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_successful.Location = new System.Drawing.Point(111, 13);
            this.check_successful.Name = "check_successful";
            this.check_successful.Size = new System.Drawing.Size(15, 14);
            this.check_successful.TabIndex = 1;
            this.check_successful.UseVisualStyleBackColor = false;
            this.check_successful.CheckedChanged += new System.EventHandler(this.check_successful_CheckedChanged);
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(84, 124);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(98, 39);
            this.button_finish.TabIndex = 2;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minute:";
            // 
            // textBox_minute
            // 
            this.textBox_minute.Location = new System.Drawing.Point(111, 44);
            this.textBox_minute.MaxLength = 3;
            this.textBox_minute.Name = "textBox_minute";
            this.textBox_minute.Size = new System.Drawing.Size(35, 26);
            this.textBox_minute.TabIndex = 4;
            // 
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.textBox_minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.check_successful);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PassForm";
            this.Text = "Record a pass:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_successful;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_minute;
    }
}