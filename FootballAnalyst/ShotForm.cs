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
    public partial class ShotForm : Form
    {
        private FAnalyst analyst;
        private Match match;
        private Touch shot;

        public ShotForm(FAnalyst fa, Match match)
        {
            InitializeComponent();
            analyst = fa;
            this.match = match;

            shot = new Touch(1, Touch.Type.Shot);
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int min;
            if (!int.TryParse(textBox_minute.Text, out min)) return;
            shot.Minute = min;

            if (rightFootShot.Checked) shot.MethodOfExecution = Touch.Method.RightFoot;
            if (leftFootShot.Checked) shot.MethodOfExecution = Touch.Method.LeftFoot;
            if (headerShot.Checked) shot.MethodOfExecution = Touch.Method.Head;

            shot.Successful = check_successful.Checked;

            match.Touches.Add(shot);
            this.Close();
            analyst.RefreshInterface();
        }
    }
}
