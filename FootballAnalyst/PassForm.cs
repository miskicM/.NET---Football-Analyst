using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballAnalyst
{
    public partial class PassForm : Form
    {
        private FAnalyst analyst;
        private Match match;
        private Touch touch;
        public PassForm(FAnalyst fa, Match match)
        {
            InitializeComponent();
            analyst = fa;
            this.match = match;

            touch = new Touch(1,Touch.Type.Pass);
        }

        private void check_successful_CheckedChanged(object sender, EventArgs e)
        {
            touch.Successful = !touch.Successful;
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int min;
            if (!int.TryParse(textBox_minute.Text, out min)) return;
            touch.Minute = min;

            match.Touches.Add(touch);
            this.Close();
        }
    }
}
