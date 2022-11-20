
namespace FootballAnalyst
{
    partial class DribbleForm
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
            this.textBox_minute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.check_successful = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftDribble = new System.Windows.Forms.RadioButton();
            this.rightDribble = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_minute
            // 
            this.textBox_minute.Location = new System.Drawing.Point(111, 44);
            this.textBox_minute.MaxLength = 3;
            this.textBox_minute.Name = "textBox_minute";
            this.textBox_minute.Size = new System.Drawing.Size(35, 26);
            this.textBox_minute.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minute:";
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(130, 164);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(98, 39);
            this.button_finish.TabIndex = 7;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // check_successful
            // 
            this.check_successful.AutoSize = true;
            this.check_successful.Checked = true;
            this.check_successful.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_successful.Location = new System.Drawing.Point(111, 13);
            this.check_successful.Name = "check_successful";
            this.check_successful.Size = new System.Drawing.Size(15, 14);
            this.check_successful.TabIndex = 6;
            this.check_successful.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Successful:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Foot:";
            // 
            // leftDribble
            // 
            this.leftDribble.AutoSize = true;
            this.leftDribble.Location = new System.Drawing.Point(111, 94);
            this.leftDribble.Name = "leftDribble";
            this.leftDribble.Size = new System.Drawing.Size(55, 24);
            this.leftDribble.TabIndex = 11;
            this.leftDribble.TabStop = true;
            this.leftDribble.Text = "Left";
            this.leftDribble.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.leftDribble.UseVisualStyleBackColor = true;
            // 
            // rightDribble
            // 
            this.rightDribble.AutoSize = true;
            this.rightDribble.Location = new System.Drawing.Point(172, 94);
            this.rightDribble.Name = "rightDribble";
            this.rightDribble.Size = new System.Drawing.Size(65, 24);
            this.rightDribble.TabIndex = 12;
            this.rightDribble.TabStop = true;
            this.rightDribble.Text = "Right";
            this.rightDribble.UseVisualStyleBackColor = true;
            // 
            // DribbleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.Controls.Add(this.rightDribble);
            this.Controls.Add(this.leftDribble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.check_successful);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DribbleForm";
            this.Text = "Record a dribble:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_minute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.CheckBox check_successful;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton leftDribble;
        private System.Windows.Forms.RadioButton rightDribble;
    }
}