namespace CampusActivityManagementSystem
{
    partial class StudentIdentified
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radWomen = new System.Windows.Forms.RadioButton();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnIde = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(243, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生认证界面";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(190, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(283, 108);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(171, 25);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(283, 167);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 25);
            this.tbName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(190, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radWomen);
            this.groupBox1.Controls.Add(this.radMan);
            this.groupBox1.Location = new System.Drawing.Point(220, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性别";
            // 
            // radWomen
            // 
            this.radWomen.AutoSize = true;
            this.radWomen.Location = new System.Drawing.Point(135, 41);
            this.radWomen.Name = "radWomen";
            this.radWomen.Size = new System.Drawing.Size(43, 19);
            this.radWomen.TabIndex = 1;
            this.radWomen.TabStop = true;
            this.radWomen.Text = "女";
            this.radWomen.UseVisualStyleBackColor = true;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(44, 41);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(43, 19);
            this.radMan.TabIndex = 0;
            this.radMan.TabStop = true;
            this.radMan.Text = "男";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(190, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "专业：";
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Items.AddRange(new object[] {
            "计算机科学与技术",
            "软件工程",
            "互联网工程",
            "人工智能",
            "物联网技术"});
            this.cbMajor.Location = new System.Drawing.Point(283, 360);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(160, 23);
            this.cbMajor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(190, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "班级：";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "201",
            "202",
            "203",
            "204",
            "205",
            "206"});
            this.cbClass.Location = new System.Drawing.Point(283, 421);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(160, 23);
            this.cbClass.TabIndex = 9;
            // 
            // btnIde
            // 
            this.btnIde.Location = new System.Drawing.Point(220, 542);
            this.btnIde.Name = "btnIde";
            this.btnIde.Size = new System.Drawing.Size(87, 45);
            this.btnIde.TabIndex = 10;
            this.btnIde.Text = "认证";
            this.btnIde.UseVisualStyleBackColor = true;
            this.btnIde.Click += new System.EventHandler(this.btnIde_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(379, 542);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 45);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(283, 479);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(171, 25);
            this.tbPhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(190, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "电话：";
            // 
            // StudentIdentified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 614);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIde);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMajor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentIdentified";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生认证";
            this.Load += new System.EventHandler(this.StudentIdentified_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radWomen;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnIde;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
    }
}