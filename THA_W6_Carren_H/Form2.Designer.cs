namespace THA_W6_Carren_H
{
    partial class Form2
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
            this.button_enter = new System.Windows.Forms.Button();
            this.button_delte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(617, 289);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(90, 40);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_delte
            // 
            this.button_delte.Location = new System.Drawing.Point(985, 289);
            this.button_delte.Name = "button_delte";
            this.button_delte.Size = new System.Drawing.Size(90, 40);
            this.button_delte.TabIndex = 1;
            this.button_delte.Text = "Delete";
            this.button_delte.UseVisualStyleBackColor = true;
            this.button_delte.Click += new System.EventHandler(this.button_delte_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 575);
            this.Controls.Add(this.button_delte);
            this.Controls.Add(this.button_enter);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_delte;
    }
}