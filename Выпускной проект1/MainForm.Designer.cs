namespace Выпускной_проект1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTimeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCoureUsdEur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.Месяц = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSaveAsCSV = new System.Windows.Forms.Button();
            this.itogPayment = new System.Windows.Forms.TextBox();
            this.itogOverpayment = new System.Windows.Forms.TextBox();
            this.itogSum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.butSumGo = new System.Windows.Forms.Button();
            this.butSumClear = new System.Windows.Forms.Button();
            this.sumDiffer = new System.Windows.Forms.RadioButton();
            this.sumAnnuitet = new System.Windows.Forms.RadioButton();
            this.sumPeriodCombo = new System.Windows.Forms.ComboBox();
            this.sumPeriod = new System.Windows.Forms.NumericUpDown();
            this.sumProcent = new System.Windows.Forms.NumericUpDown();
            this.sumCreditSum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTipPaymentType = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumProcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumCreditSum)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTSMI});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.менюToolStripMenuItem.Text = "Файл";
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(108, 22);
            this.exitTSMI.Text = "Выход";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTimeTSMI,
            this.toolStripMenuItem1,
            this.saveTSMI,
            this.loadTSMI});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // insertTimeTSMI
            // 
            this.insertTimeTSMI.Name = "insertTimeTSMI";
            this.insertTimeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.insertTimeTSMI.Size = new System.Drawing.Size(268, 22);
            this.insertTimeTSMI.Text = "Вставить дату и время";
            this.insertTimeTSMI.Click += new System.EventHandler(this.insertTimeTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveTSMI.Size = new System.Drawing.Size(268, 22);
            this.saveTSMI.Text = "Сохранить";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // loadTSMI
            // 
            this.loadTSMI.Name = "loadTSMI";
            this.loadTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.loadTSMI.Size = new System.Drawing.Size(268, 22);
            this.loadTSMI.Text = "Загрузить";
            this.loadTSMI.Click += new System.EventHandler(this.loadTSMI_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTSMI1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // aboutTSMI1
            // 
            this.aboutTSMI1.Name = "aboutTSMI1";
            this.aboutTSMI1.Size = new System.Drawing.Size(149, 22);
            this.aboutTSMI1.Text = "О программе";
            this.aboutTSMI1.Click += new System.EventHandler(this.aboutTSMI1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 443);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCoureUsdEur);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Конвертер валют";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCoureUsdEur
            // 
            this.btnCoureUsdEur.Location = new System.Drawing.Point(395, 46);
            this.btnCoureUsdEur.Name = "btnCoureUsdEur";
            this.btnCoureUsdEur.Size = new System.Drawing.Size(143, 134);
            this.btnCoureUsdEur.TabIndex = 10;
            this.btnCoureUsdEur.Text = "Хочешь узнать актуальный курс самых популярных валют? Жми!";
            this.btnCoureUsdEur.UseVisualStyleBackColor = true;
            this.btnCoureUsdEur.Click += new System.EventHandler(this.btnCoureUsdEur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "перевести в -------->";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR",
            "GBR",
            "UAH"});
            this.listBox2.Location = new System.Drawing.Point(294, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(32, 69);
            this.listBox2.TabIndex = 8;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 186);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(552, 208);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://google", System.UriKind.Absolute);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перевод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR",
            "GBR",
            "UAH"});
            this.listBox1.Location = new System.Drawing.Point(93, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(32, 69);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "из";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.butSumGo);
            this.tabPage3.Controls.Add(this.butSumClear);
            this.tabPage3.Controls.Add(this.sumDiffer);
            this.tabPage3.Controls.Add(this.sumAnnuitet);
            this.tabPage3.Controls.Add(this.sumPeriodCombo);
            this.tabPage3.Controls.Add(this.sumPeriod);
            this.tabPage3.Controls.Add(this.sumProcent);
            this.tabPage3.Controls.Add(this.sumCreditSum);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(566, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Кредитный калькулятор";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGrafik);
            this.groupBox2.Location = new System.Drawing.Point(11, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 209);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "График платежей";
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Месяц,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGrafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrafik.Location = new System.Drawing.Point(3, 16);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.Size = new System.Drawing.Size(543, 190);
            this.dgvGrafik.TabIndex = 0;
            this.dgvGrafik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrafik_CellContentClick);
            // 
            // Месяц
            // 
            this.Месяц.FillWeight = 50F;
            this.Месяц.HeaderText = "Месяц";
            this.Месяц.Name = "Месяц";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Сумма платежа";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Платеж по основному долгу, руб.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Платеж по процентам, руб.";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Остаток основного долга, руб.";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSaveAsCSV);
            this.groupBox1.Controls.Add(this.itogPayment);
            this.groupBox1.Controls.Add(this.itogOverpayment);
            this.groupBox1.Controls.Add(this.itogSum);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(283, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты расчетов";
            // 
            // butSaveAsCSV
            // 
            this.butSaveAsCSV.Location = new System.Drawing.Point(9, 159);
            this.butSaveAsCSV.Name = "butSaveAsCSV";
            this.butSaveAsCSV.Size = new System.Drawing.Size(166, 29);
            this.butSaveAsCSV.TabIndex = 9;
            this.butSaveAsCSV.Text = "Экспорт расчетов в .CSV";
            this.butSaveAsCSV.UseVisualStyleBackColor = true;
            this.butSaveAsCSV.Click += new System.EventHandler(this.butSaveAsCSV_Click);
            // 
            // itogPayment
            // 
            this.itogPayment.Location = new System.Drawing.Point(9, 127);
            this.itogPayment.Name = "itogPayment";
            this.itogPayment.ReadOnly = true;
            this.itogPayment.Size = new System.Drawing.Size(166, 20);
            this.itogPayment.TabIndex = 8;
            // 
            // itogOverpayment
            // 
            this.itogOverpayment.Location = new System.Drawing.Point(9, 83);
            this.itogOverpayment.Name = "itogOverpayment";
            this.itogOverpayment.ReadOnly = true;
            this.itogOverpayment.Size = new System.Drawing.Size(166, 20);
            this.itogOverpayment.TabIndex = 7;
            // 
            // itogSum
            // 
            this.itogSum.Location = new System.Drawing.Point(9, 35);
            this.itogSum.Name = "itogSum";
            this.itogSum.ReadOnly = true;
            this.itogSum.Size = new System.Drawing.Size(166, 20);
            this.itogSum.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(181, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "руб.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "руб.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "руб.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ежемесечный платеж:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Переплата по кредиту:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Итоговая стоимость:";
            // 
            // butSumGo
            // 
            this.butSumGo.Location = new System.Drawing.Point(141, 159);
            this.butSumGo.Name = "butSumGo";
            this.butSumGo.Size = new System.Drawing.Size(106, 34);
            this.butSumGo.TabIndex = 13;
            this.butSumGo.Text = "Рассчитать стоимость";
            this.butSumGo.UseVisualStyleBackColor = true;
            this.butSumGo.Click += new System.EventHandler(this.butSumGo_Click);
            // 
            // butSumClear
            // 
            this.butSumClear.Location = new System.Drawing.Point(11, 159);
            this.butSumClear.Name = "butSumClear";
            this.butSumClear.Size = new System.Drawing.Size(106, 34);
            this.butSumClear.TabIndex = 12;
            this.butSumClear.Text = "Очистить расчеты";
            this.butSumClear.UseVisualStyleBackColor = true;
            this.butSumClear.Click += new System.EventHandler(this.butSumClear_Click);
            // 
            // sumDiffer
            // 
            this.sumDiffer.AutoSize = true;
            this.sumDiffer.Location = new System.Drawing.Point(89, 127);
            this.sumDiffer.Name = "sumDiffer";
            this.sumDiffer.Size = new System.Drawing.Size(142, 17);
            this.sumDiffer.TabIndex = 11;
            this.sumDiffer.TabStop = true;
            this.sumDiffer.Text = "Дифференцированный";
            this.toolTipPaymentType.SetToolTip(this.sumDiffer, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа по пог" +
        "ашению кредита постепенно уменьшается к концу периода кредитования");
            this.sumDiffer.UseVisualStyleBackColor = true;
            // 
            // sumAnnuitet
            // 
            this.sumAnnuitet.AutoSize = true;
            this.sumAnnuitet.Location = new System.Drawing.Point(89, 104);
            this.sumAnnuitet.Name = "sumAnnuitet";
            this.sumAnnuitet.Size = new System.Drawing.Size(91, 17);
            this.sumAnnuitet.TabIndex = 10;
            this.sumAnnuitet.TabStop = true;
            this.sumAnnuitet.Text = "Аннуитетный";
            this.toolTipPaymentType.SetToolTip(this.sumAnnuitet, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа остаёт" +
        "ся постоянным на всём периоде кредитования.");
            this.sumAnnuitet.UseVisualStyleBackColor = true;
            // 
            // sumPeriodCombo
            // 
            this.sumPeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sumPeriodCombo.FormattingEnabled = true;
            this.sumPeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.sumPeriodCombo.Location = new System.Drawing.Point(186, 75);
            this.sumPeriodCombo.Name = "sumPeriodCombo";
            this.sumPeriodCombo.Size = new System.Drawing.Size(57, 21);
            this.sumPeriodCombo.TabIndex = 9;
            // 
            // sumPeriod
            // 
            this.sumPeriod.Location = new System.Drawing.Point(127, 76);
            this.sumPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumPeriod.Name = "sumPeriod";
            this.sumPeriod.Size = new System.Drawing.Size(53, 20);
            this.sumPeriod.TabIndex = 8;
            this.sumPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sumProcent
            // 
            this.sumProcent.DecimalPlaces = 2;
            this.sumProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sumProcent.Location = new System.Drawing.Point(127, 47);
            this.sumProcent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumProcent.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.sumProcent.Name = "sumProcent";
            this.sumProcent.Size = new System.Drawing.Size(53, 20);
            this.sumProcent.TabIndex = 7;
            this.sumProcent.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // sumCreditSum
            // 
            this.sumCreditSum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCreditSum.Location = new System.Drawing.Point(127, 18);
            this.sumCreditSum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.sumCreditSum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCreditSum.Name = "sumCreditSum";
            this.sumCreditSum.Size = new System.Drawing.Size(120, 20);
            this.sumCreditSum.TabIndex = 6;
            this.sumCreditSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "руб";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Вид платежа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Срок платежа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Процентная ставка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Сумма кредита:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "% годовых";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Блокнот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(560, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Программы на С#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumProcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumCreditSum)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTimeTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem loadTSMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox sumPeriodCombo;
        private System.Windows.Forms.NumericUpDown sumPeriod;
        private System.Windows.Forms.NumericUpDown sumProcent;
        private System.Windows.Forms.NumericUpDown sumCreditSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSumGo;
        private System.Windows.Forms.Button butSumClear;
        private System.Windows.Forms.RadioButton sumDiffer;
        private System.Windows.Forms.ToolTip toolTipPaymentType;
        private System.Windows.Forms.RadioButton sumAnnuitet;
        protected System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Месяц;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button butSaveAsCSV;
        private System.Windows.Forms.TextBox itogPayment;
        private System.Windows.Forms.TextBox itogOverpayment;
        private System.Windows.Forms.TextBox itogSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCoureUsdEur;
    }
}