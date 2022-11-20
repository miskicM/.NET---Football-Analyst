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
    public partial class PlayerForm : Form
    {
        private FAnalyst analyst;
        public PlayerForm(FAnalyst fa)
        {
            InitializeComponent();
            analyst = fa;
        }

        private void button_addPlayer_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_club.Text == "") return;

            int height;
            int weight;

            Player player = new Player(textBox_name.Text, textBox_club.Text);

            if (int.TryParse(textBox_height.Text, out height))
            {
                player.SetHeight(height);
            }
            if (int.TryParse(textBox_weight.Text, out weight))
            {
                player.SetWeight(weight);
            }
            player.SetNationality(textBox_nationality.Text)
                  .SetDateOfBirth(calendar_DoB.SelectionStart);

            DatabaseAccessor.SavePlayer(player);
            analyst.UpdatePlayerPool();

            this.Close();
        }
    }
}
