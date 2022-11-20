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
    public partial class TackleForm : Form
    {
        private FAnalyst analyst;
        private Match match;
        private Touch tackle;
        public TackleForm(FAnalyst fa, Match match)
        {
            InitializeComponent();
            analyst = fa;
            this.match = match;

            tackle = new Touch(1, Touch.Type.Tackle);
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int min;
            if (!int.TryParse(textBox_minute.Text, out min)) return;
            tackle.Minute = min;

            tackle.Successful = check_successful.Checked;

            match.Touches.Add(tackle);
            this.Close();
            analyst.RefreshInterface();
        }
    }
}
