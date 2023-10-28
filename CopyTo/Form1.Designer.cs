namespace CopyTo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_from = new System.Windows.Forms.TextBox();
            this.txtbox_to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filefrom = new System.Windows.Forms.Button();
            this.btn_fileto = new System.Windows.Forms.Button();
            this.Loading_Bar = new System.Windows.Forms.ProgressBar();
            this.btn_suspend = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // txtbox_from
            // 
            this.txtbox_from.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_from.Location = new System.Drawing.Point(27, 49);
            this.txtbox_from.Name = "txtbox_from";
            this.txtbox_from.Size = new System.Drawing.Size(430, 27);
            this.txtbox_from.TabIndex = 1;
            // 
            // txtbox_to
            // 
            this.txtbox_to.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_to.Location = new System.Drawing.Point(27, 113);
            this.txtbox_to.Name = "txtbox_to";
            this.txtbox_to.Size = new System.Drawing.Size(430, 27);
            this.txtbox_to.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // btn_filefrom
            // 
            this.btn_filefrom.BackColor = System.Drawing.Color.Silver;
            this.btn_filefrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filefrom.Location = new System.Drawing.Point(486, 49);
            this.btn_filefrom.Name = "btn_filefrom";
            this.btn_filefrom.Size = new System.Drawing.Size(75, 29);
            this.btn_filefrom.TabIndex = 4;
            this.btn_filefrom.Text = "File...";
            this.btn_filefrom.UseVisualStyleBackColor = false;
            this.btn_filefrom.Click += new System.EventHandler(this.btn_filefrom_Click);
            // 
            // btn_fileto
            // 
            this.btn_fileto.BackColor = System.Drawing.Color.Silver;
            this.btn_fileto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fileto.Location = new System.Drawing.Point(486, 113);
            this.btn_fileto.Name = "btn_fileto";
            this.btn_fileto.Size = new System.Drawing.Size(75, 29);
            this.btn_fileto.TabIndex = 5;
            this.btn_fileto.Text = "File...";
            this.btn_fileto.UseVisualStyleBackColor = false;
            this.btn_fileto.Click += new System.EventHandler(this.btn_fileto_Click);
            // 
            // Loading_Bar
            // 
            this.Loading_Bar.Location = new System.Drawing.Point(27, 178);
            this.Loading_Bar.Name = "Loading_Bar";
            this.Loading_Bar.Size = new System.Drawing.Size(212, 29);
            this.Loading_Bar.TabIndex = 6;
            // 
            // btn_suspend
            // 
            this.btn_suspend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_suspend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspend.ForeColor = System.Drawing.Color.White;
            this.btn_suspend.Location = new System.Drawing.Point(245, 178);
            this.btn_suspend.Name = "btn_suspend";
            this.btn_suspend.Size = new System.Drawing.Size(90, 29);
            this.btn_suspend.TabIndex = 7;
            this.btn_suspend.Text = "Suspend";
            this.btn_suspend.UseVisualStyleBackColor = false;
            this.btn_suspend.Click += new System.EventHandler(this.btn_suspend_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resume.Location = new System.Drawing.Point(341, 178);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(83, 29);
            this.btn_resume.TabIndex = 8;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            // 
            // btn_abort
            // 
            this.btn_abort.BackColor = System.Drawing.Color.Tomato;
            this.btn_abort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_abort.Location = new System.Drawing.Point(430, 178);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(75, 29);
            this.btn_abort.TabIndex = 9;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = false;
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.LightGreen;
            this.btn_copy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(511, 178);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 29);
            this.btn_copy.TabIndex = 10;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 250);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_suspend);
            this.Controls.Add(this.Loading_Bar);
            this.Controls.Add(this.btn_fileto);
            this.Controls.Add(this.btn_filefrom);
            this.Controls.Add(this.txtbox_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_from);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CopyTo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_from;
        private System.Windows.Forms.TextBox txtbox_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filefrom;
        private System.Windows.Forms.Button btn_fileto;
        private System.Windows.Forms.ProgressBar Loading_Bar;
        private System.Windows.Forms.Button btn_suspend;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Button btn_copy;
    }
}

