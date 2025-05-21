using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void GameLoad(object sender, EventArgs e)
        {
          
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            f1 = null;
            this.Show();
           
        }
    }
}
