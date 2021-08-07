
namespace MineSweepGUI
{
    partial class Form1
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
            this.rb_Easy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Medium = new System.Windows.Forms.RadioButton();
            this.rb_Hard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_Easy
            // 
            this.rb_Easy.AutoSize = true;
            this.rb_Easy.Location = new System.Drawing.Point(156, 176);
            this.rb_Easy.Name = "rb_Easy";
            this.rb_Easy.Size = new System.Drawing.Size(59, 24);
            this.rb_Easy.TabIndex = 0;
            this.rb_Easy.TabStop = true;
            this.rb_Easy.Text = "Easy";
            this.rb_Easy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To MineSweeper";
            // 
            // btn_Start
            // 
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.FlatAppearance.BorderSize = 20;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Location = new System.Drawing.Point(486, 313);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(171, 50);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start Game";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select A Difficulty Level:";
            // 
            // rb_Medium
            // 
            this.rb_Medium.AutoSize = true;
            this.rb_Medium.Location = new System.Drawing.Point(156, 216);
            this.rb_Medium.Name = "rb_Medium";
            this.rb_Medium.Size = new System.Drawing.Size(85, 24);
            this.rb_Medium.TabIndex = 4;
            this.rb_Medium.TabStop = true;
            this.rb_Medium.Text = "Medium";
            this.rb_Medium.UseVisualStyleBackColor = true;
            // 
            // rb_Hard
            // 
            this.rb_Hard.AutoSize = true;
            this.rb_Hard.Location = new System.Drawing.Point(156, 263);
            this.rb_Hard.Name = "rb_Hard";
            this.rb_Hard.Size = new System.Drawing.Size(63, 24);
            this.rb_Hard.TabIndex = 5;
            this.rb_Hard.TabStop = true;
            this.rb_Hard.Text = "Hard";
            this.rb_Hard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Hard);
            this.Controls.Add(this.rb_Medium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_Easy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Medium;
        private System.Windows.Forms.RadioButton rb_Hard;
    }
}

