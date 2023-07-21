namespace CampusActivityManagementSystem
{
    partial class VerifyActivity
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
            this.Pass = new System.Windows.Forms.RadioButton();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Fail = new System.Windows.Forms.RadioButton();
            this.Reason = new System.Windows.Forms.TextBox();
            this.ReasonHint = new System.Windows.Forms.Label();
            this.ReasonLabel = new CampusActivityManagementSystem.HintLabel();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ReasonCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(213, 52);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(88, 19);
            this.Pass.TabIndex = 0;
            this.Pass.TabStop = true;
            this.Pass.Text = "审核通过";
            this.Pass.UseVisualStyleBackColor = true;
            this.Pass.CheckedChanged += new System.EventHandler(this.Pass_CheckedChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(115, 54);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(82, 15);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "审核意见：";
            // 
            // Fail
            // 
            this.Fail.AutoSize = true;
            this.Fail.Location = new System.Drawing.Point(325, 52);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(103, 19);
            this.Fail.TabIndex = 2;
            this.Fail.TabStop = true;
            this.Fail.Text = "审核不通过";
            this.Fail.UseVisualStyleBackColor = true;
            this.Fail.CheckedChanged += new System.EventHandler(this.Fail_CheckedChanged);
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(213, 100);
            this.Reason.Multiline = true;
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(215, 38);
            this.Reason.TabIndex = 5;
            this.Reason.TextChanged += new System.EventHandler(this.Reason_TextChanged);
            this.Reason.Enter += new System.EventHandler(this.Reason_Enter);
            this.Reason.Leave += new System.EventHandler(this.Reason_Leave);
            // 
            // ReasonHint
            // 
            this.ReasonHint.AutoSize = true;
            this.ReasonHint.BackColor = System.Drawing.Color.White;
            this.ReasonHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReasonHint.Location = new System.Drawing.Point(217, 105);
            this.ReasonHint.Name = "ReasonHint";
            this.ReasonHint.Size = new System.Drawing.Size(181, 15);
            this.ReasonHint.TabIndex = 6;
            this.ReasonHint.Text = "请输入审核不通过原因...";
            this.ReasonHint.Click += new System.EventHandler(this.ReasonHint_Click);
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.Location = new System.Drawing.Point(69, 100);
            this.ReasonLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(127, 23);
            this.ReasonLabel.TabIndex = 4;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(260, 166);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 32);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(353, 166);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 32);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "返回";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ReasonCount
            // 
            this.ReasonCount.AutoSize = true;
            this.ReasonCount.Location = new System.Drawing.Point(434, 123);
            this.ReasonCount.Name = "ReasonCount";
            this.ReasonCount.Size = new System.Drawing.Size(39, 15);
            this.ReasonCount.TabIndex = 9;
            this.ReasonCount.Text = "0/25";
            // 
            // VerifyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 233);
            this.Controls.Add(this.ReasonCount);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ReasonHint);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VerifyActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "活动审核";
            this.Load += new System.EventHandler(this.VerifyActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Pass;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RadioButton Fail;
        private HintLabel ReasonLabel;
        private System.Windows.Forms.TextBox Reason;
        private System.Windows.Forms.Label ReasonHint;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label ReasonCount;
    }
}