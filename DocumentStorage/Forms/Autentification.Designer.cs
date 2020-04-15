namespace DocumentStorage.Forms
{
    partial class Autentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentification));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Layout = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lan = new System.Windows.Forms.ToolStripStatusLabel();
            this.maskedTB = new System.Windows.Forms.MaskedTextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Layout,
            this.Lan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 148);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Layout
            // 
            this.Layout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Layout.ForeColor = System.Drawing.Color.GhostWhite;
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(243, 17);
            this.Layout.Text = "Выбранная раскладка клавиатуры:  ";
            // 
            // Lan
            // 
            this.Lan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lan.ForeColor = System.Drawing.Color.GhostWhite;
            this.Lan.Name = "Lan";
            this.Lan.Size = new System.Drawing.Size(0, 17);
            // 
            // maskedTB
            // 
            this.maskedTB.Location = new System.Drawing.Point(125, 79);
            this.maskedTB.Name = "maskedTB";
            this.maskedTB.Size = new System.Drawing.Size(192, 20);
            this.maskedTB.TabIndex = 8;
            this.maskedTB.UseSystemPasswordChar = true;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbLogin.Location = new System.Drawing.Point(30, 34);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(51, 14);
            this.lbLogin.TabIndex = 10;
            this.lbLogin.Text = "Логин:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(125, 32);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(192, 20);
            this.tbLogin.TabIndex = 11;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbPass.Location = new System.Drawing.Point(30, 81);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(54, 14);
            this.lbPass.TabIndex = 12;
            this.lbPass.Text = "Пароль";
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.Image = global::DocumentStorage.Properties.Resources.стрелка;
            this.btNext.Location = new System.Drawing.Point(326, 72);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(30, 30);
            this.btNext.TabIndex = 13;
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Autentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::DocumentStorage.Properties.Resources.фон_для_авторизации;
            this.ClientSize = new System.Drawing.Size(370, 170);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maskedTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentification";
            this.Load += new System.EventHandler(this.Autentification_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Autentification_InputLanguageChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Layout;
        private System.Windows.Forms.ToolStripStatusLabel Lan;
        private System.Windows.Forms.MaskedTextBox maskedTB;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btNext;
    }
}