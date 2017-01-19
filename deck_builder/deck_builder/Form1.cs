using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deck_builder
{
    public partial class builderForm : Form
    {
        public builderForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokemonBox.Height += 100;
            this.pokemonBox.Controls.Remove(this.textBox7);
        }
    }
}
