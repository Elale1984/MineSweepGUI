
namespace MineSweepGUI
{
    partial class MineSweeperGame
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
            this.pn_Board = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.tm_GameTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Board
            // 
            this.pn_Board.Location = new System.Drawing.Point(28, 123);
            this.pn_Board.Name = "pn_Board";
            this.pn_Board.Size = new System.Drawing.Size(400, 400);
            this.pn_Board.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "MineSweeper";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Clock);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(28, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 55);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clock.ForeColor = System.Drawing.Color.Red;
            this.lbl_Clock.Location = new System.Drawing.Point(49, 9);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(34, 33);
            this.lbl_Clock.TabIndex = 0;
            this.lbl_Clock.Text = "0";
            this.lbl_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tm_GameTime
            // 
            this.tm_GameTime.Tick += new System.EventHandler(this.tm_Timer_Tick);
            // 
            // MineSweeperGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_Board);
            this.Name = "MineSweeperGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineSweeperGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Board;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Timer tm_GameTime;
    }
}