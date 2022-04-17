
namespace MemoryGame
{
    partial class Window1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.lbl_EnterYourName = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(269, 140);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.Size = new System.Drawing.Size(100, 23);
            this.txtb_Name.TabIndex = 0;
            // 
            // lbl_EnterYourName
            // 
            this.lbl_EnterYourName.AutoSize = true;
            this.lbl_EnterYourName.Location = new System.Drawing.Point(269, 99);
            this.lbl_EnterYourName.Name = "lbl_EnterYourName";
            this.lbl_EnterYourName.Size = new System.Drawing.Size(97, 15);
            this.lbl_EnterYourName.TabIndex = 1;
            this.lbl_EnterYourName.Text = "Enter your name:";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(269, 186);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(75, 23);
            this.btn_StartGame.TabIndex = 2;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.lbl_EnterYourName);
            this.Controls.Add(this.txtb_Name);
            this.Name = "Window1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.Label lbl_EnterYourName;
        private System.Windows.Forms.Button btn_StartGame;
    }
}

