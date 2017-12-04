namespace cyclicCode
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Heading1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Heading2 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.oneButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.polynomStepenLabel = new System.Windows.Forms.Label();
            this.tripleErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.doubleErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.kInfoLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.lzeroLabel = new System.Windows.Forms.Label();
            this.polynomLength = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generatingPolynomListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1029, 561);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Heading1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1021, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Начало";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 437);
            this.label1.TabIndex = 32;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Heading1
            // 
            this.Heading1.AutoSize = true;
            this.Heading1.BackColor = System.Drawing.Color.Transparent;
            this.Heading1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading1.ForeColor = System.Drawing.Color.White;
            this.Heading1.Location = new System.Drawing.Point(2, 11);
            this.Heading1.Name = "Heading1";
            this.Heading1.Size = new System.Drawing.Size(134, 25);
            this.Heading1.TabIndex = 31;
            this.Heading1.Text = "#cyclicCode!";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.textBox);
            this.tabPage2.Controls.Add(this.Heading2);
            this.tabPage2.Controls.Add(this.Heading);
            this.tabPage2.Controls.Add(this.chooseButton);
            this.tabPage2.Controls.Add(this.ceButton);
            this.tabPage2.Controls.Add(this.cButton);
            this.tabPage2.Controls.Add(this.errorLabel);
            this.tabPage2.Controls.Add(this.oneButton);
            this.tabPage2.Controls.Add(this.zeroButton);
            this.tabPage2.Controls.Add(this.calculateButton);
            this.tabPage2.Controls.Add(this.polynomStepenLabel);
            this.tabPage2.Controls.Add(this.tripleErrorRadioButton);
            this.tabPage2.Controls.Add(this.doubleErrorRadioButton);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.generatingPolynomListView);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1021, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задачи";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(221, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 37);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "P(x) = (1+x).P₁(x) = (1+x).( ";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(3, 128);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(195, 22);
            this.textBox.TabIndex = 34;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_1);
            // 
            // Heading2
            // 
            this.Heading2.AutoSize = true;
            this.Heading2.BackColor = System.Drawing.Color.Transparent;
            this.Heading2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading2.ForeColor = System.Drawing.Color.White;
            this.Heading2.Location = new System.Drawing.Point(3, 102);
            this.Heading2.Name = "Heading2";
            this.Heading2.Size = new System.Drawing.Size(162, 23);
            this.Heading2.TabIndex = 31;
            this.Heading2.Text = "Въведете число:";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.White;
            this.Heading.Location = new System.Drawing.Point(2, 11);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(134, 25);
            this.Heading.TabIndex = 30;
            this.Heading.Text = "#cyclicCode!";
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.Color.Transparent;
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseButton.ForeColor = System.Drawing.Color.YellowGreen;
            this.chooseButton.Location = new System.Drawing.Point(710, 68);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(108, 36);
            this.chooseButton.TabIndex = 29;
            this.chooseButton.Text = "Избери!";
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Visible = false;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click_1);
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.Color.Transparent;
            this.ceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ceButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ceButton.ForeColor = System.Drawing.Color.White;
            this.ceButton.Location = new System.Drawing.Point(7, 200);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(191, 46);
            this.ceButton.TabIndex = 28;
            this.ceButton.Text = "Изтрийте входна последователност";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.Transparent;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButton.ForeColor = System.Drawing.Color.White;
            this.cButton.Location = new System.Drawing.Point(77, 158);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(121, 36);
            this.cButton.TabIndex = 27;
            this.cButton.Text = "Изтрийте бит";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Roboto Cn", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(203, 128);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(223, 25);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Моля, въведете 0 или 1!";
            this.errorLabel.Visible = false;
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Transparent;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(42, 158);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(29, 36);
            this.oneButton.TabIndex = 25;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Transparent;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(7, 158);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(29, 36);
            this.zeroButton.TabIndex = 24;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(7, 310);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(191, 36);
            this.calculateButton.TabIndex = 23;
            this.calculateButton.Text = "ИЗЧИСЛИ!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // polynomStepenLabel
            // 
            this.polynomStepenLabel.AutoSize = true;
            this.polynomStepenLabel.BackColor = System.Drawing.Color.Transparent;
            this.polynomStepenLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polynomStepenLabel.ForeColor = System.Drawing.Color.White;
            this.polynomStepenLabel.Location = new System.Drawing.Point(222, 75);
            this.polynomStepenLabel.Name = "polynomStepenLabel";
            this.polynomStepenLabel.Size = new System.Drawing.Size(478, 24);
            this.polynomStepenLabel.TabIndex = 22;
            this.polynomStepenLabel.Text = "Изберете степента на пораждащия полином:";
            this.polynomStepenLabel.Visible = false;
            // 
            // tripleErrorRadioButton
            // 
            this.tripleErrorRadioButton.AutoSize = true;
            this.tripleErrorRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.tripleErrorRadioButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tripleErrorRadioButton.ForeColor = System.Drawing.Color.White;
            this.tripleErrorRadioButton.Location = new System.Drawing.Point(7, 281);
            this.tripleErrorRadioButton.Name = "tripleErrorRadioButton";
            this.tripleErrorRadioButton.Size = new System.Drawing.Size(140, 23);
            this.tripleErrorRadioButton.TabIndex = 20;
            this.tripleErrorRadioButton.TabStop = true;
            this.tripleErrorRadioButton.Text = "Тройна грешка";
            this.tripleErrorRadioButton.UseVisualStyleBackColor = false;
            // 
            // doubleErrorRadioButton
            // 
            this.doubleErrorRadioButton.AutoSize = true;
            this.doubleErrorRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.doubleErrorRadioButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doubleErrorRadioButton.ForeColor = System.Drawing.Color.White;
            this.doubleErrorRadioButton.Location = new System.Drawing.Point(7, 252);
            this.doubleErrorRadioButton.Name = "doubleErrorRadioButton";
            this.doubleErrorRadioButton.Size = new System.Drawing.Size(142, 23);
            this.doubleErrorRadioButton.TabIndex = 19;
            this.doubleErrorRadioButton.TabStop = true;
            this.doubleErrorRadioButton.Text = "Двойна грешка";
            this.doubleErrorRadioButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.nLabel);
            this.groupBox1.Controls.Add(this.kLabel);
            this.groupBox1.Controls.Add(this.kInfoLabel);
            this.groupBox1.Controls.Add(this.dLabel);
            this.groupBox1.Controls.Add(this.lzeroLabel);
            this.groupBox1.Controls.Add(this.polynomLength);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(142, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 37);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.BackColor = System.Drawing.Color.Transparent;
            this.nLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nLabel.ForeColor = System.Drawing.Color.White;
            this.nLabel.Location = new System.Drawing.Point(552, 8);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(41, 24);
            this.nLabel.TabIndex = 36;
            this.nLabel.Text = "n =";
            this.nLabel.Visible = false;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.BackColor = System.Drawing.Color.Transparent;
            this.kLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLabel.ForeColor = System.Drawing.Color.White;
            this.kLabel.Location = new System.Drawing.Point(334, 8);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(46, 24);
            this.kLabel.TabIndex = 35;
            this.kLabel.Text = "k = ";
            this.kLabel.Visible = false;
            // 
            // kInfoLabel
            // 
            this.kInfoLabel.AutoSize = true;
            this.kInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.kInfoLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kInfoLabel.ForeColor = System.Drawing.Color.White;
            this.kInfoLabel.Location = new System.Drawing.Point(410, 8);
            this.kInfoLabel.Name = "kInfoLabel";
            this.kInfoLabel.Size = new System.Drawing.Size(156, 24);
            this.kInfoLabel.TabIndex = 34;
            this.kInfoLabel.Text = "2ᵏ – k ≥ m+1 = ";
            this.kInfoLabel.Visible = false;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.BackColor = System.Drawing.Color.Transparent;
            this.dLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dLabel.ForeColor = System.Drawing.Color.White;
            this.dLabel.Location = new System.Drawing.Point(148, 8);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(156, 24);
            this.dLabel.TabIndex = 33;
            this.dLabel.Text = "d ≥ l₀ + 1;   d = ";
            this.dLabel.Visible = false;
            // 
            // lzeroLabel
            // 
            this.lzeroLabel.AutoSize = true;
            this.lzeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.lzeroLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lzeroLabel.ForeColor = System.Drawing.Color.White;
            this.lzeroLabel.Location = new System.Drawing.Point(80, 9);
            this.lzeroLabel.Name = "lzeroLabel";
            this.lzeroLabel.Size = new System.Drawing.Size(45, 24);
            this.lzeroLabel.TabIndex = 32;
            this.lzeroLabel.Text = "l₀ = ";
            this.lzeroLabel.Visible = false;
            // 
            // polynomLength
            // 
            this.polynomLength.AutoSize = true;
            this.polynomLength.BackColor = System.Drawing.Color.Transparent;
            this.polynomLength.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polynomLength.ForeColor = System.Drawing.Color.White;
            this.polynomLength.Location = new System.Drawing.Point(2, 9);
            this.polynomLength.Name = "polynomLength";
            this.polynomLength.Size = new System.Drawing.Size(47, 24);
            this.polynomLength.TabIndex = 31;
            this.polynomLength.Text = "m =";
            this.polynomLength.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(221, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 37);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "xᵏ.G(x) = ";
            // 
            // generatingPolynomListView
            // 
            this.generatingPolynomListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(37)))));
            this.generatingPolynomListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.generatingPolynomListView.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatingPolynomListView.ForeColor = System.Drawing.Color.White;
            this.generatingPolynomListView.FullRowSelect = true;
            this.generatingPolynomListView.Location = new System.Drawing.Point(221, 107);
            this.generatingPolynomListView.MultiSelect = false;
            this.generatingPolynomListView.Name = "generatingPolynomListView";
            this.generatingPolynomListView.Size = new System.Drawing.Size(780, 90);
            this.generatingPolynomListView.TabIndex = 1;
            this.generatingPolynomListView.UseCompatibleStateImageBehavior = false;
            this.generatingPolynomListView.View = System.Windows.Forms.View.Details;
            this.generatingPolynomListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Степен на полинома S";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Неприводим полином P₁(x)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Индикатор I = 2ˢ – 1";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 235;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(37)))));
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(221, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(771, 400);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(1, 70);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(201, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "#цикличенКод!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ListView generatingPolynomListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.RadioButton doubleErrorRadioButton;
        private System.Windows.Forms.RadioButton tripleErrorRadioButton;
        private System.Windows.Forms.Label polynomStepenLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button chooseButton;
       private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label Heading1;
        private System.Windows.Forms.Label Heading2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label kInfoLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label lzeroLabel;
        private System.Windows.Forms.Label polynomLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}

