namespace Multilingual_Translation
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
            txtSource = new TextBox();
            cmbLang = new ComboBox();
            btnTranslate = new Button();
            txtTarget = new TextBox();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Location = new Point(10, 45);
            txtSource.Multiline = true;
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(200, 100);
            txtSource.TabIndex = 0;
            // 
            // cmbLang
            // 
            cmbLang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLang.FormattingEnabled = true;
            cmbLang.Items.AddRange(new object[] { "English", "Deutsch", "Français", "Español" });
            cmbLang.Location = new Point(10, 10);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(200, 29);
            cmbLang.TabIndex = 1;
            // 
            // btnTranslate
            // 
            btnTranslate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTranslate.Location = new Point(220, 10);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(200, 29);
            btnTranslate.TabIndex = 2;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(220, 45);
            txtTarget.Multiline = true;
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(200, 100);
            txtTarget.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 156);
            Controls.Add(txtTarget);
            Controls.Add(btnTranslate);
            Controls.Add(cmbLang);
            Controls.Add(txtSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSource;
        private ComboBox cmbLang;
        private Button btnTranslate;
        private TextBox txtTarget;
    }
}
