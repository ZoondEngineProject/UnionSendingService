namespace UnionSendingService
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SendingTab = new System.Windows.Forms.TabPage();
            this.SendingIPAddrLabel = new System.Windows.Forms.Label();
            this.SendingIPAddrBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValueSendFileNameLabel = new System.Windows.Forms.Label();
            this.TextSendFileNameLabel = new System.Windows.Forms.Label();
            this.ValueSendingResultLabel = new System.Windows.Forms.Label();
            this.TextSendingResultLabel = new System.Windows.Forms.Label();
            this.ValueSendingStatusLabel = new System.Windows.Forms.Label();
            this.TextSendingStatusLabel = new System.Windows.Forms.Label();
            this.ValueSizeFileLabel = new System.Windows.Forms.Label();
            this.TextSizeFileLabel = new System.Windows.Forms.Label();
            this.ValueConnectionStatusLabel = new System.Windows.Forms.Label();
            this.TextConnectionStatusLabel = new System.Windows.Forms.Label();
            this.SendningJournalLabel = new System.Windows.Forms.Label();
            this.SendingTextBox = new System.Windows.Forms.RichTextBox();
            this.SendAcceptBtn = new System.Windows.Forms.Button();
            this.SendSwitchBtn = new System.Windows.Forms.Button();
            this.ReceiveTab = new System.Windows.Forms.TabPage();
            this.DisableConnBtn = new System.Windows.Forms.Button();
            this.EnableConnBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValueReceiveResultLabel = new System.Windows.Forms.Label();
            this.TextReceiveResultLabel = new System.Windows.Forms.Label();
            this.ValueReceiveStatusLabel = new System.Windows.Forms.Label();
            this.TextReceiveStatusLabel = new System.Windows.Forms.Label();
            this.ValueReceiveSizeFileLabel = new System.Windows.Forms.Label();
            this.TextReceiveSizeFileLabel = new System.Windows.Forms.Label();
            this.ValueReceiveConnectionStatusLabel = new System.Windows.Forms.Label();
            this.TextReceiveConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ReceiveJournalLabel = new System.Windows.Forms.Label();
            this.ReceiveTextBox = new System.Windows.Forms.RichTextBox();
            this.AuthorLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SendingAbortBtn = new System.Windows.Forms.PictureBox();
            this.SendPreloader = new System.Windows.Forms.PictureBox();
            this.ReceivePreloader = new System.Windows.Forms.PictureBox();
            this.основныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправленоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полученоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрешенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SendingTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ReceiveTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendingAbortBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendPreloader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceivePreloader)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основныеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SendingTab);
            this.tabControl1.Controls.Add(this.ReceiveTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 333);
            this.tabControl1.TabIndex = 3;
            // 
            // SendingTab
            // 
            this.SendingTab.Controls.Add(this.SendingIPAddrLabel);
            this.SendingTab.Controls.Add(this.SendingIPAddrBox);
            this.SendingTab.Controls.Add(this.groupBox1);
            this.SendingTab.Controls.Add(this.SendningJournalLabel);
            this.SendingTab.Controls.Add(this.SendingTextBox);
            this.SendingTab.Controls.Add(this.SendAcceptBtn);
            this.SendingTab.Controls.Add(this.SendSwitchBtn);
            this.SendingTab.Location = new System.Drawing.Point(4, 22);
            this.SendingTab.Name = "SendingTab";
            this.SendingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SendingTab.Size = new System.Drawing.Size(592, 307);
            this.SendingTab.TabIndex = 0;
            this.SendingTab.Text = "Отправка";
            this.SendingTab.UseVisualStyleBackColor = true;
            // 
            // SendingIPAddrLabel
            // 
            this.SendingIPAddrLabel.AutoSize = true;
            this.SendingIPAddrLabel.Location = new System.Drawing.Point(15, 240);
            this.SendingIPAddrLabel.Name = "SendingIPAddrLabel";
            this.SendingIPAddrLabel.Size = new System.Drawing.Size(57, 13);
            this.SendingIPAddrLabel.TabIndex = 7;
            this.SendingIPAddrLabel.Text = "IP Адрес: ";
            // 
            // SendingIPAddrBox
            // 
            this.SendingIPAddrBox.Location = new System.Drawing.Point(78, 237);
            this.SendingIPAddrBox.Name = "SendingIPAddrBox";
            this.SendingIPAddrBox.Size = new System.Drawing.Size(243, 20);
            this.SendingIPAddrBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SendingAbortBtn);
            this.groupBox1.Controls.Add(this.SendPreloader);
            this.groupBox1.Controls.Add(this.ValueSendFileNameLabel);
            this.groupBox1.Controls.Add(this.TextSendFileNameLabel);
            this.groupBox1.Controls.Add(this.ValueSendingResultLabel);
            this.groupBox1.Controls.Add(this.TextSendingResultLabel);
            this.groupBox1.Controls.Add(this.ValueSendingStatusLabel);
            this.groupBox1.Controls.Add(this.TextSendingStatusLabel);
            this.groupBox1.Controls.Add(this.ValueSizeFileLabel);
            this.groupBox1.Controls.Add(this.TextSizeFileLabel);
            this.groupBox1.Controls.Add(this.ValueConnectionStatusLabel);
            this.groupBox1.Controls.Add(this.TextConnectionStatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(327, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состояние:";
            // 
            // ValueSendFileNameLabel
            // 
            this.ValueSendFileNameLabel.AutoSize = true;
            this.ValueSendFileNameLabel.Location = new System.Drawing.Point(79, 20);
            this.ValueSendFileNameLabel.Name = "ValueSendFileNameLabel";
            this.ValueSendFileNameLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueSendFileNameLabel.TabIndex = 9;
            this.ValueSendFileNameLabel.Text = "null";
            // 
            // TextSendFileNameLabel
            // 
            this.TextSendFileNameLabel.AutoSize = true;
            this.TextSendFileNameLabel.Location = new System.Drawing.Point(8, 20);
            this.TextSendFileNameLabel.Name = "TextSendFileNameLabel";
            this.TextSendFileNameLabel.Size = new System.Drawing.Size(70, 13);
            this.TextSendFileNameLabel.TabIndex = 8;
            this.TextSendFileNameLabel.Text = "Имя файла: ";
            // 
            // ValueSendingResultLabel
            // 
            this.ValueSendingResultLabel.AutoSize = true;
            this.ValueSendingResultLabel.Location = new System.Drawing.Point(79, 259);
            this.ValueSendingResultLabel.Name = "ValueSendingResultLabel";
            this.ValueSendingResultLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueSendingResultLabel.TabIndex = 7;
            this.ValueSendingResultLabel.Text = "null";
            // 
            // TextSendingResultLabel
            // 
            this.TextSendingResultLabel.AutoSize = true;
            this.TextSendingResultLabel.Location = new System.Drawing.Point(8, 259);
            this.TextSendingResultLabel.Name = "TextSendingResultLabel";
            this.TextSendingResultLabel.Size = new System.Drawing.Size(65, 13);
            this.TextSendingResultLabel.TabIndex = 6;
            this.TextSendingResultLabel.Text = "Результат: ";
            // 
            // ValueSendingStatusLabel
            // 
            this.ValueSendingStatusLabel.AutoSize = true;
            this.ValueSendingStatusLabel.Location = new System.Drawing.Point(79, 96);
            this.ValueSendingStatusLabel.Name = "ValueSendingStatusLabel";
            this.ValueSendingStatusLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueSendingStatusLabel.TabIndex = 5;
            this.ValueSendingStatusLabel.Text = "null";
            // 
            // TextSendingStatusLabel
            // 
            this.TextSendingStatusLabel.AutoSize = true;
            this.TextSendingStatusLabel.Location = new System.Drawing.Point(8, 96);
            this.TextSendingStatusLabel.Name = "TextSendingStatusLabel";
            this.TextSendingStatusLabel.Size = new System.Drawing.Size(74, 13);
            this.TextSendingStatusLabel.TabIndex = 4;
            this.TextSendingStatusLabel.Text = "Отправлено: ";
            // 
            // ValueSizeFileLabel
            // 
            this.ValueSizeFileLabel.AutoSize = true;
            this.ValueSizeFileLabel.Location = new System.Drawing.Point(61, 70);
            this.ValueSizeFileLabel.Name = "ValueSizeFileLabel";
            this.ValueSizeFileLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueSizeFileLabel.TabIndex = 3;
            this.ValueSizeFileLabel.Text = "null";
            // 
            // TextSizeFileLabel
            // 
            this.TextSizeFileLabel.AutoSize = true;
            this.TextSizeFileLabel.Location = new System.Drawing.Point(8, 70);
            this.TextSizeFileLabel.Name = "TextSizeFileLabel";
            this.TextSizeFileLabel.Size = new System.Drawing.Size(52, 13);
            this.TextSizeFileLabel.TabIndex = 2;
            this.TextSizeFileLabel.Text = "Размер: ";
            // 
            // ValueConnectionStatusLabel
            // 
            this.ValueConnectionStatusLabel.AutoSize = true;
            this.ValueConnectionStatusLabel.Location = new System.Drawing.Point(90, 44);
            this.ValueConnectionStatusLabel.Name = "ValueConnectionStatusLabel";
            this.ValueConnectionStatusLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueConnectionStatusLabel.TabIndex = 1;
            this.ValueConnectionStatusLabel.Text = "null";
            // 
            // TextConnectionStatusLabel
            // 
            this.TextConnectionStatusLabel.AutoSize = true;
            this.TextConnectionStatusLabel.Location = new System.Drawing.Point(8, 44);
            this.TextConnectionStatusLabel.Name = "TextConnectionStatusLabel";
            this.TextConnectionStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.TextConnectionStatusLabel.TabIndex = 0;
            this.TextConnectionStatusLabel.Text = "Подключение: ";
            // 
            // SendningJournalLabel
            // 
            this.SendningJournalLabel.AutoSize = true;
            this.SendningJournalLabel.Location = new System.Drawing.Point(15, 10);
            this.SendningJournalLabel.Name = "SendningJournalLabel";
            this.SendningJournalLabel.Size = new System.Drawing.Size(50, 13);
            this.SendningJournalLabel.TabIndex = 4;
            this.SendningJournalLabel.Text = "Журнал:";
            // 
            // SendingTextBox
            // 
            this.SendingTextBox.Location = new System.Drawing.Point(13, 30);
            this.SendingTextBox.Name = "SendingTextBox";
            this.SendingTextBox.Size = new System.Drawing.Size(308, 201);
            this.SendingTextBox.TabIndex = 3;
            this.SendingTextBox.Text = "";
            // 
            // SendAcceptBtn
            // 
            this.SendAcceptBtn.Location = new System.Drawing.Point(174, 269);
            this.SendAcceptBtn.Name = "SendAcceptBtn";
            this.SendAcceptBtn.Size = new System.Drawing.Size(147, 27);
            this.SendAcceptBtn.TabIndex = 1;
            this.SendAcceptBtn.Text = "Отправить";
            this.SendAcceptBtn.UseVisualStyleBackColor = true;
            this.SendAcceptBtn.Click += new System.EventHandler(this.SendAcceptBtn_Click);
            // 
            // SendSwitchBtn
            // 
            this.SendSwitchBtn.Location = new System.Drawing.Point(11, 269);
            this.SendSwitchBtn.Name = "SendSwitchBtn";
            this.SendSwitchBtn.Size = new System.Drawing.Size(157, 27);
            this.SendSwitchBtn.TabIndex = 0;
            this.SendSwitchBtn.Text = "Выбрать...";
            this.SendSwitchBtn.UseVisualStyleBackColor = true;
            this.SendSwitchBtn.Click += new System.EventHandler(this.SendSwitchBtn_Click);
            // 
            // ReceiveTab
            // 
            this.ReceiveTab.Controls.Add(this.DisableConnBtn);
            this.ReceiveTab.Controls.Add(this.EnableConnBtn);
            this.ReceiveTab.Controls.Add(this.groupBox2);
            this.ReceiveTab.Controls.Add(this.ReceiveJournalLabel);
            this.ReceiveTab.Controls.Add(this.ReceiveTextBox);
            this.ReceiveTab.Location = new System.Drawing.Point(4, 22);
            this.ReceiveTab.Name = "ReceiveTab";
            this.ReceiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiveTab.Size = new System.Drawing.Size(592, 307);
            this.ReceiveTab.TabIndex = 1;
            this.ReceiveTab.Text = "Получение";
            this.ReceiveTab.UseVisualStyleBackColor = true;
            // 
            // DisableConnBtn
            // 
            this.DisableConnBtn.Location = new System.Drawing.Point(105, 270);
            this.DisableConnBtn.Name = "DisableConnBtn";
            this.DisableConnBtn.Size = new System.Drawing.Size(93, 31);
            this.DisableConnBtn.TabIndex = 10;
            this.DisableConnBtn.Text = "Выкл.";
            this.DisableConnBtn.UseVisualStyleBackColor = true;
            this.DisableConnBtn.Click += new System.EventHandler(this.DisableConnBtn_Click);
            // 
            // EnableConnBtn
            // 
            this.EnableConnBtn.Location = new System.Drawing.Point(6, 270);
            this.EnableConnBtn.Name = "EnableConnBtn";
            this.EnableConnBtn.Size = new System.Drawing.Size(93, 31);
            this.EnableConnBtn.TabIndex = 9;
            this.EnableConnBtn.Text = "Вкл.";
            this.EnableConnBtn.UseVisualStyleBackColor = true;
            this.EnableConnBtn.Click += new System.EventHandler(this.EnableConnBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReceivePreloader);
            this.groupBox2.Controls.Add(this.ValueReceiveResultLabel);
            this.groupBox2.Controls.Add(this.TextReceiveResultLabel);
            this.groupBox2.Controls.Add(this.ValueReceiveStatusLabel);
            this.groupBox2.Controls.Add(this.TextReceiveStatusLabel);
            this.groupBox2.Controls.Add(this.ValueReceiveSizeFileLabel);
            this.groupBox2.Controls.Add(this.TextReceiveSizeFileLabel);
            this.groupBox2.Controls.Add(this.ValueReceiveConnectionStatusLabel);
            this.groupBox2.Controls.Add(this.TextReceiveConnectionStatusLabel);
            this.groupBox2.Location = new System.Drawing.Point(337, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 247);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состояние:";
            // 
            // ValueReceiveResultLabel
            // 
            this.ValueReceiveResultLabel.AutoSize = true;
            this.ValueReceiveResultLabel.Location = new System.Drawing.Point(67, 208);
            this.ValueReceiveResultLabel.Name = "ValueReceiveResultLabel";
            this.ValueReceiveResultLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueReceiveResultLabel.TabIndex = 7;
            this.ValueReceiveResultLabel.Text = "null";
            // 
            // TextReceiveResultLabel
            // 
            this.TextReceiveResultLabel.AutoSize = true;
            this.TextReceiveResultLabel.Location = new System.Drawing.Point(8, 208);
            this.TextReceiveResultLabel.Name = "TextReceiveResultLabel";
            this.TextReceiveResultLabel.Size = new System.Drawing.Size(65, 13);
            this.TextReceiveResultLabel.TabIndex = 6;
            this.TextReceiveResultLabel.Text = "Результат: ";
            // 
            // ValueReceiveStatusLabel
            // 
            this.ValueReceiveStatusLabel.AutoSize = true;
            this.ValueReceiveStatusLabel.Location = new System.Drawing.Point(79, 80);
            this.ValueReceiveStatusLabel.Name = "ValueReceiveStatusLabel";
            this.ValueReceiveStatusLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueReceiveStatusLabel.TabIndex = 5;
            this.ValueReceiveStatusLabel.Text = "null";
            // 
            // TextReceiveStatusLabel
            // 
            this.TextReceiveStatusLabel.AutoSize = true;
            this.TextReceiveStatusLabel.Location = new System.Drawing.Point(8, 80);
            this.TextReceiveStatusLabel.Name = "TextReceiveStatusLabel";
            this.TextReceiveStatusLabel.Size = new System.Drawing.Size(61, 13);
            this.TextReceiveStatusLabel.TabIndex = 4;
            this.TextReceiveStatusLabel.Text = "Получено: ";
            // 
            // ValueReceiveSizeFileLabel
            // 
            this.ValueReceiveSizeFileLabel.AutoSize = true;
            this.ValueReceiveSizeFileLabel.Location = new System.Drawing.Point(61, 54);
            this.ValueReceiveSizeFileLabel.Name = "ValueReceiveSizeFileLabel";
            this.ValueReceiveSizeFileLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueReceiveSizeFileLabel.TabIndex = 3;
            this.ValueReceiveSizeFileLabel.Text = "null";
            // 
            // TextReceiveSizeFileLabel
            // 
            this.TextReceiveSizeFileLabel.AutoSize = true;
            this.TextReceiveSizeFileLabel.Location = new System.Drawing.Point(8, 54);
            this.TextReceiveSizeFileLabel.Name = "TextReceiveSizeFileLabel";
            this.TextReceiveSizeFileLabel.Size = new System.Drawing.Size(52, 13);
            this.TextReceiveSizeFileLabel.TabIndex = 2;
            this.TextReceiveSizeFileLabel.Text = "Размер: ";
            // 
            // ValueReceiveConnectionStatusLabel
            // 
            this.ValueReceiveConnectionStatusLabel.AutoSize = true;
            this.ValueReceiveConnectionStatusLabel.Location = new System.Drawing.Point(90, 28);
            this.ValueReceiveConnectionStatusLabel.Name = "ValueReceiveConnectionStatusLabel";
            this.ValueReceiveConnectionStatusLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueReceiveConnectionStatusLabel.TabIndex = 1;
            this.ValueReceiveConnectionStatusLabel.Text = "null";
            // 
            // TextReceiveConnectionStatusLabel
            // 
            this.TextReceiveConnectionStatusLabel.AutoSize = true;
            this.TextReceiveConnectionStatusLabel.Location = new System.Drawing.Point(8, 28);
            this.TextReceiveConnectionStatusLabel.Name = "TextReceiveConnectionStatusLabel";
            this.TextReceiveConnectionStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.TextReceiveConnectionStatusLabel.TabIndex = 0;
            this.TextReceiveConnectionStatusLabel.Text = "Подключение: ";
            // 
            // ReceiveJournalLabel
            // 
            this.ReceiveJournalLabel.AutoSize = true;
            this.ReceiveJournalLabel.Location = new System.Drawing.Point(8, 7);
            this.ReceiveJournalLabel.Name = "ReceiveJournalLabel";
            this.ReceiveJournalLabel.Size = new System.Drawing.Size(50, 13);
            this.ReceiveJournalLabel.TabIndex = 7;
            this.ReceiveJournalLabel.Text = "Журнал:";
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(6, 27);
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(325, 227);
            this.ReceiveTextBox.TabIndex = 6;
            this.ReceiveTextBox.Text = "";
            // 
            // AuthorLink
            // 
            this.AuthorLink.AutoSize = true;
            this.AuthorLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AuthorLink.Location = new System.Drawing.Point(13, 370);
            this.AuthorLink.Name = "AuthorLink";
            this.AuthorLink.Size = new System.Drawing.Size(171, 13);
            this.AuthorLink.TabIndex = 4;
            this.AuthorLink.TabStop = true;
            this.AuthorLink.Text = "ZELab, 2017. All Rights Reserved.";
            this.AuthorLink.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(539, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "v 1.0.43.978a";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            // 
            // SendingAbortBtn
            // 
            this.SendingAbortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendingAbortBtn.Image = global::UnionSendingService.Properties.Resources.cancel;
            this.SendingAbortBtn.Location = new System.Drawing.Point(233, 264);
            this.SendingAbortBtn.Name = "SendingAbortBtn";
            this.SendingAbortBtn.Size = new System.Drawing.Size(19, 22);
            this.SendingAbortBtn.TabIndex = 11;
            this.SendingAbortBtn.TabStop = false;
            this.SendingAbortBtn.Visible = false;
            this.SendingAbortBtn.Click += new System.EventHandler(this.SendingAbortBtn_Click);
            // 
            // SendPreloader
            // 
            this.SendPreloader.Image = global::UnionSendingService.Properties.Resources.preloader;
            this.SendPreloader.Location = new System.Drawing.Point(93, 149);
            this.SendPreloader.Name = "SendPreloader";
            this.SendPreloader.Size = new System.Drawing.Size(72, 72);
            this.SendPreloader.TabIndex = 10;
            this.SendPreloader.TabStop = false;
            // 
            // ReceivePreloader
            // 
            this.ReceivePreloader.Image = global::UnionSendingService.Properties.Resources.preloader;
            this.ReceivePreloader.Location = new System.Drawing.Point(93, 119);
            this.ReceivePreloader.Name = "ReceivePreloader";
            this.ReceivePreloader.Size = new System.Drawing.Size(72, 72);
            this.ReceivePreloader.TabIndex = 11;
            this.ReceivePreloader.TabStop = false;
            // 
            // основныеToolStripMenuItem
            // 
            this.основныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаToolStripMenuItem,
            this.разрешенияToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.основныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("основныеToolStripMenuItem.Image")));
            this.основныеToolStripMenuItem.Name = "основныеToolStripMenuItem";
            this.основныеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.основныеToolStripMenuItem.Text = "Основные";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправленоToolStripMenuItem,
            this.полученоToolStripMenuItem});
            this.статистикаToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.chart_line;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // отправленоToolStripMenuItem
            // 
            this.отправленоToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.arrow_up;
            this.отправленоToolStripMenuItem.Name = "отправленоToolStripMenuItem";
            this.отправленоToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.отправленоToolStripMenuItem.Text = "Отправлено";
            // 
            // полученоToolStripMenuItem
            // 
            this.полученоToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.arrow_down;
            this.полученоToolStripMenuItem.Name = "полученоToolStripMenuItem";
            this.полученоToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.полученоToolStripMenuItem.Text = "Получено";
            // 
            // разрешенияToolStripMenuItem
            // 
            this.разрешенияToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.bullet_key;
            this.разрешенияToolStripMenuItem.Name = "разрешенияToolStripMenuItem";
            this.разрешенияToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.разрешенияToolStripMenuItem.Text = "Разрешения";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправкаToolStripMenuItem,
            this.получениеToolStripMenuItem,
            this.соединениеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.cog;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // отправкаToolStripMenuItem
            // 
            this.отправкаToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.arrow_up;
            this.отправкаToolStripMenuItem.Name = "отправкаToolStripMenuItem";
            this.отправкаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.отправкаToolStripMenuItem.Text = "Отправка";
            // 
            // получениеToolStripMenuItem
            // 
            this.получениеToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.arrow_down;
            this.получениеToolStripMenuItem.Name = "получениеToolStripMenuItem";
            this.получениеToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.получениеToolStripMenuItem.Text = "Получение";
            // 
            // соединениеToolStripMenuItem
            // 
            this.соединениеToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.arrow_switch;
            this.соединениеToolStripMenuItem.Name = "соединениеToolStripMenuItem";
            this.соединениеToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.соединениеToolStripMenuItem.Text = "Соединение";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::UnionSendingService.Properties.Resources.bullet_blue;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 392);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.AuthorLink);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "USS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.SendingTab.ResumeLayout(false);
            this.SendingTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ReceiveTab.ResumeLayout(false);
            this.ReceiveTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendingAbortBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendPreloader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceivePreloader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправленоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полученоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрешенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединениеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SendingTab;
        private System.Windows.Forms.TabPage ReceiveTab;
        private System.Windows.Forms.LinkLabel AuthorLink;
        private System.Windows.Forms.Label SendingIPAddrLabel;
        private System.Windows.Forms.TextBox SendingIPAddrBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SendningJournalLabel;
        private System.Windows.Forms.RichTextBox SendingTextBox;
        private System.Windows.Forms.Button SendAcceptBtn;
        private System.Windows.Forms.Button SendSwitchBtn;
        private System.Windows.Forms.Label ValueSendingResultLabel;
        private System.Windows.Forms.Label TextSendingResultLabel;
        private System.Windows.Forms.Label ValueSendingStatusLabel;
        private System.Windows.Forms.Label TextSendingStatusLabel;
        private System.Windows.Forms.Label ValueSizeFileLabel;
        private System.Windows.Forms.Label TextSizeFileLabel;
        private System.Windows.Forms.Label ValueConnectionStatusLabel;
        private System.Windows.Forms.Label TextConnectionStatusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TextReceiveResultLabel;
        private System.Windows.Forms.Label TextReceiveStatusLabel;
        private System.Windows.Forms.Label TextReceiveSizeFileLabel;
        private System.Windows.Forms.Label TextReceiveConnectionStatusLabel;
        private System.Windows.Forms.Label ReceiveJournalLabel;
        private System.Windows.Forms.RichTextBox ReceiveTextBox;
        private System.Windows.Forms.Button DisableConnBtn;
        private System.Windows.Forms.Button EnableConnBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ValueSendFileNameLabel;
        private System.Windows.Forms.Label TextSendFileNameLabel;
        private System.Windows.Forms.PictureBox SendPreloader;
        private System.Windows.Forms.PictureBox ReceivePreloader;
        private System.Windows.Forms.PictureBox SendingAbortBtn;
        public System.Windows.Forms.Label ValueReceiveResultLabel;
        public System.Windows.Forms.Label ValueReceiveStatusLabel;
        public System.Windows.Forms.Label ValueReceiveSizeFileLabel;
        public System.Windows.Forms.Label ValueReceiveConnectionStatusLabel;
    }
}

