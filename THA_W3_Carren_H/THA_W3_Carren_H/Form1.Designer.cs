namespace THA_w2_Carren_H
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phonenum = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phonenum = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(17, 67);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(115, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name               :";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(17, 126);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(114, 20);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "Age                  :";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(17, 182);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(116, 20);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email                :";
            // 
            // label_phonenum
            // 
            this.label_phonenum.AutoSize = true;
            this.label_phonenum.Location = new System.Drawing.Point(17, 237);
            this.label_phonenum.Name = "label_phonenum";
            this.label_phonenum.Size = new System.Drawing.Size(123, 20);
            this.label_phonenum.TabIndex = 3;
            this.label_phonenum.Text = "Phone Number: ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(146, 61);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(260, 26);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(146, 126);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(260, 26);
            this.textBox_age.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(146, 179);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(260, 26);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_phonenum
            // 
            this.textBox_phonenum.Location = new System.Drawing.Point(146, 234);
            this.textBox_phonenum.Name = "textBox_phonenum";
            this.textBox_phonenum.Size = new System.Drawing.Size(260, 26);
            this.textBox_phonenum.TabIndex = 7;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(21, 322);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(165, 49);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(239, 322);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(167, 49);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_phonenum);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phonenum);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phonenum;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phonenum;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_clear;
    }
}

