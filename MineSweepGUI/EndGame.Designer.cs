
namespace MineSweepGUI
{
    partial class EndGame
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
            this.lbl_GameOver = new System.Windows.Forms.Label();
            this.lbl_EndMessage = new System.Windows.Forms.Label();
            this.lbl_GameTimer = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_GameOver
            // 
            this.lbl_GameOver.AutoSize = true;
            this.lbl_GameOver.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GameOver.ForeColor = System.Drawing.Color.Red;
            this.lbl_GameOver.Location = new System.Drawing.Point(92, 33);
            this.lbl_GameOver.Name = "lbl_GameOver";
            this.lbl_GameOver.Size = new System.Drawing.Size(204, 42);
            this.lbl_GameOver.TabIndex = 0;
            this.lbl_GameOver.Text = "Game Over";
            // 
            // lbl_EndMessage
            // 
            this.lbl_EndMessage.AutoSize = true;
            this.lbl_EndMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_EndMessage.Location = new System.Drawing.Point(128, 88);
            this.lbl_EndMessage.Name = "lbl_EndMessage";
            this.lbl_EndMessage.Size = new System.Drawing.Size(100, 20);
            this.lbl_EndMessage.TabIndex = 1;
            this.lbl_EndMessage.Text = "You Blew Up!!";
            // 
            // lbl_GameTimer
            // 
            this.lbl_GameTimer.AutoSize = true;
            this.lbl_GameTimer.ForeColor = System.Drawing.Color.Red;
            this.lbl_GameTimer.Location = new System.Drawing.Point(116, 141);
            this.lbl_GameTimer.Name = "lbl_GameTimer";
            this.lbl_GameTimer.Size = new System.Drawing.Size(92, 20);
            this.lbl_GameTimer.TabIndex = 2;
            this.lbl_GameTimer.Text = "Game Time: ";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Black;
            this.btn_PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.Red;
            this.btn_PlayAgain.Location = new System.Drawing.Point(82, 211);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(94, 29);
            this.btn_PlayAgain.TabIndex = 4;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.ForeColor = System.Drawing.Color.Red;
            this.btn_Quit.Location = new System.Drawing.Point(193, 211);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(94, 29);
            this.btn_Quit.TabIndex = 5;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.ForeColor = System.Drawing.Color.Red;
            this.lbl_Time.Location = new System.Drawing.Point(228, 141);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(17, 20);
            this.lbl_Time.TabIndex = 6;
            this.lbl_Time.Text = "0";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(366, 295);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.lbl_GameTimer);
            this.Controls.Add(this.lbl_EndMessage);
            this.Controls.Add(this.lbl_GameOver);
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GameOver;
        private System.Windows.Forms.Label lbl_EndMessage;
        private System.Windows.Forms.Label lbl_GameTimer;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_Time;
    }
}