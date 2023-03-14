namespace RPG_Project
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnRPG = new System.Windows.Forms.Button();
            this.btnSairPrincipal = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRPG
            // 
            this.btnRPG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRPG.FlatAppearance.BorderSize = 0;
            this.btnRPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPG.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPG.ForeColor = System.Drawing.Color.Silver;
            this.btnRPG.Location = new System.Drawing.Point(1058, 378);
            this.btnRPG.Margin = new System.Windows.Forms.Padding(0);
            this.btnRPG.Name = "btnRPG";
            this.btnRPG.Size = new System.Drawing.Size(153, 51);
            this.btnRPG.TabIndex = 0;
            this.btnRPG.Text = "Jogar";
            this.btnRPG.UseVisualStyleBackColor = false;
            this.btnRPG.Click += new System.EventHandler(this.btnRPG_Click);
            // 
            // btnSairPrincipal
            // 
            this.btnSairPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSairPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairPrincipal.FlatAppearance.BorderSize = 0;
            this.btnSairPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairPrincipal.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold);
            this.btnSairPrincipal.ForeColor = System.Drawing.Color.Silver;
            this.btnSairPrincipal.Location = new System.Drawing.Point(1058, 506);
            this.btnSairPrincipal.Name = "btnSairPrincipal";
            this.btnSairPrincipal.Size = new System.Drawing.Size(153, 52);
            this.btnSairPrincipal.TabIndex = 1;
            this.btnSairPrincipal.Text = "Sair";
            this.btnSairPrincipal.UseVisualStyleBackColor = false;
            this.btnSairPrincipal.Click += new System.EventHandler(this.btnSairPrincipal_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Harrington", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(860, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 76);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "RPG PROJECT";
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold);
            this.btnSobre.ForeColor = System.Drawing.Color.Silver;
            this.btnSobre.Location = new System.Drawing.Point(1058, 448);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(153, 52);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPG_Project.Properties.Resources.vikingBackground;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSairPrincipal);
            this.Controls.Add(this.btnRPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRPG;
        private System.Windows.Forms.Button btnSairPrincipal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSobre;
    }
}