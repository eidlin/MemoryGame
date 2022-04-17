
namespace MemoryGame
{
    partial class Window2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_MainPic = new System.Windows.Forms.PictureBox();
            this.rbtn_option3 = new System.Windows.Forms.RadioButton();
            this.rbtn_option1 = new System.Windows.Forms.RadioButton();
            this.btn_ClearAnswer = new System.Windows.Forms.Button();
            this.rbtn_option2 = new System.Windows.Forms.RadioButton();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_MainPic
            // 
            this.pb_MainPic.Location = new System.Drawing.Point(282, 55);
            this.pb_MainPic.Name = "pb_MainPic";
            this.pb_MainPic.Size = new System.Drawing.Size(140, 70);
            this.pb_MainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MainPic.TabIndex = 0;
            this.pb_MainPic.TabStop = false;
            // 
            // rbtn_option3
            // 
            this.rbtn_option3.AutoSize = true;
            this.rbtn_option3.Location = new System.Drawing.Point(521, 308);
            this.rbtn_option3.Name = "rbtn_option3";
            this.rbtn_option3.Size = new System.Drawing.Size(94, 19);
            this.rbtn_option3.TabIndex = 3;
            this.rbtn_option3.TabStop = true;
            this.rbtn_option3.Text = "radioButton3";
            this.rbtn_option3.UseVisualStyleBackColor = true;
            this.rbtn_option3.Visible = false;
            // 
            // rbtn_option1
            // 
            this.rbtn_option1.AutoSize = true;
            this.rbtn_option1.Location = new System.Drawing.Point(167, 308);
            this.rbtn_option1.Name = "rbtn_option1";
            this.rbtn_option1.Size = new System.Drawing.Size(94, 19);
            this.rbtn_option1.TabIndex = 4;
            this.rbtn_option1.TabStop = true;
            this.rbtn_option1.Text = "radioButton1";
            this.rbtn_option1.UseVisualStyleBackColor = true;
            this.rbtn_option1.Visible = false;
            // 
            // btn_ClearAnswer
            // 
            this.btn_ClearAnswer.Location = new System.Drawing.Point(347, 358);
            this.btn_ClearAnswer.Name = "btn_ClearAnswer";
            this.btn_ClearAnswer.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearAnswer.TabIndex = 5;
            this.btn_ClearAnswer.Text = "send";
            this.btn_ClearAnswer.UseVisualStyleBackColor = true;
            this.btn_ClearAnswer.Visible = false;
            this.btn_ClearAnswer.Click += new System.EventHandler(this.btn_ClearAnswer_Click);
            // 
            // rbtn_option2
            // 
            this.rbtn_option2.AutoSize = true;
            this.rbtn_option2.Location = new System.Drawing.Point(347, 307);
            this.rbtn_option2.Name = "rbtn_option2";
            this.rbtn_option2.Size = new System.Drawing.Size(94, 19);
            this.rbtn_option2.TabIndex = 6;
            this.rbtn_option2.TabStop = true;
            this.rbtn_option2.Text = "radioButton2";
            this.rbtn_option2.UseVisualStyleBackColor = true;
            this.rbtn_option2.Visible = false;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Location = new System.Drawing.Point(26, 23);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(40, 15);
            this.lbl_Timer.TabIndex = 7;
            this.lbl_Timer.Text = "Timer:";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(646, 23);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(48, 15);
            this.lbl_Score.TabIndex = 8;
            this.lbl_Score.Text = "Score: 0";
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.rbtn_option2);
            this.Controls.Add(this.btn_ClearAnswer);
            this.Controls.Add(this.rbtn_option1);
            this.Controls.Add(this.rbtn_option3);
            this.Controls.Add(this.pb_MainPic);
            this.Name = "Window2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_MainPic;
        private System.Windows.Forms.RadioButton rbtn_option3;
        private System.Windows.Forms.RadioButton rbtn_option1;
        private System.Windows.Forms.Button btn_ClearAnswer;
        private System.Windows.Forms.RadioButton rbtn_option2;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Score;
    }
}