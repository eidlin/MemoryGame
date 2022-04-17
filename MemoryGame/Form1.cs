using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Window1 : System.Windows.Forms.Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            string name =txtb_Name.Text;
            if (name.Length == 0) //Add && checking white spaces!
            {
                MessageBox.Show("TEXT BOX IS EMPTY", "Error");
            }
            else
            {
                Window2 secondWindow = new Window2();
                secondWindow.Show();
              
            }
        }
    }
}


