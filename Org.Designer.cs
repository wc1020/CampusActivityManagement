namespace CampusActivityManagementSystem
{
    partial class Org
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.QueryName = new System.Windows.Forms.TextBox();
            this.Flush = new System.Windows.Forms.Button();
            this.QueryNameLabel = new System.Windows.Forms.Label();
            this.QueryDateLabel = new System.Windows.Forms.Label();
            this.Bridge = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.OrgName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.QueryDateEnd = new System.Windows.Forms.DateTimePicker();
            this.QueryDateStart = new System.Windows.Forms.DateTimePicker();
            this.QueryNameHint = new System.Windows.Forms.Label();
            this.Activities = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApplyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoldTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PageUp = new System.Windows.Forms.Button();
            this.PageDown = new System.Windows.Forms.Button();
            this.Query = new System.Windows.Forms.Button();
            this.sideBar1 = new CampusActivityManagementSystem.SideBar();
            this.SuspendLayout();
            // 
            // QueryName
            // 
            this.QueryName.Location = new System.Drawing.Point(284, 75);
            this.QueryName.Name = "QueryName";
            this.QueryName.Size = new System.Drawing.Size(160, 25);
            this.QueryName.TabIndex = 2;
            this.QueryName.Enter += new System.EventHandler(this.QueryName_Enter);
            this.QueryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryName_KeyPress);
            this.QueryName.Leave += new System.EventHandler(this.QueryName_Leave);
            // 
            // Flush
            // 
            this.Flush.Location = new System.Drawing.Point(1294, 71);
            this.Flush.Name = "Flush";
            this.Flush.Size = new System.Drawing.Size(100, 36);
            this.Flush.TabIndex = 6;
            this.Flush.Text = "重置";
            this.Flush.UseVisualStyleBackColor = true;
            this.Flush.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // QueryNameLabel
            // 
            this.QueryNameLabel.AutoSize = true;
            this.QueryNameLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryNameLabel.Location = new System.Drawing.Point(211, 80);
            this.QueryNameLabel.Name = "QueryNameLabel";
            this.QueryNameLabel.Size = new System.Drawing.Size(67, 15);
            this.QueryNameLabel.TabIndex = 7;
            this.QueryNameLabel.Text = "活动名称";
            // 
            // QueryDateLabel
            // 
            this.QueryDateLabel.AutoSize = true;
            this.QueryDateLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryDateLabel.Location = new System.Drawing.Point(490, 80);
            this.QueryDateLabel.Name = "QueryDateLabel";
            this.QueryDateLabel.Size = new System.Drawing.Size(67, 15);
            this.QueryDateLabel.TabIndex = 8;
            this.QueryDateLabel.Text = "申请日期";
            // 
            // Bridge
            // 
            this.Bridge.AutoSize = true;
            this.Bridge.Location = new System.Drawing.Point(760, 80);
            this.Bridge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Bridge.Name = "Bridge";
            this.Bridge.Size = new System.Drawing.Size(22, 15);
            this.Bridge.TabIndex = 9;
            this.Bridge.Text = "至";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApplyButton.Location = new System.Drawing.Point(214, 130);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(128, 52);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "+ 申请新活动";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // OrgName
            // 
            this.OrgName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrgName.Location = new System.Drawing.Point(1036, 12);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new System.Drawing.Size(300, 26);
            this.OrgName.TabIndex = 11;
            this.OrgName.Text = "青年志愿者协会";
            this.OrgName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Exit.Location = new System.Drawing.Point(1342, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 26);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "退出";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // QueryDateEnd
            // 
            this.QueryDateEnd.Location = new System.Drawing.Point(791, 75);
            this.QueryDateEnd.Name = "QueryDateEnd";
            this.QueryDateEnd.Size = new System.Drawing.Size(188, 25);
            this.QueryDateEnd.TabIndex = 13;
            // 
            // QueryDateStart
            // 
            this.QueryDateStart.Location = new System.Drawing.Point(563, 75);
            this.QueryDateStart.Name = "QueryDateStart";
            this.QueryDateStart.Size = new System.Drawing.Size(188, 25);
            this.QueryDateStart.TabIndex = 14;
            this.QueryDateStart.ValueChanged += new System.EventHandler(this.QueryDateStart_ValueChanged);
            // 
            // QueryNameHint
            // 
            this.QueryNameHint.AutoSize = true;
            this.QueryNameHint.BackColor = System.Drawing.Color.White;
            this.QueryNameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.QueryNameHint.Location = new System.Drawing.Point(288, 80);
            this.QueryNameHint.Name = "QueryNameHint";
            this.QueryNameHint.Size = new System.Drawing.Size(112, 15);
            this.QueryNameHint.TabIndex = 16;
            this.QueryNameHint.Text = "请输入活动名称";
            this.QueryNameHint.Click += new System.EventHandler(this.QueryNameHint_Click);
            // 
            // Activities
            // 
            this.Activities.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Activities.AutoArrange = false;
            this.Activities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.AName,
            this.ApplyTime,
            this.Place,
            this.SignTime,
            this.HoldTime,
            this.State,
            this.Volume,
            this.Operation});
            this.Activities.HideSelection = false;
            this.Activities.Location = new System.Drawing.Point(214, 200);
            this.Activities.Name = "Activities";
            this.Activities.Size = new System.Drawing.Size(1180, 420);
            this.Activities.SmallImageList = this.imageList1;
            this.Activities.TabIndex = 11;
            this.Activities.UseCompatibleStateImageBehavior = false;
            this.Activities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // AName
            // 
            this.AName.Text = "活动名称";
            this.AName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AName.Width = 120;
            // 
            // ApplyTime
            // 
            this.ApplyTime.Text = "申请时间";
            this.ApplyTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ApplyTime.Width = 90;
            // 
            // Place
            // 
            this.Place.Text = "举办地点";
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Place.Width = 90;
            // 
            // SignTime
            // 
            this.SignTime.Text = "报名时间段";
            this.SignTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignTime.Width = 150;
            // 
            // HoldTime
            // 
            this.HoldTime.Text = "举办时间段";
            this.HoldTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoldTime.Width = 150;
            // 
            // State
            // 
            this.State.Text = "活动状态";
            this.State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.State.Width = 90;
            // 
            // Volume
            // 
            this.Volume.Text = "报名人数";
            this.Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Volume.Width = 92;
            // 
            // Operation
            // 
            this.Operation.Text = "操作";
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Operation.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PageUp
            // 
            this.PageUp.Location = new System.Drawing.Point(1240, 630);
            this.PageUp.Name = "PageUp";
            this.PageUp.Size = new System.Drawing.Size(75, 30);
            this.PageUp.TabIndex = 17;
            this.PageUp.Text = "<";
            this.PageUp.UseVisualStyleBackColor = true;
            // 
            // PageDown
            // 
            this.PageDown.Location = new System.Drawing.Point(1320, 630);
            this.PageDown.Name = "PageDown";
            this.PageDown.Size = new System.Drawing.Size(75, 30);
            this.PageDown.TabIndex = 18;
            this.PageDown.Text = ">";
            this.PageDown.UseVisualStyleBackColor = true;
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(1170, 71);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(100, 36);
            this.Query.TabIndex = 19;
            this.Query.Text = "查询";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(138)))), ((int)(((byte)(179)))));
            this.sideBar1.Location = new System.Drawing.Point(12, 12);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(180, 650);
            this.sideBar1.TabIndex = 15;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load);
            // 
            // Org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.PageDown);
            this.Controls.Add(this.PageUp);
            this.Controls.Add(this.Activities);
            this.Controls.Add(this.QueryNameHint);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.QueryDateStart);
            this.Controls.Add(this.QueryDateEnd);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OrgName);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Bridge);
            this.Controls.Add(this.QueryDateLabel);
            this.Controls.Add(this.QueryNameLabel);
            this.Controls.Add(this.Flush);
            this.Controls.Add(this.QueryName);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Org";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校园活动";
            this.Load += new System.EventHandler(this.Org_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QueryName;
        private System.Windows.Forms.Button Flush;
        private System.Windows.Forms.Label QueryNameLabel;
        private System.Windows.Forms.Label QueryDateLabel;
        private System.Windows.Forms.Label Bridge;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label OrgName;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.DateTimePicker QueryDateEnd;
        private System.Windows.Forms.DateTimePicker QueryDateStart;
        private SideBar sideBar1;
        private System.Windows.Forms.Label QueryNameHint;
        private System.Windows.Forms.ListView Activities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader AName;
        private System.Windows.Forms.ColumnHeader ApplyTime;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader SignTime;
        private System.Windows.Forms.ColumnHeader HoldTime;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ColumnHeader Operation;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button PageUp;
        private System.Windows.Forms.Button PageDown;
        private System.Windows.Forms.Button Query;
    }
}

