namespace CampusActivityManagementSystem
{
    partial class SideBar
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
            this.SideTitle = new System.Windows.Forms.Label();
            this.SideItem2 = new System.Windows.Forms.Label();
            this.SideItem1 = new System.Windows.Forms.Label();
            this.SideItem5 = new System.Windows.Forms.Label();
            this.SideItem4 = new System.Windows.Forms.Label();
            this.SideItem3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SideTitle
            // 
            this.SideTitle.Font = new System.Drawing.Font("霞鹜文楷", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideTitle.Location = new System.Drawing.Point(0, 0);
            this.SideTitle.Name = "SideTitle";
            this.SideTitle.Size = new System.Drawing.Size(180, 88);
            this.SideTitle.TabIndex = 0;
            this.SideTitle.Text = "校生通";
            this.SideTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideItem2
            // 
            this.SideItem2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItem2.Location = new System.Drawing.Point(0, 140);
            this.SideItem2.Name = "SideItem2";
            this.SideItem2.Size = new System.Drawing.Size(180, 52);
            this.SideItem2.TabIndex = 1;
            this.SideItem2.Text = "校园活动管理系统";
            this.SideItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideItem2.Click += new System.EventHandler(this.SideItem2_Click);
            // 
            // SideItem1
            // 
            this.SideItem1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItem1.Location = new System.Drawing.Point(0, 88);
            this.SideItem1.Name = "SideItem1";
            this.SideItem1.Size = new System.Drawing.Size(180, 52);
            this.SideItem1.TabIndex = 2;
            this.SideItem1.Text = "已申请活动";
            this.SideItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideItem1.Click += new System.EventHandler(this.SideItem1_Click);
            // 
            // SideItem5
            // 
            this.SideItem5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItem5.Location = new System.Drawing.Point(0, 296);
            this.SideItem5.Name = "SideItem5";
            this.SideItem5.Size = new System.Drawing.Size(180, 52);
            this.SideItem5.TabIndex = 3;
            this.SideItem5.Text = "校园活动管理系统";
            this.SideItem5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideItem5.Click += new System.EventHandler(this.SideItem5_Click);
            // 
            // SideItem4
            // 
            this.SideItem4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItem4.Location = new System.Drawing.Point(0, 244);
            this.SideItem4.Name = "SideItem4";
            this.SideItem4.Size = new System.Drawing.Size(180, 52);
            this.SideItem4.TabIndex = 4;
            this.SideItem4.Text = "校园活动管理系统";
            this.SideItem4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideItem4.Click += new System.EventHandler(this.SideItem4_Click);
            // 
            // SideItem3
            // 
            this.SideItem3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SideItem3.Location = new System.Drawing.Point(0, 192);
            this.SideItem3.Name = "SideItem3";
            this.SideItem3.Size = new System.Drawing.Size(180, 52);
            this.SideItem3.TabIndex = 5;
            this.SideItem3.Text = "校园活动管理系统";
            this.SideItem3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideItem3.Click += new System.EventHandler(this.SideItem3_Click);
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SideItem3);
            this.Controls.Add(this.SideItem4);
            this.Controls.Add(this.SideItem5);
            this.Controls.Add(this.SideItem1);
            this.Controls.Add(this.SideItem2);
            this.Controls.Add(this.SideTitle);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(180, 650);
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SideTitle;
        private System.Windows.Forms.Label SideItem2;
        private System.Windows.Forms.Label SideItem1;
        private System.Windows.Forms.Label SideItem5;
        private System.Windows.Forms.Label SideItem4;
        private System.Windows.Forms.Label SideItem3;
    }
}
