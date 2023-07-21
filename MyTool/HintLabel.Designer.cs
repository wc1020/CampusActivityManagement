namespace CampusActivityManagementSystem
{
    partial class HintLabel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.HintIcon = new System.Windows.Forms.Label();
            this.HintText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HintIcon
            // 
            this.HintIcon.AutoSize = true;
            this.HintIcon.ForeColor = System.Drawing.Color.Red;
            this.HintIcon.Location = new System.Drawing.Point(16, 0);
            this.HintIcon.Name = "HintIcon";
            this.HintIcon.Size = new System.Drawing.Size(15, 15);
            this.HintIcon.TabIndex = 3;
            this.HintIcon.Text = "*";
            // 
            // HintText
            // 
            this.HintText.AutoSize = true;
            this.HintText.Location = new System.Drawing.Point(28, 0);
            this.HintText.Name = "HintText";
            this.HintText.Size = new System.Drawing.Size(67, 15);
            this.HintText.TabIndex = 2;
            this.HintText.Text = "活动名称";
            // 
            // HintLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HintIcon);
            this.Controls.Add(this.HintText);
            this.Name = "HintLabel";
            this.Size = new System.Drawing.Size(114, 20);
            this.Load += new System.EventHandler(this.HintLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HintIcon;
        private System.Windows.Forms.Label HintText;
    }
}
