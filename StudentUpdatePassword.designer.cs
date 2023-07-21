namespace CampusActivityManagementSystem
{
    partial class StudentUpdatePassword
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
            this.checkShowPwd2 = new System.Windows.Forms.CheckBox();
            this.checkShowPwd1 = new System.Windows.Forms.CheckBox();
            this.tbNewPwdAgain = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkShowPwd2
            // 
            this.checkShowPwd2.AutoSize = true;
            this.checkShowPwd2.Location = new System.Drawing.Point(445, 245);
            this.checkShowPwd2.Name = "checkShowPwd2";
            this.checkShowPwd2.Size = new System.Drawing.Size(89, 19);
            this.checkShowPwd2.TabIndex = 36;
            this.checkShowPwd2.Text = "显示密码";
            this.checkShowPwd2.UseVisualStyleBackColor = true;
            this.checkShowPwd2.CheckedChanged += new System.EventHandler(this.checkShowPwd2_CheckedChanged);
            // 
            // checkShowPwd1
            // 
            this.checkShowPwd1.AutoSize = true;
            this.checkShowPwd1.Location = new System.Drawing.Point(445, 154);
            this.checkShowPwd1.Name = "checkShowPwd1";
            this.checkShowPwd1.Size = new System.Drawing.Size(89, 19);
            this.checkShowPwd1.TabIndex = 35;
            this.checkShowPwd1.Text = "显示密码";
            this.checkShowPwd1.UseVisualStyleBackColor = true;
            this.checkShowPwd1.CheckedChanged += new System.EventHandler(this.checkShowPwd1_CheckedChanged);
            // 
            // tbNewPwdAgain
            // 
            this.tbNewPwdAgain.Location = new System.Drawing.Point(234, 239);
            this.tbNewPwdAgain.Name = "tbNewPwdAgain";
            this.tbNewPwdAgain.PasswordChar = '*';
            this.tbNewPwdAgain.Size = new System.Drawing.Size(179, 25);
            this.tbNewPwdAgain.TabIndex = 34;
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(234, 149);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '*';
            this.tbNewPwd.Size = new System.Drawing.Size(179, 25);
            this.tbNewPwd.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(131, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "再次新密码：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "输入新密码：";
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.Location = new System.Drawing.Point(175, 339);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Size = new System.Drawing.Size(111, 41);
            this.btnUpdatePwd.TabIndex = 37;
            this.btnUpdatePwd.Text = "修改密码";
            this.btnUpdatePwd.UseVisualStyleBackColor = true;
            this.btnUpdatePwd.Click += new System.EventHandler(this.btnUpdatePwd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(321, 339);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 41);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // StudentUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 499);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdatePwd);
            this.Controls.Add(this.checkShowPwd2);
            this.Controls.Add(this.checkShowPwd1);
            this.Controls.Add(this.tbNewPwdAgain);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentUpdatePassword";
            this.Load += new System.EventHandler(this.StudentUpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkShowPwd2;
        private System.Windows.Forms.CheckBox checkShowPwd1;
        private System.Windows.Forms.TextBox tbNewPwdAgain;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdatePwd;
        private System.Windows.Forms.Button btnReturn;
    }
}