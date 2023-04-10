namespace THA_W6_Carren_H
{
    partial class Form1
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
            this.label_wordle = new System.Windows.Forms.Label();
            this.label_guess = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_wordle
            // 
            this.label_wordle.AutoSize = true;
            this.label_wordle.Location = new System.Drawing.Point(169, 58);
            this.label_wordle.Name = "label_wordle";
            this.label_wordle.Size = new System.Drawing.Size(59, 20);
            this.label_wordle.TabIndex = 0;
            this.label_wordle.Text = "Wordle";
            // 
            // label_guess
            // 
            this.label_guess.AutoSize = true;
            this.label_guess.Location = new System.Drawing.Point(101, 90);
            this.label_guess.Name = "label_guess";
            this.label_guess.Size = new System.Drawing.Size(208, 20);
            this.label_guess.TabIndex = 1;
            this.label_guess.Text = "Set how much you an guess";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(144, 172);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 30);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // textBox_guess
            // 
            this.textBox_guess.Location = new System.Drawing.Point(144, 127);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(100, 26);
            this.textBox_guess.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 342);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_guess);
            this.Controls.Add(this.label_wordle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wordle;
        private System.Windows.Forms.Label label_guess;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.TextBox textBox_guess;
    }
}

