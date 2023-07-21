namespace CampusActivityManagementSystem
{
    partial class Login
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
            this.labUser = new System.Windows.Forms.Label();
            this.laPwd = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radStu = new System.Windows.Forms.RadioButton();
            this.radOrg = new System.Windows.Forms.RadioButton();
            this.radSch = new System.Windows.Forms.RadioButton();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnIde = new System.Windows.Forms.Button();
            this.btnExitSys = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(186, 77);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(52, 15);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "账号：";
            // 
            // laPwd
            // 
            this.laPwd.AutoSize = true;
            this.laPwd.Location = new System.Drawing.Point(186, 121);
            this.laPwd.Name = "laPwd";
            this.laPwd.Size = new System.Drawing.Size(52, 15);
            this.laPwd.TabIndex = 1;
            this.laPwd.Text = "密码：";
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(273, 74);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(183, 25);
            this.tbxUser.TabIndex = 2;
            this.tbxUser.Text = "7020000000";
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(273, 118);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '*';
            this.tbxPwd.Size = new System.Drawing.Size(183, 25);
            this.tbxPwd.TabIndex = 3;
            this.tbxPwd.Text = "123456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radStu);
            this.groupBox1.Controls.Add(this.radOrg);
            this.groupBox1.Controls.Add(this.radSch);
            this.groupBox1.Location = new System.Drawing.Point(162, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录方式";
            // 
            // radStu
            // 
            this.radStu.AutoSize = true;
            this.radStu.Location = new System.Drawing.Point(225, 45);
            this.radStu.Name = "radStu";
            this.radStu.Size = new System.Drawing.Size(58, 19);
            this.radStu.TabIndex = 2;
            this.radStu.TabStop = true;
            this.radStu.Text = "学生";
            this.radStu.UseVisualStyleBackColor = true;
            // 
            // radOrg
            // 
            this.radOrg.AutoSize = true;
            this.radOrg.Location = new System.Drawing.Point(135, 45);
            this.radOrg.Name = "radOrg";
            this.radOrg.Size = new System.Drawing.Size(58, 19);
            this.radOrg.TabIndex = 1;
            this.radOrg.TabStop = true;
            this.radOrg.Text = "组织";
            this.radOrg.UseVisualStyleBackColor = true;
            // 
            // radSch
            // 
            this.radSch.AutoSize = true;
            this.radSch.Location = new System.Drawing.Point(39, 45);
            this.radSch.Name = "radSch";
            this.radSch.Size = new System.Drawing.Size(58, 19);
            this.radSch.TabIndex = 0;
            this.radSch.TabStop = true;
            this.radSch.Text = "校方";
            this.radSch.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(201, 292);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(92, 39);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "登录";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnIde
            // 
            this.btnIde.Location = new System.Drawing.Point(364, 292);
            this.btnIde.Name = "btnIde";
            this.btnIde.Size = new System.Drawing.Size(92, 39);
            this.btnIde.TabIndex = 6;
            this.btnIde.Text = "学生认证";
            this.btnIde.UseVisualStyleBackColor = true;
            this.btnIde.Click += new System.EventHandler(this.btnIde_Click);
            // 
            // btnExitSys
            // 
            this.btnExitSys.Location = new System.Drawing.Point(528, 413);
            this.btnExitSys.Name = "btnExitSys";
            this.btnExitSys.Size = new System.Drawing.Size(92, 39);
            this.btnExitSys.TabIndex = 8;
            this.btnExitSys.Text = "退出系统";
            this.btnExitSys.UseVisualStyleBackColor = true;
            this.btnExitSys.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 473);
            this.Controls.Add(this.btnExitSys);
            this.Controls.Add(this.btnIde);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.laPwd);
            this.Controls.Add(this.labUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label laPwd;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radStu;
        private System.Windows.Forms.RadioButton radOrg;
        private System.Windows.Forms.RadioButton radSch;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnIde;
        private System.Windows.Forms.Button btnExitSys;
    }
}