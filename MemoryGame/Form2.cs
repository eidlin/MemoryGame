using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Window2 : System.Windows.Forms.Form
    {
        public Window2()
        {
            InitializeComponent();
            int viewingTime = 20;

            //  pb_MainPic.Image = Image.FromFile(@"..\..\images\Animals.jpg");


            List<String> path = new List<String>();
            path.Add(@"..\..\images\Animals.jpg");
            path.Add(@"..\..\images\Kids.jpg");
            path.Add(@"..\..\images\SnowWhite.jpg");
            path.Add(@"..\..\images\Farm.jpg");
            path.Add(@"..\..\images\Bugs.jpg");
            path.Add(@"..\..\images\kids2.jpg");
            path.Add(@"..\..\images\kids3.jpg");
            path.Add(@"..\..\images\kids4.jpg");
            path.Add(@"..\..\images\kids5.jpg");
            path.Add(@"..\..\images\kid6.jpg");
            string[,,] GameData = new string[path.Count,2,10];
            //int i = 5;
            // string[] goodAnswers = GameData[i,0];
            //string[,,] GameData = new string[10, 2, 10] { { { { } } };


        Random random = new Random();
            pb_MainPic.ImageLocation = path[random.Next(0, path.Count - 1)];

            Timer tm = new Timer();
            pb_MainPic.Visible = true;
            tm.Enabled = true;
            tm.Interval = 5000;
            tm.Tick += timerTick;
            tm.Start();

            void timerTick(object sender, EventArgs e)
            {
                pb_MainPic.Visible = false;
                rbtn_option1.Visible = true;
                rbtn_option2.Visible = true;
                rbtn_option3.Visible = true;
                btn_ClearAnswer.Visible = true;

                int viewingTime = 20;
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                lbl_Timer.Text = "Timer: "+ viewingTime.ToString();










                ((Timer)sender).Stop();
            }

             void timer1_Tick(object sender, EventArgs e)
            {
                viewingTime--;
                if (viewingTime == 0)
                {
                    timer1.Stop();
                    
                }

                lbl_Timer.Text = "Timer: " + viewingTime.ToString();


            }






            //Random random = new Random();
            //pb_Cat.ImageLocation = TheRightPick[random.Next(0, TheRightPick.Count - 1)];
            //pb_Ball.ImageLocation = TheRightPick[random.Next(0, TheRightPick.Count - 1)];
            //pb_dog.ImageLocation = TheWrongPick[random.Next(0, TheWrongPick.Count - 1)];
            //pb_Cat.Visible = false;
            //pb_Ball.Visible = false;
            //pb_dog.Visible = false;






        }

        

        private void btn_ClearAnswer_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            if (rbtn_option1.Checked == isChecked)
            {
                rbtn_option1.Visible = false;
                
            }
            else if (rbtn_option2.Checked == isChecked)
            {

                rbtn_option2.Visible = false;
            }
            else if(rbtn_option3.Checked == isChecked)
            {

                rbtn_option3.Visible = false;

            }
        }
    }
}
