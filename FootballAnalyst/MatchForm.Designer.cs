
namespace FootballAnalyst
{
    partial class MatchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_homeTeam = new System.Windows.Forms.TextBox();
            this.textBox_homeGoals = new System.Windows.Forms.TextBox();
            this.textBox_awayGoals = new System.Windows.Forms.TextBox();
            this.textBox_awayTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matchDate = new System.Windows.Forms.MonthCalendar();
            this.playerInHomeTeam = new System.Windows.Forms.RadioButton();
            this.playerInAwayTeam = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_homeTeam
            // 
            this.textBox_homeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_homeTeam.Location = new System.Drawing.Point(48, 18);
            this.textBox_homeTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_homeTeam.Multiline = true;
            this.textBox_homeTeam.Name = "textBox_homeTeam";
            this.textBox_homeTeam.Size = new System.Drawing.Size(217, 53);
            this.textBox_homeTeam.TabIndex = 1;
            // 
            // textBox_homeGoals
            // 
            this.textBox_homeGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_homeGoals.Location = new System.Drawing.Point(303, 18);
            this.textBox_homeGoals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_homeGoals.MaxLength = 2;
            this.textBox_homeGoals.Multiline = true;
            this.textBox_homeGoals.Name = "textBox_homeGoals";
            this.textBox_homeGoals.Size = new System.Drawing.Size(54, 53);
            this.textBox_homeGoals.TabIndex = 2;
            this.textBox_homeGoals.Text = "0";
            this.textBox_homeGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_awayGoals
            // 
            this.textBox_awayGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_awayGoals.Location = new System.Drawing.Point(368, 18);
            this.textBox_awayGoals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_awayGoals.MaxLength = 2;
            this.textBox_awayGoals.Multiline = true;
            this.textBox_awayGoals.Name = "textBox_awayGoals";
            this.textBox_awayGoals.Size = new System.Drawing.Size(54, 53);
            this.textBox_awayGoals.TabIndex = 3;
            this.textBox_awayGoals.Text = "0";
            this.textBox_awayGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_awayTeam
            // 
            this.textBox_awayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_awayTeam.Location = new System.Drawing.Point(465, 18);
            this.textBox_awayTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_awayTeam.Multiline = true;
            this.textBox_awayTeam.Name = "textBox_awayTeam";
            this.textBox_awayTeam.Size = new System.Drawing.Size(217, 53);
            this.textBox_awayTeam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Away Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score";
            // 
            // matchDate
            // 
            this.matchDate.Location = new System.Drawing.Point(252, 107);
            this.matchDate.Name = "matchDate";
            this.matchDate.TabIndex = 9;
            // 
            // playerInHomeTeam
            // 
            this.playerInHomeTeam.AutoSize = true;
            this.playerInHomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInHomeTeam.Location = new System.Drawing.Point(48, 101);
            this.playerInHomeTeam.Name = "playerInHomeTeam";
            this.playerInHomeTeam.Size = new System.Drawing.Size(160, 20);
            this.playerInHomeTeam.TabIndex = 10;
            this.playerInHomeTeam.TabStop = true;
            this.playerInHomeTeam.Text = "Scouted player\'s team";
            this.playerInHomeTeam.UseVisualStyleBackColor = true;
            this.playerInHomeTeam.CheckedChanged += new System.EventHandler(this.playerInHomeTeam_CheckedChanged);
            // 
            // playerInAwayTeam
            // 
            this.playerInAwayTeam.AutoSize = true;
            this.playerInAwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInAwayTeam.Location = new System.Drawing.Point(522, 101);
            this.playerInAwayTeam.Name = "playerInAwayTeam";
            this.playerInAwayTeam.Size = new System.Drawing.Size(160, 20);
            this.playerInAwayTeam.TabIndex = 11;
            this.playerInAwayTeam.TabStop = true;
            this.playerInAwayTeam.Text = "Scouted player\'s team";
            this.playerInAwayTeam.UseVisualStyleBackColor = true;
            this.playerInAwayTeam.CheckedChanged += new System.EventHandler(this.playerInAwayTeam_CheckedChanged);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 368);
            this.Controls.Add(this.playerInAwayTeam);
            this.Controls.Add(this.playerInHomeTeam);
            this.Controls.Add(this.matchDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_awayTeam);
            this.Controls.Add(this.textBox_awayGoals);
            this.Controls.Add(this.textBox_homeGoals);
            this.Controls.Add(this.textBox_homeTeam);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MatchForm";
            this.Text = "Enter match details:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_homeTeam;
        private System.Windows.Forms.TextBox textBox_homeGoals;
        private System.Windows.Forms.TextBox textBox_awayGoals;
        private System.Windows.Forms.TextBox textBox_awayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar matchDate;
        private System.Windows.Forms.RadioButton playerInHomeTeam;
        private System.Windows.Forms.RadioButton playerInAwayTeam;
    }
}