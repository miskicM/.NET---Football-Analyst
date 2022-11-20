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
    public partial class DuelForm : Form
    {
        private FAnalyst analyst;
        private Match match;
        private Touch duel;
        public DuelForm(FAnalyst fa, Match match)
        {
            InitializeComponent();
            analyst = fa;
            this.match = match;

            duel = new Touch(1, Touch.Type.Duel);
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int min;
            if (!int.TryParse(textBox_minute.Text, out min)) return;
            duel.Minute = min;

            if (aerial.Checked) duel.OnGround = false;
            if (ground.Checked) duel.OnGround = true;

            duel.Successful = check_successful.Checked;

            match.Touches.Add(duel);
            this.Close();
            analyst.RefreshInterface();
        }
    }
}
