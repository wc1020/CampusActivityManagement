namespace CampusActivityManagementSystem
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.AdminActivityView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ActivityName = new System.Windows.Forms.Label();
            this.ActivityPlace = new System.Windows.Forms.Label();
            this.QueryState = new System.Windows.Forms.ComboBox();
            this.QueryActivityName = new System.Windows.Forms.TextBox();
            this.QueryActivityPlace = new System.Windows.Forms.TextBox();
            this.QueryActivity = new System.Windows.Forms.Button();
            this.FlushActivity = new System.Windows.Forms.Button();
            this.ActivityPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PageDown1 = new System.Windows.Forms.Button();
            this.PageUp1 = new System.Windows.Forms.Button();
            this.SelectUnder2 = new System.Windows.Forms.Label();
            this.SelectItem2 = new System.Windows.Forms.Label();
            this.SelectUnder3 = new System.Windows.Forms.Label();
            this.SelectItem3 = new System.Windows.Forms.Label();
            this.SelectUnder1 = new System.Windows.Forms.Label();
            this.SelectItem1 = new System.Windows.Forms.Label();
            this.ActivityPlaceHint = new System.Windows.Forms.Label();
            this.ActivityNameHint = new System.Windows.Forms.Label();
            this.PlacePanel = new System.Windows.Forms.Panel();
            this.PageDown2 = new System.Windows.Forms.Button();
            this.PageUp2 = new System.Windows.Forms.Button();
            this.AddPlace = new System.Windows.Forms.Button();
            this.QueryPlaceNameHint = new System.Windows.Forms.Label();
            this.AdminPlaceView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlushPlace = new System.Windows.Forms.Button();
            this.QueryPlace = new System.Windows.Forms.Button();
            this.PlaceName = new System.Windows.Forms.Label();
            this.QueryPlaceName = new System.Windows.Forms.TextBox();
            this.AdminName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.sideBar1 = new CampusActivityManagementSystem.SideBar();
            this.ActivityPanel.SuspendLayout();
            this.PlacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminActivityView
            // 
            this.AdminActivityView.HideSelection = false;
            this.AdminActivityView.Location = new System.Drawing.Point(16, 150);
            this.AdminActivityView.Name = "AdminActivityView";
            this.AdminActivityView.Size = new System.Drawing.Size(1180, 420);
            this.AdminActivityView.SmallImageList = this.imageList1;
            this.AdminActivityView.TabIndex = 1;
            this.AdminActivityView.UseCompatibleStateImageBehavior = false;
            this.AdminActivityView.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSize = true;
            this.ActivityName.Location = new System.Drawing.Point(18, 31);
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Size = new System.Drawing.Size(67, 15);
            this.ActivityName.TabIndex = 2;
            this.ActivityName.Text = "活动名称";
            // 
            // ActivityPlace
            // 
            this.ActivityPlace.AutoSize = true;
            this.ActivityPlace.Location = new System.Drawing.Point(323, 31);
            this.ActivityPlace.Name = "ActivityPlace";
            this.ActivityPlace.Size = new System.Drawing.Size(67, 15);
            this.ActivityPlace.TabIndex = 3;
            this.ActivityPlace.Text = "活动场地";
            // 
            // QueryState
            // 
            this.QueryState.ForeColor = System.Drawing.Color.Black;
            this.QueryState.FormattingEnabled = true;
            this.QueryState.Items.AddRange(new object[] {
            "待审核",
            "未通过",
            "审核过期",
            "待报名",
            "报名中",
            "待开始",
            "活动中",
            "已结束",
            "已上报",
            "已完成"});
            this.QueryState.Location = new System.Drawing.Point(710, 28);
            this.QueryState.Name = "QueryState";
            this.QueryState.Size = new System.Drawing.Size(163, 23);
            this.QueryState.TabIndex = 4;
            this.QueryState.Text = "请选择活动状态";
            this.QueryState.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // QueryActivityName
            // 
            this.QueryActivityName.Location = new System.Drawing.Point(91, 24);
            this.QueryActivityName.Name = "QueryActivityName";
            this.QueryActivityName.Size = new System.Drawing.Size(160, 25);
            this.QueryActivityName.TabIndex = 5;
            this.QueryActivityName.Enter += new System.EventHandler(this.QueryActivityName_Enter);
            this.QueryActivityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryActivityPlace_KeyPress);
            this.QueryActivityName.Leave += new System.EventHandler(this.QueryActivityName_Leave);
            // 
            // QueryActivityPlace
            // 
            this.QueryActivityPlace.Location = new System.Drawing.Point(396, 24);
            this.QueryActivityPlace.Name = "QueryActivityPlace";
            this.QueryActivityPlace.Size = new System.Drawing.Size(160, 25);
            this.QueryActivityPlace.TabIndex = 6;
            this.QueryActivityPlace.TextChanged += new System.EventHandler(this.QueryActivityPlace_TextChanged);
            this.QueryActivityPlace.Enter += new System.EventHandler(this.QueryActivityPlace_Enter);
            this.QueryActivityPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryActivityPlace_KeyPress);
            this.QueryActivityPlace.Leave += new System.EventHandler(this.QueryActivityPlace_Leave);
            // 
            // QueryActivity
            // 
            this.QueryActivity.Location = new System.Drawing.Point(970, 20);
            this.QueryActivity.Name = "QueryActivity";
            this.QueryActivity.Size = new System.Drawing.Size(100, 36);
            this.QueryActivity.TabIndex = 7;
            this.QueryActivity.Text = "查询";
            this.QueryActivity.UseVisualStyleBackColor = true;
            this.QueryActivity.Click += new System.EventHandler(this.Query_Click);
            // 
            // FlushActivity
            // 
            this.FlushActivity.Location = new System.Drawing.Point(1095, 20);
            this.FlushActivity.Name = "FlushActivity";
            this.FlushActivity.Size = new System.Drawing.Size(100, 36);
            this.FlushActivity.TabIndex = 8;
            this.FlushActivity.Text = "重置";
            this.FlushActivity.UseVisualStyleBackColor = true;
            this.FlushActivity.Click += new System.EventHandler(this.Flush_Click);
            // 
            // ActivityPanel
            // 
            this.ActivityPanel.Controls.Add(this.label1);
            this.ActivityPanel.Controls.Add(this.PageDown1);
            this.ActivityPanel.Controls.Add(this.PageUp1);
            this.ActivityPanel.Controls.Add(this.SelectUnder2);
            this.ActivityPanel.Controls.Add(this.SelectItem2);
            this.ActivityPanel.Controls.Add(this.SelectUnder3);
            this.ActivityPanel.Controls.Add(this.SelectItem3);
            this.ActivityPanel.Controls.Add(this.SelectUnder1);
            this.ActivityPanel.Controls.Add(this.SelectItem1);
            this.ActivityPanel.Controls.Add(this.ActivityPlaceHint);
            this.ActivityPanel.Controls.Add(this.ActivityNameHint);
            this.ActivityPanel.Controls.Add(this.AdminActivityView);
            this.ActivityPanel.Controls.Add(this.FlushActivity);
            this.ActivityPanel.Controls.Add(this.ActivityName);
            this.ActivityPanel.Controls.Add(this.QueryActivity);
            this.ActivityPanel.Controls.Add(this.ActivityPlace);
            this.ActivityPanel.Controls.Add(this.QueryActivityPlace);
            this.ActivityPanel.Controls.Add(this.QueryState);
            this.ActivityPanel.Controls.Add(this.QueryActivityName);
            this.ActivityPanel.Location = new System.Drawing.Point(198, 50);
            this.ActivityPanel.Name = "ActivityPanel";
            this.ActivityPanel.Size = new System.Drawing.Size(1212, 623);
            this.ActivityPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "活动状态";
            // 
            // PageDown1
            // 
            this.PageDown1.Location = new System.Drawing.Point(1120, 580);
            this.PageDown1.Name = "PageDown1";
            this.PageDown1.Size = new System.Drawing.Size(75, 30);
            this.PageDown1.TabIndex = 20;
            this.PageDown1.Text = ">";
            this.PageDown1.UseVisualStyleBackColor = true;
            // 
            // PageUp1
            // 
            this.PageUp1.Location = new System.Drawing.Point(1040, 580);
            this.PageUp1.Name = "PageUp1";
            this.PageUp1.Size = new System.Drawing.Size(75, 30);
            this.PageUp1.TabIndex = 19;
            this.PageUp1.Text = "<";
            this.PageUp1.UseVisualStyleBackColor = true;
            // 
            // SelectUnder2
            // 
            this.SelectUnder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SelectUnder2.Location = new System.Drawing.Point(158, 129);
            this.SelectUnder2.Name = "SelectUnder2";
            this.SelectUnder2.Size = new System.Drawing.Size(115, 4);
            this.SelectUnder2.TabIndex = 18;
            this.SelectUnder2.Text = " ";
            // 
            // SelectItem2
            // 
            this.SelectItem2.Location = new System.Drawing.Point(158, 100);
            this.SelectItem2.Name = "SelectItem2";
            this.SelectItem2.Size = new System.Drawing.Size(115, 23);
            this.SelectItem2.TabIndex = 17;
            this.SelectItem2.Text = "全部活动";
            this.SelectItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectItem2.Click += new System.EventHandler(this.SelectItem2_Click);
            // 
            // SelectUnder3
            // 
            this.SelectUnder3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SelectUnder3.Location = new System.Drawing.Point(298, 129);
            this.SelectUnder3.Name = "SelectUnder3";
            this.SelectUnder3.Size = new System.Drawing.Size(115, 4);
            this.SelectUnder3.TabIndex = 16;
            this.SelectUnder3.Text = " ";
            // 
            // SelectItem3
            // 
            this.SelectItem3.Location = new System.Drawing.Point(298, 100);
            this.SelectItem3.Name = "SelectItem3";
            this.SelectItem3.Size = new System.Drawing.Size(115, 23);
            this.SelectItem3.TabIndex = 15;
            this.SelectItem3.Text = "全部活动";
            this.SelectItem3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectItem3.Click += new System.EventHandler(this.SelectItem3_Click);
            // 
            // SelectUnder1
            // 
            this.SelectUnder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SelectUnder1.Location = new System.Drawing.Point(18, 129);
            this.SelectUnder1.Name = "SelectUnder1";
            this.SelectUnder1.Size = new System.Drawing.Size(115, 4);
            this.SelectUnder1.TabIndex = 14;
            this.SelectUnder1.Text = " ";
            // 
            // SelectItem1
            // 
            this.SelectItem1.Location = new System.Drawing.Point(18, 100);
            this.SelectItem1.Name = "SelectItem1";
            this.SelectItem1.Size = new System.Drawing.Size(115, 23);
            this.SelectItem1.TabIndex = 13;
            this.SelectItem1.Text = "全部活动";
            this.SelectItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectItem1.Click += new System.EventHandler(this.SelectItem1_Click);
            // 
            // ActivityPlaceHint
            // 
            this.ActivityPlaceHint.AutoSize = true;
            this.ActivityPlaceHint.BackColor = System.Drawing.Color.White;
            this.ActivityPlaceHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ActivityPlaceHint.Location = new System.Drawing.Point(400, 30);
            this.ActivityPlaceHint.Name = "ActivityPlaceHint";
            this.ActivityPlaceHint.Size = new System.Drawing.Size(112, 15);
            this.ActivityPlaceHint.TabIndex = 12;
            this.ActivityPlaceHint.Text = "请输入场地名称";
            this.ActivityPlaceHint.Click += new System.EventHandler(this.ActivityPlaceHint_Click);
            // 
            // ActivityNameHint
            // 
            this.ActivityNameHint.AutoSize = true;
            this.ActivityNameHint.BackColor = System.Drawing.Color.White;
            this.ActivityNameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ActivityNameHint.Location = new System.Drawing.Point(95, 30);
            this.ActivityNameHint.Name = "ActivityNameHint";
            this.ActivityNameHint.Size = new System.Drawing.Size(112, 15);
            this.ActivityNameHint.TabIndex = 11;
            this.ActivityNameHint.Text = "请输入活动名称";
            this.ActivityNameHint.Click += new System.EventHandler(this.ActivityNameHint_Click);
            // 
            // PlacePanel
            // 
            this.PlacePanel.Controls.Add(this.PageDown2);
            this.PlacePanel.Controls.Add(this.PageUp2);
            this.PlacePanel.Controls.Add(this.AddPlace);
            this.PlacePanel.Controls.Add(this.QueryPlaceNameHint);
            this.PlacePanel.Controls.Add(this.AdminPlaceView);
            this.PlacePanel.Controls.Add(this.FlushPlace);
            this.PlacePanel.Controls.Add(this.QueryPlace);
            this.PlacePanel.Controls.Add(this.PlaceName);
            this.PlacePanel.Controls.Add(this.QueryPlaceName);
            this.PlacePanel.Location = new System.Drawing.Point(198, 50);
            this.PlacePanel.Name = "PlacePanel";
            this.PlacePanel.Size = new System.Drawing.Size(1212, 623);
            this.PlacePanel.TabIndex = 13;
            this.PlacePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlacePanel_Paint);
            // 
            // PageDown2
            // 
            this.PageDown2.Location = new System.Drawing.Point(1121, 581);
            this.PageDown2.Name = "PageDown2";
            this.PageDown2.Size = new System.Drawing.Size(75, 30);
            this.PageDown2.TabIndex = 20;
            this.PageDown2.Text = ">";
            this.PageDown2.UseVisualStyleBackColor = true;
            // 
            // PageUp2
            // 
            this.PageUp2.Location = new System.Drawing.Point(1041, 581);
            this.PageUp2.Name = "PageUp2";
            this.PageUp2.Size = new System.Drawing.Size(75, 30);
            this.PageUp2.TabIndex = 19;
            this.PageUp2.Text = "<";
            this.PageUp2.UseVisualStyleBackColor = true;
            // 
            // AddPlace
            // 
            this.AddPlace.Enabled = false;
            this.AddPlace.Location = new System.Drawing.Point(15, 80);
            this.AddPlace.Name = "AddPlace";
            this.AddPlace.Size = new System.Drawing.Size(128, 52);
            this.AddPlace.TabIndex = 13;
            this.AddPlace.Text = "+ 新增场地";
            this.AddPlace.UseVisualStyleBackColor = true;
            // 
            // QueryPlaceNameHint
            // 
            this.QueryPlaceNameHint.AutoSize = true;
            this.QueryPlaceNameHint.BackColor = System.Drawing.Color.White;
            this.QueryPlaceNameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.QueryPlaceNameHint.Location = new System.Drawing.Point(95, 32);
            this.QueryPlaceNameHint.Name = "QueryPlaceNameHint";
            this.QueryPlaceNameHint.Size = new System.Drawing.Size(112, 15);
            this.QueryPlaceNameHint.TabIndex = 12;
            this.QueryPlaceNameHint.Text = "请输入场地名称";
            this.QueryPlaceNameHint.Click += new System.EventHandler(this.QueryPlaceNameHint_Click);
            // 
            // AdminPlaceView
            // 
            this.AdminPlaceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.AdminPlaceView.HideSelection = false;
            this.AdminPlaceView.Location = new System.Drawing.Point(15, 150);
            this.AdminPlaceView.Name = "AdminPlaceView";
            this.AdminPlaceView.Size = new System.Drawing.Size(1180, 420);
            this.AdminPlaceView.SmallImageList = this.imageList1;
            this.AdminPlaceView.TabIndex = 1;
            this.AdminPlaceView.UseCompatibleStateImageBehavior = false;
            this.AdminPlaceView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "场地名称";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "可容纳人数";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "开放日期";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "开放时间";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 175;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "操作";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // FlushPlace
            // 
            this.FlushPlace.Location = new System.Drawing.Point(1095, 20);
            this.FlushPlace.Name = "FlushPlace";
            this.FlushPlace.Size = new System.Drawing.Size(100, 36);
            this.FlushPlace.TabIndex = 8;
            this.FlushPlace.Text = "重置";
            this.FlushPlace.UseVisualStyleBackColor = true;
            this.FlushPlace.Click += new System.EventHandler(this.FlushPlace_Click);
            // 
            // QueryPlace
            // 
            this.QueryPlace.Location = new System.Drawing.Point(979, 20);
            this.QueryPlace.Name = "QueryPlace";
            this.QueryPlace.Size = new System.Drawing.Size(100, 36);
            this.QueryPlace.TabIndex = 7;
            this.QueryPlace.Text = "查询";
            this.QueryPlace.UseVisualStyleBackColor = true;
            this.QueryPlace.Click += new System.EventHandler(this.QueryPlace_Click);
            // 
            // PlaceName
            // 
            this.PlaceName.AutoSize = true;
            this.PlaceName.Location = new System.Drawing.Point(18, 31);
            this.PlaceName.Name = "PlaceName";
            this.PlaceName.Size = new System.Drawing.Size(67, 15);
            this.PlaceName.TabIndex = 3;
            this.PlaceName.Text = "场地名称";
            // 
            // QueryPlaceName
            // 
            this.QueryPlaceName.Location = new System.Drawing.Point(91, 26);
            this.QueryPlaceName.Name = "QueryPlaceName";
            this.QueryPlaceName.Size = new System.Drawing.Size(160, 25);
            this.QueryPlaceName.TabIndex = 6;
            this.QueryPlaceName.Enter += new System.EventHandler(this.QueryPlaceName_Enter);
            this.QueryPlaceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QueryPlaceName_KeyPress);
            this.QueryPlaceName.Leave += new System.EventHandler(this.QueryPlaceName_Leave);
            // 
            // AdminName
            // 
            this.AdminName.Location = new System.Drawing.Point(1077, 12);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(259, 26);
            this.AdminName.TabIndex = 11;
            this.AdminName.Text = "学校管理员";
            this.AdminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1342, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 26);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "退出";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(138)))), ((int)(((byte)(179)))));
            this.sideBar1.Location = new System.Drawing.Point(12, 12);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(180, 650);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Load += new System.EventHandler(this.sideBar1_Load);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.PlacePanel);
            this.Controls.Add(this.ActivityPanel);
            this.Controls.Add(this.sideBar1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ActivityPanel.ResumeLayout(false);
            this.ActivityPanel.PerformLayout();
            this.PlacePanel.ResumeLayout(false);
            this.PlacePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.ListView AdminActivityView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label ActivityName;
        private System.Windows.Forms.Label ActivityPlace;
        private System.Windows.Forms.ComboBox QueryState;
        private System.Windows.Forms.TextBox QueryActivityName;
        private System.Windows.Forms.TextBox QueryActivityPlace;
        private System.Windows.Forms.Button QueryActivity;
        private System.Windows.Forms.Button FlushActivity;
        private System.Windows.Forms.Panel ActivityPanel;
        private System.Windows.Forms.Label AdminName;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label ActivityNameHint;
        private System.Windows.Forms.Label ActivityPlaceHint;
        private System.Windows.Forms.Panel PlacePanel;
        private System.Windows.Forms.Label QueryPlaceNameHint;
        private System.Windows.Forms.ListView AdminPlaceView;
        private System.Windows.Forms.Button FlushPlace;
        private System.Windows.Forms.Button QueryPlace;
        private System.Windows.Forms.Label PlaceName;
        private System.Windows.Forms.TextBox QueryPlaceName;
        private System.Windows.Forms.Label SelectUnder1;
        private System.Windows.Forms.Label SelectItem1;
        private System.Windows.Forms.Label SelectUnder2;
        private System.Windows.Forms.Label SelectItem2;
        private System.Windows.Forms.Label SelectUnder3;
        private System.Windows.Forms.Label SelectItem3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button AddPlace;
        private System.Windows.Forms.Button PageDown1;
        private System.Windows.Forms.Button PageUp1;
        private System.Windows.Forms.Button PageDown2;
        private System.Windows.Forms.Button PageUp2;
        private System.Windows.Forms.Label label1;
    }
}