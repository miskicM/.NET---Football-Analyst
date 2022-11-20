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
    public partial class DribbleForm : Form
    {
        FAnalyst analyst;
        Match match;
        Touch touch;

        public DribbleForm(FAnalyst fa, Match match)
        {
            InitializeComponent();
            analyst = fa;
            this.match = match;

            touch = new Touch(1, Touch.Type.Dribble);
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int min;
            if (!int.TryParse(textBox_minute.Text, out min)) return;
            touch.Minute = min;

            if (leftDribble.Checked) touch.MethodOfExecution = Touch.Method.LeftFoot;
            touch.Successful = check_successful.Checked;

            match.Touches.Add(touch);
            this.Close();
            analyst.RefreshInterface();

        }
    }
}
