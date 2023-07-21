namespace CampusActivityManagementSystem
{
    partial class Student
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
            this.labStuName = new System.Windows.Forms.Label();
            this.labReturn = new System.Windows.Forms.Label();
            this.panelSingleInfo = new System.Windows.Forms.Panel();
            this.panelSignActivity = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderBy = new System.Windows.Forms.ComboBox();
            this.SelectUnder2 = new System.Windows.Forms.Label();
            this.SelectItem2 = new System.Windows.Forms.Label();
            this.SelectUnder1 = new System.Windows.Forms.Label();
            this.SelectItem1 = new System.Windows.Forms.Label();
            this.Flush = new System.Windows.Forms.Button();
            this.NameHint = new System.Windows.Forms.Label();
            this.Query = new System.Windows.Forms.Button();
            this.HoldEnd = new System.Windows.Forms.DateTimePicker();
            this.HoldStart = new System.Windows.Forms.DateTimePicker();
            this.QueryOrg = new System.Windows.Forms.ComboBox();
            this.QueryName = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lvSignActivity = new System.Windows.Forms.ListView();
            this.activityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orgName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.signDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.holdDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListView = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labMaj = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkShowOldPwd = new System.Windows.Forms.CheckBox();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.labCredit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelSignedActivity = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.sideBar1 = new CampusActivityManagementSystem.SideBar();
            this.panelSingleInfo.SuspendLayout();
            this.panelSignActivity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panelSignedActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.Location = new System.Drawing.Point(1098, 12);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(238, 26);
            this.labStuName.TabIndex = 1;
            this.labStuName.Text = "学生姓名";
            this.labStuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labReturn
            // 
            this.labReturn.Location = new System.Drawing.Point(1342, 12);
            this.labReturn.Name = "labReturn";
            this.labReturn.Size = new System.Drawing.Size(52, 26);
            this.labReturn.TabIndex = 2;
            this.labReturn.Text = "退出";
            this.labReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labReturn.Click += new System.EventHandler(this.labReturn_Click);
            // 
            // panelSingleInfo
            // 
            this.panelSingleInfo.Controls.Add(this.groupBox2);
            this.panelSingleInfo.Controls.Add(this.groupBox1);
            this.panelSingleInfo.Controls.Add(this.label9);
            this.panelSingleInfo.Controls.Add(this.checkShowOldPwd);
            this.panelSingleInfo.Controls.Add(this.btnUpdatePwd);
            this.panelSingleInfo.Controls.Add(this.tbPwd);
            this.panelSingleInfo.Controls.Add(this.labCredit);
            this.panelSingleInfo.Controls.Add(this.label13);
            this.panelSingleInfo.Location = new System.Drawing.Point(198, 50);
            this.panelSingleInfo.Name = "panelSingleInfo";
            this.panelSingleInfo.Size = new System.Drawing.Size(1212, 631);
            this.panelSingleInfo.TabIndex = 27;
            // 
            // panelSignActivity
            // 
            this.panelSignActivity.Controls.Add(this.label18);
            this.panelSignActivity.Controls.Add(this.label17);
            this.panelSignActivity.Controls.Add(this.label16);
            this.panelSignActivity.Controls.Add(this.label12);
            this.panelSignActivity.Controls.Add(this.label5);
            this.panelSignActivity.Controls.Add(this.OrderBy);
            this.panelSignActivity.Controls.Add(this.SelectUnder2);
            this.panelSignActivity.Controls.Add(this.SelectItem2);
            this.panelSignActivity.Controls.Add(this.SelectUnder1);
            this.panelSignActivity.Controls.Add(this.SelectItem1);
            this.panelSignActivity.Controls.Add(this.Flush);
            this.panelSignActivity.Controls.Add(this.NameHint);
            this.panelSignActivity.Controls.Add(this.Query);
            this.panelSignActivity.Controls.Add(this.HoldEnd);
            this.panelSignActivity.Controls.Add(this.HoldStart);
            this.panelSignActivity.Controls.Add(this.QueryOrg);
            this.panelSignActivity.Controls.Add(this.QueryName);
            this.panelSignActivity.Controls.Add(this.btnDown);
            this.panelSignActivity.Controls.Add(this.btnUp);
            this.panelSignActivity.Controls.Add(this.lvSignActivity);
            this.panelSignActivity.Location = new System.Drawing.Point(198, 50);
            this.panelSignActivity.Name = "panelSignActivity";
            this.panelSignActivity.Size = new System.Drawing.Size(1212, 631);
            this.panelSignActivity.TabIndex = 28;
            this.panelSignActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignActivity_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 28;
            this.label18.Text = "主办组织";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1008, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 27;
            this.label17.Text = "排序";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(537, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "举办日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(775, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "活动名称";
            // 
            // OrderBy
            // 
            this.OrderBy.FormattingEnabled = true;
            this.OrderBy.Items.AddRange(new object[] {
            "报名开始时间",
            "活动开始时间",
            "活动学分",
            "活动名称"});
            this.OrderBy.Location = new System.Drawing.Point(1051, 110);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(145, 23);
            this.OrderBy.TabIndex = 23;
            this.OrderBy.Text = "报名开始时间";
            this.OrderBy.SelectedIndexChanged += new System.EventHandler(this.OrderBy_SelectedIndexChanged);
            // 
            // SelectUnder2
            // 
            this.SelectUnder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SelectUnder2.Location = new System.Drawing.Point(158, 129);
            this.SelectUnder2.Name = "SelectUnder2";
            this.SelectUnder2.Size = new System.Drawing.Size(115, 4);
            this.SelectUnder2.TabIndex = 22;
            this.SelectUnder2.Text = " ";
            // 
            // SelectItem2
            // 
            this.SelectItem2.Location = new System.Drawing.Point(158, 100);
            this.SelectItem2.Name = "SelectItem2";
            this.SelectItem2.Size = new System.Drawing.Size(115, 23);
            this.SelectItem2.TabIndex = 21;
            this.SelectItem2.Text = "可报名";
            this.SelectItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectItem2.Click += new System.EventHandler(this.SelectItem2_Click);
            // 
            // SelectUnder1
            // 
            this.SelectUnder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SelectUnder1.Location = new System.Drawing.Point(18, 129);
            this.SelectUnder1.Name = "SelectUnder1";
            this.SelectUnder1.Size = new System.Drawing.Size(115, 4);
            this.SelectUnder1.TabIndex = 20;
            this.SelectUnder1.Text = " ";
            // 
            // SelectItem1
            // 
            this.SelectItem1.Location = new System.Drawing.Point(18, 100);
            this.SelectItem1.Name = "SelectItem1";
            this.SelectItem1.Size = new System.Drawing.Size(115, 23);
            this.SelectItem1.TabIndex = 19;
            this.SelectItem1.Text = "全部活动";
            this.SelectItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectItem1.Click += new System.EventHandler(this.SelectItem1_Click);
            // 
            // Flush
            // 
            this.Flush.Location = new System.Drawing.Point(1096, 20);
            this.Flush.Name = "Flush";
            this.Flush.Size = new System.Drawing.Size(100, 36);
            this.Flush.TabIndex = 12;
            this.Flush.Text = "重置";
            this.Flush.UseVisualStyleBackColor = true;
            this.Flush.Click += new System.EventHandler(this.Flush_Click);
            // 
            // NameHint
            // 
            this.NameHint.AutoSize = true;
            this.NameHint.BackColor = System.Drawing.Color.White;
            this.NameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.NameHint.Location = new System.Drawing.Point(95, 31);
            this.NameHint.Name = "NameHint";
            this.NameHint.Size = new System.Drawing.Size(112, 15);
            this.NameHint.TabIndex = 11;
            this.NameHint.Text = "请输入活动名称";
            this.NameHint.Click += new System.EventHandler(this.NameHint_Click);
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(990, 20);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(100, 36);
            this.Query.TabIndex = 10;
            this.Query.Text = "查询";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // HoldEnd
            // 
            this.HoldEnd.Location = new System.Drawing.Point(803, 25);
            this.HoldEnd.Name = "HoldEnd";
            this.HoldEnd.Size = new System.Drawing.Size(158, 25);
            this.HoldEnd.TabIndex = 9;
            // 
            // HoldStart
            // 
            this.HoldStart.Location = new System.Drawing.Point(610, 25);
            this.HoldStart.Name = "HoldStart";
            this.HoldStart.Size = new System.Drawing.Size(158, 25);
            this.HoldStart.TabIndex = 8;
            this.HoldStart.ValueChanged += new System.EventHandler(this.HoldStart_ValueChanged);
            // 
            // QueryOrg
            // 
            this.QueryOrg.FormattingEnabled = true;
            this.QueryOrg.Location = new System.Drawing.Point(348, 28);
            this.QueryOrg.Name = "QueryOrg";
            this.QueryOrg.Size = new System.Drawing.Size(145, 23);
            this.QueryOrg.TabIndex = 7;
            this.QueryOrg.Text = "请选择校组织";
            this.QueryOrg.Enter += new System.EventHandler(this.QueryOrg_Enter);
            // 
            // QueryName
            // 
            this.QueryName.Location = new System.Drawing.Point(91, 25);
            this.QueryName.Name = "QueryName";
            this.QueryName.Size = new System.Drawing.Size(150, 25);
            this.QueryName.TabIndex = 6;
            this.QueryName.Enter += new System.EventHandler(this.QueryName_Enter);
            this.QueryName.Leave += new System.EventHandler(this.QueryName_Leave);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1121, 581);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = ">";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1041, 581);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 30);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "<";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // lvSignActivity
            // 
            this.lvSignActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activityID,
            this.activityName,
            this.orgName,
            this.activityPlace,
            this.signDate,
            this.holdDate,
            this.activityState,
            this.credit,
            this.SignedNum,
            this.operate});
            this.lvSignActivity.HideSelection = false;
            this.lvSignActivity.Location = new System.Drawing.Point(16, 150);
            this.lvSignActivity.Name = "lvSignActivity";
            this.lvSignActivity.Size = new System.Drawing.Size(1180, 420);
            this.lvSignActivity.SmallImageList = this.imageListView;
            this.lvSignActivity.TabIndex = 1;
            this.lvSignActivity.UseCompatibleStateImageBehavior = false;
            this.lvSignActivity.View = System.Windows.Forms.View.Details;
            // 
            // activityID
            // 
            this.activityID.Text = "";
            this.activityID.Width = 0;
            // 
            // activityName
            // 
            this.activityName.Text = "活动名称";
            this.activityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activityName.Width = 120;
            // 
            // orgName
            // 
            this.orgName.Text = "主办组织";
            this.orgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orgName.Width = 93;
            // 
            // activityPlace
            // 
            this.activityPlace.Text = "活动场地";
            this.activityPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activityPlace.Width = 0;
            // 
            // signDate
            // 
            this.signDate.Text = "报名时间段";
            this.signDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signDate.Width = 143;
            // 
            // holdDate
            // 
            this.holdDate.Text = "举办时间段";
            this.holdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.holdDate.Width = 143;
            // 
            // activityState
            // 
            this.activityState.Text = "活动状态";
            this.activityState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activityState.Width = 90;
            // 
            // credit
            // 
            this.credit.Text = "学分";
            this.credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.credit.Width = 50;
            // 
            // SignedNum
            // 
            this.SignedNum.Text = "报名人数";
            this.SignedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignedNum.Width = 92;
            // 
            // operate
            // 
            this.operate.Text = "操作";
            this.operate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.operate.Width = 150;
            // 
            // imageListView
            // 
            this.imageListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListView.ImageSize = new System.Drawing.Size(1, 50);
            this.imageListView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labClass);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labName);
            this.groupBox2.Controls.Add(this.labMaj);
            this.groupBox2.Controls.Add(this.labGender);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labPhone);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(102, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 350);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "认证信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(70, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "学号:";
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Font = new System.Drawing.Font("宋体", 12F);
            this.labClass.Location = new System.Drawing.Point(405, 170);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(69, 20);
            this.labClass.TabIndex = 12;
            this.labClass.Text = "占位符";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(340, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(70, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "专业:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("宋体", 12F);
            this.labID.Location = new System.Drawing.Point(135, 70);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(69, 20);
            this.labID.TabIndex = 6;
            this.labID.Text = "占位符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(340, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 12F);
            this.labName.Location = new System.Drawing.Point(405, 70);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(69, 20);
            this.labName.TabIndex = 4;
            this.labName.Text = "占位符";
            // 
            // labMaj
            // 
            this.labMaj.AutoSize = true;
            this.labMaj.Font = new System.Drawing.Font("宋体", 12F);
            this.labMaj.Location = new System.Drawing.Point(135, 170);
            this.labMaj.Name = "labMaj";
            this.labMaj.Size = new System.Drawing.Size(69, 20);
            this.labMaj.TabIndex = 22;
            this.labMaj.Text = "占位符";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("宋体", 12F);
            this.labGender.Location = new System.Drawing.Point(135, 260);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(69, 20);
            this.labGender.TabIndex = 20;
            this.labGender.Text = "占位符";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(70, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(340, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话:";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.labPhone.Location = new System.Drawing.Point(405, 260);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(69, 20);
            this.labPhone.TabIndex = 21;
            this.labPhone.Text = "占位符";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Picture);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(814, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 353);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "认证照片";
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(19, 29);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(242, 308);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 35;
            this.Picture.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(941, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "拟获学分:";
            // 
            // checkShowOldPwd
            // 
            this.checkShowOldPwd.AutoSize = true;
            this.checkShowOldPwd.Location = new System.Drawing.Point(157, 463);
            this.checkShowOldPwd.Name = "checkShowOldPwd";
            this.checkShowOldPwd.Size = new System.Drawing.Size(89, 19);
            this.checkShowOldPwd.TabIndex = 31;
            this.checkShowOldPwd.Text = "显示密码";
            this.checkShowOldPwd.UseVisualStyleBackColor = true;
            this.checkShowOldPwd.CheckedChanged += new System.EventHandler(this.checkShowOldPwd_CheckedChanged_1);
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.Location = new System.Drawing.Point(349, 419);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Size = new System.Drawing.Size(107, 36);
            this.btnUpdatePwd.TabIndex = 7;
            this.btnUpdatePwd.Text = "修改密码";
            this.btnUpdatePwd.UseVisualStyleBackColor = true;
            this.btnUpdatePwd.Click += new System.EventHandler(this.btnUpdatePwd_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("宋体", 10F);
            this.tbPwd.Location = new System.Drawing.Point(157, 425);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.ReadOnly = true;
            this.tbPwd.Size = new System.Drawing.Size(179, 27);
            this.tbPwd.TabIndex = 14;
            // 
            // labCredit
            // 
            this.labCredit.AutoSize = true;
            this.labCredit.Font = new System.Drawing.Font("宋体", 12F);
            this.labCredit.Location = new System.Drawing.Point(1046, 472);
            this.labCredit.Name = "labCredit";
            this.labCredit.Size = new System.Drawing.Size(29, 20);
            this.labCredit.TabIndex = 23;
            this.labCredit.Text = "占";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10F);
            this.label13.Location = new System.Drawing.Point(100, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "密码:";
            // 
            // panelSignedActivity
            // 
            this.panelSignedActivity.Controls.Add(this.label14);
            this.panelSignedActivity.Location = new System.Drawing.Point(874, 15);
            this.panelSignedActivity.Name = "panelSignedActivity";
            this.panelSignedActivity.Size = new System.Drawing.Size(200, 100);
            this.panelSignedActivity.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "//已报名活动页面";
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
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.panelSignActivity);
            this.Controls.Add(this.panelSingleInfo);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.labReturn);
            this.Controls.Add(this.labStuName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panelSingleInfo.ResumeLayout(false);
            this.panelSingleInfo.PerformLayout();
            this.panelSignActivity.ResumeLayout(false);
            this.panelSignActivity.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panelSignedActivity.ResumeLayout(false);
            this.panelSignedActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labReturn;
        private SideBar sideBar1;
        private System.Windows.Forms.Panel panelSingleInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btnUpdatePwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.Panel panelSignedActivity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvSignActivity;
        private System.Windows.Forms.Panel panelSignActivity;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        public System.Windows.Forms.ColumnHeader activityID;
        public System.Windows.Forms.ColumnHeader activityName;
        public System.Windows.Forms.ColumnHeader activityPlace;
        public System.Windows.Forms.ColumnHeader orgName;
        public System.Windows.Forms.ColumnHeader credit;
        public System.Windows.Forms.ColumnHeader signDate;
        public System.Windows.Forms.ColumnHeader holdDate;
        public System.Windows.Forms.ColumnHeader SignedNum;
        public System.Windows.Forms.ColumnHeader operate;
        public System.Windows.Forms.ColumnHeader activityState;
        public System.Windows.Forms.ImageList imageListView;
        private System.Windows.Forms.CheckBox checkShowOldPwd;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.DateTimePicker HoldEnd;
        private System.Windows.Forms.DateTimePicker HoldStart;
        private System.Windows.Forms.ComboBox QueryOrg;
        private System.Windows.Forms.TextBox QueryName;
        private System.Windows.Forms.Label NameHint;
        private System.Windows.Forms.Button Flush;
        private System.Windows.Forms.Label SelectUnder2;
        private System.Windows.Forms.Label SelectItem2;
        private System.Windows.Forms.Label SelectUnder1;
        private System.Windows.Forms.Label SelectItem1;
        private System.Windows.Forms.ComboBox OrderBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}