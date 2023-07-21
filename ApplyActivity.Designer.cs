
namespace CampusActivityManagementSystem
{
    partial class ApplyActivity
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
            this.AName = new System.Windows.Forms.TextBox();
            this.Intro = new System.Windows.Forms.TextBox();
            this.Place = new System.Windows.Forms.ComboBox();
            this.HoldDate = new System.Windows.Forms.DateTimePicker();
            this.SignStart = new System.Windows.Forms.DateTimePicker();
            this.SignEnd = new System.Windows.Forms.DateTimePicker();
            this.Volume = new System.Windows.Forms.NumericUpDown();
            this.Credit = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.NameCount = new System.Windows.Forms.Label();
            this.IntroCount = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.HintName = new System.Windows.Forms.Label();
            this.HintIntro = new System.Windows.Forms.Label();
            this.HoldStart = new System.Windows.Forms.ComboBox();
            this.HoldEnd = new System.Windows.Forms.ComboBox();
            this.HintLabelSign = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelIntro = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelHold = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelVolume = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelPlace = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelCredit = new CampusActivityManagementSystem.HintLabel();
            this.HintLabelName = new CampusActivityManagementSystem.HintLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).BeginInit();
            this.SuspendLayout();
            // 
            // AName
            // 
            this.AName.Location = new System.Drawing.Point(165, 92);
            this.AName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(214, 21);
            this.AName.TabIndex = 7;
            this.AName.TextChanged += new System.EventHandler(this.AName_TextChanged);
            this.AName.Enter += new System.EventHandler(this.AName_Enter);
            this.AName.Leave += new System.EventHandler(this.AName_Leave);
            // 
            // Intro
            // 
            this.Intro.Location = new System.Drawing.Point(165, 144);
            this.Intro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Intro.Multiline = true;
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(214, 129);
            this.Intro.TabIndex = 10;
            this.Intro.TextChanged += new System.EventHandler(this.Intro_TextChanged);
            this.Intro.Enter += new System.EventHandler(this.Intro_Enter);
            this.Intro.Leave += new System.EventHandler(this.Intro_Leave);
            // 
            // Place
            // 
            this.Place.FormattingEnabled = true;
            this.Place.Items.AddRange(new object[] {
            "明德楼211"});
            this.Place.Location = new System.Drawing.Point(165, 302);
            this.Place.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(166, 20);
            this.Place.TabIndex = 17;
            this.Place.Text = "请选择举办地点";
            this.Place.SelectionChangeCommitted += new System.EventHandler(this.Place_SelectionChangeCommitted);
            this.Place.Enter += new System.EventHandler(this.Place_Enter);
            // 
            // HoldDate
            // 
            this.HoldDate.Location = new System.Drawing.Point(165, 352);
            this.HoldDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoldDate.Name = "HoldDate";
            this.HoldDate.Size = new System.Drawing.Size(124, 21);
            this.HoldDate.TabIndex = 18;
            this.HoldDate.ValueChanged += new System.EventHandler(this.HoldDate_ValueChanged);
            this.HoldDate.Leave += new System.EventHandler(this.HoldDate_Leave);
            // 
            // SignStart
            // 
            this.SignStart.Location = new System.Drawing.Point(165, 404);
            this.SignStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignStart.Name = "SignStart";
            this.SignStart.Size = new System.Drawing.Size(124, 21);
            this.SignStart.TabIndex = 20;
            this.SignStart.Leave += new System.EventHandler(this.HoldDate_Leave);
            // 
            // SignEnd
            // 
            this.SignEnd.Location = new System.Drawing.Point(305, 404);
            this.SignEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignEnd.Name = "SignEnd";
            this.SignEnd.Size = new System.Drawing.Size(124, 21);
            this.SignEnd.TabIndex = 21;
            this.SignEnd.Leave += new System.EventHandler(this.HoldDate_Leave);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(165, 456);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(50, 21);
            this.Volume.TabIndex = 22;
            this.Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(165, 508);
            this.Credit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Credit.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(50, 21);
            this.Credit.TabIndex = 23;
            this.Credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(305, 582);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(58, 36);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(9, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(468, 80);
            this.Title.TabIndex = 26;
            this.Title.Text = "活动申请";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // NameCount
            // 
            this.NameCount.AutoSize = true;
            this.NameCount.Location = new System.Drawing.Point(387, 100);
            this.NameCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameCount.Name = "NameCount";
            this.NameCount.Size = new System.Drawing.Size(29, 12);
            this.NameCount.TabIndex = 27;
            this.NameCount.Text = "0/15";
            // 
            // IntroCount
            // 
            this.IntroCount.AutoSize = true;
            this.IntroCount.Location = new System.Drawing.Point(389, 259);
            this.IntroCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntroCount.Name = "IntroCount";
            this.IntroCount.Size = new System.Drawing.Size(35, 12);
            this.IntroCount.TabIndex = 28;
            this.IntroCount.Text = "0/200";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(165, 582);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(70, 36);
            this.SubmitButton.TabIndex = 29;
            this.SubmitButton.Text = "提交审核";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HintName
            // 
            this.HintName.AutoSize = true;
            this.HintName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.HintName.Location = new System.Drawing.Point(167, 96);
            this.HintName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HintName.Name = "HintName";
            this.HintName.Size = new System.Drawing.Size(89, 12);
            this.HintName.TabIndex = 30;
            this.HintName.Text = "请输入活动名称";
            this.HintName.Click += new System.EventHandler(this.HintName_Click);
            // 
            // HintIntro
            // 
            this.HintIntro.AutoSize = true;
            this.HintIntro.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.HintIntro.Location = new System.Drawing.Point(167, 148);
            this.HintIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HintIntro.Name = "HintIntro";
            this.HintIntro.Size = new System.Drawing.Size(167, 12);
            this.HintIntro.TabIndex = 31;
            this.HintIntro.Text = "请输入活动说明，不超过200字";
            this.HintIntro.Click += new System.EventHandler(this.HintIntro_Click);
            // 
            // HoldStart
            // 
            this.HoldStart.Enabled = false;
            this.HoldStart.FormattingEnabled = true;
            this.HoldStart.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00"});
            this.HoldStart.Location = new System.Drawing.Point(305, 354);
            this.HoldStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoldStart.Name = "HoldStart";
            this.HoldStart.Size = new System.Drawing.Size(60, 20);
            this.HoldStart.TabIndex = 32;
            this.HoldStart.Text = "开始";
            this.HoldStart.SelectionChangeCommitted += new System.EventHandler(this.HoldStart_SelectionChangeCommitted);
            this.HoldStart.Enter += new System.EventHandler(this.HoldStart_Enter);
            // 
            // HoldEnd
            // 
            this.HoldEnd.Enabled = false;
            this.HoldEnd.FormattingEnabled = true;
            this.HoldEnd.Items.AddRange(new object[] {
            "22:00"});
            this.HoldEnd.Location = new System.Drawing.Point(369, 354);
            this.HoldEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoldEnd.Name = "HoldEnd";
            this.HoldEnd.Size = new System.Drawing.Size(60, 20);
            this.HoldEnd.TabIndex = 33;
            this.HoldEnd.Text = "结束";
            this.HoldEnd.Enter += new System.EventHandler(this.HoldEnd_Enter);
            // 
            // HintLabelSign
            // 
            this.HintLabelSign.Location = new System.Drawing.Point(75, 408);
            this.HintLabelSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelSign.Name = "HintLabelSign";
            this.HintLabelSign.Size = new System.Drawing.Size(86, 16);
            this.HintLabelSign.TabIndex = 16;
            // 
            // HintLabelIntro
            // 
            this.HintLabelIntro.Location = new System.Drawing.Point(75, 144);
            this.HintLabelIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelIntro.Name = "HintLabelIntro";
            this.HintLabelIntro.Size = new System.Drawing.Size(86, 16);
            this.HintLabelIntro.TabIndex = 15;
            // 
            // HintLabelHold
            // 
            this.HintLabelHold.Location = new System.Drawing.Point(75, 356);
            this.HintLabelHold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelHold.Name = "HintLabelHold";
            this.HintLabelHold.Size = new System.Drawing.Size(86, 16);
            this.HintLabelHold.TabIndex = 14;
            // 
            // HintLabelVolume
            // 
            this.HintLabelVolume.Location = new System.Drawing.Point(75, 460);
            this.HintLabelVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelVolume.Name = "HintLabelVolume";
            this.HintLabelVolume.Size = new System.Drawing.Size(86, 16);
            this.HintLabelVolume.TabIndex = 13;
            // 
            // HintLabelPlace
            // 
            this.HintLabelPlace.Location = new System.Drawing.Point(75, 304);
            this.HintLabelPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelPlace.Name = "HintLabelPlace";
            this.HintLabelPlace.Size = new System.Drawing.Size(86, 16);
            this.HintLabelPlace.TabIndex = 12;
            // 
            // HintLabelCredit
            // 
            this.HintLabelCredit.Location = new System.Drawing.Point(75, 512);
            this.HintLabelCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelCredit.Name = "HintLabelCredit";
            this.HintLabelCredit.Size = new System.Drawing.Size(86, 16);
            this.HintLabelCredit.TabIndex = 11;
            // 
            // HintLabelName
            // 
            this.HintLabelName.Location = new System.Drawing.Point(76, 96);
            this.HintLabelName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HintLabelName.Name = "HintLabelName";
            this.HintLabelName.Size = new System.Drawing.Size(86, 16);
            this.HintLabelName.TabIndex = 8;
            // 
            // ApplyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 673);
            this.Controls.Add(this.HoldEnd);
            this.Controls.Add(this.HoldStart);
            this.Controls.Add(this.HintIntro);
            this.Controls.Add(this.HintName);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IntroCount);
            this.Controls.Add(this.NameCount);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.SignEnd);
            this.Controls.Add(this.SignStart);
            this.Controls.Add(this.HoldDate);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.HintLabelSign);
            this.Controls.Add(this.HintLabelIntro);
            this.Controls.Add(this.HintLabelHold);
            this.Controls.Add(this.HintLabelVolume);
            this.Controls.Add(this.HintLabelPlace);
            this.Controls.Add(this.HintLabelCredit);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.HintLabelName);
            this.Controls.Add(this.AName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ApplyActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "活动信息填写                                         ";
            this.Load += new System.EventHandler(this.ApplyActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AName;
        private HintLabel HintLabelName;
        private System.Windows.Forms.TextBox Intro;
        private HintLabel HintLabelCredit;
        private HintLabel HintLabelPlace;
        private HintLabel HintLabelVolume;
        private HintLabel HintLabelHold;
        private HintLabel HintLabelIntro;
        private HintLabel HintLabelSign;
        private System.Windows.Forms.ComboBox Place;
        private System.Windows.Forms.DateTimePicker HoldDate;
        private System.Windows.Forms.DateTimePicker SignStart;
        private System.Windows.Forms.DateTimePicker SignEnd;
        private System.Windows.Forms.NumericUpDown Volume;
        private System.Windows.Forms.NumericUpDown Credit;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NameCount;
        private System.Windows.Forms.Label IntroCount;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label HintName;
        private System.Windows.Forms.Label HintIntro;
        private System.Windows.Forms.ComboBox HoldStart;
        private System.Windows.Forms.ComboBox HoldEnd;
    }
}