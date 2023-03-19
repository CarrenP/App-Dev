namespace THA_Week_3_Carren_H
{
    partial class Form_main
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
            this.textBox_favartist = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.checkBox_consent = new System.Windows.Forms.CheckBox();
            this.label_favartist = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_openNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_favartist
            // 
            this.textBox_favartist.Location = new System.Drawing.Point(190, 122);
            this.textBox_favartist.Name = "textBox_favartist";
            this.textBox_favartist.Size = new System.Drawing.Size(100, 26);
            this.textBox_favartist.TabIndex = 13;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(190, 67);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 26);
            this.textBox_name.TabIndex = 12;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(38, 235);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(107, 32);
            this.button_submit.TabIndex = 11;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // checkBox_consent
            // 
            this.checkBox_consent.AutoSize = true;
            this.checkBox_consent.Location = new System.Drawing.Point(38, 170);
            this.checkBox_consent.Name = "checkBox_consent";
            this.checkBox_consent.Size = new System.Drawing.Size(271, 24);
            this.checkBox_consent.TabIndex = 10;
            this.checkBox_consent.Text = "All the content I put above is true!";
            this.checkBox_consent.UseVisualStyleBackColor = true;
            this.checkBox_consent.CheckedChanged += new System.EventHandler(this.checkBox_consent_CheckedChanged);
            // 
            // label_favartist
            // 
            this.label_favartist.AutoSize = true;
            this.label_favartist.Location = new System.Drawing.Point(38, 122);
            this.label_favartist.Name = "label_favartist";
            this.label_favartist.Size = new System.Drawing.Size(107, 20);
            this.label_favartist.TabIndex = 9;
            this.label_favartist.Text = "Favorite Artist";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(38, 73);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name";
            // 
            // button_openNext
            // 
            this.button_openNext.Location = new System.Drawing.Point(38, 303);
            this.button_openNext.Name = "button_openNext";
            this.button_openNext.Size = new System.Drawing.Size(180, 40);
            this.button_openNext.TabIndex = 7;
            this.button_openNext.Text = "Open Next Form";
            this.button_openNext.UseVisualStyleBackColor = true;
            this.button_openNext.Click += new System.EventHandler(this.button_openNext_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_favartist);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_consent);
            this.Controls.Add(this.label_favartist);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_openNext);
            this.Name = "Form_main";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_favartist;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.CheckBox checkBox_consent;
        private System.Windows.Forms.Label label_favartist;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_openNext;
    }
}

