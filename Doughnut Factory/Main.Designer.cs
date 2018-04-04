namespace Doughnut_Factory
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRaised = new System.Windows.Forms.Label();
            this.lblCake = new System.Windows.Forms.Label();
            this.lblFilled = new System.Windows.Forms.Label();
            this.lblGlazedRaised = new System.Windows.Forms.Label();
            this.lblSugarRaised = new System.Windows.Forms.Label();
            this.txtGlazzedRaised = new System.Windows.Forms.TextBox();
            this.txtSugarRaised = new System.Windows.Forms.TextBox();
            this.lblChocolateRaised = new System.Windows.Forms.Label();
            this.txtChocolateRaised = new System.Windows.Forms.TextBox();
            this.lblPlainCake = new System.Windows.Forms.Label();
            this.txtPlainCake = new System.Windows.Forms.TextBox();
            this.lvlChocolateCake = new System.Windows.Forms.Label();
            this.txtChocolateCake = new System.Windows.Forms.TextBox();
            this.lblSugarCake = new System.Windows.Forms.Label();
            this.txtSugarCake = new System.Windows.Forms.TextBox();
            this.lblLemonFilled = new System.Windows.Forms.Label();
            this.txtLemonFilled = new System.Windows.Forms.TextBox();
            this.lblGrapeFilled = new System.Windows.Forms.Label();
            this.txtGrapeFilled = new System.Windows.Forms.TextBox();
            this.lblCustardFilled = new System.Windows.Forms.Label();
            this.txtCustardFilled = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoughnuts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMake = new System.Windows.Forms.ToolStripMenuItem();
            this.raisedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRaisedGlazzed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRaisedSugar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRaisedChocolade = new System.Windows.Forms.ToolStripMenuItem();
            this.cakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveStale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddaCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTitle.Location = new System.Drawing.Point(142, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Current Inventory";
            // 
            // lblRaised
            // 
            this.lblRaised.AutoSize = true;
            this.lblRaised.Location = new System.Drawing.Point(29, 57);
            this.lblRaised.Name = "lblRaised";
            this.lblRaised.Size = new System.Drawing.Size(40, 13);
            this.lblRaised.TabIndex = 1;
            this.lblRaised.Text = "Raised";
            // 
            // lblCake
            // 
            this.lblCake.AutoSize = true;
            this.lblCake.Location = new System.Drawing.Point(210, 57);
            this.lblCake.Name = "lblCake";
            this.lblCake.Size = new System.Drawing.Size(32, 13);
            this.lblCake.TabIndex = 2;
            this.lblCake.Text = "Cake";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.Location = new System.Drawing.Point(372, 57);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(31, 13);
            this.lblFilled.TabIndex = 3;
            this.lblFilled.Text = "Filled";
            // 
            // lblGlazedRaised
            // 
            this.lblGlazedRaised.AutoSize = true;
            this.lblGlazedRaised.Location = new System.Drawing.Point(29, 89);
            this.lblGlazedRaised.Name = "lblGlazedRaised";
            this.lblGlazedRaised.Size = new System.Drawing.Size(40, 13);
            this.lblGlazedRaised.TabIndex = 4;
            this.lblGlazedRaised.Text = "Glazed";
            // 
            // lblSugarRaised
            // 
            this.lblSugarRaised.AutoSize = true;
            this.lblSugarRaised.Location = new System.Drawing.Point(29, 120);
            this.lblSugarRaised.Name = "lblSugarRaised";
            this.lblSugarRaised.Size = new System.Drawing.Size(35, 13);
            this.lblSugarRaised.TabIndex = 5;
            this.lblSugarRaised.Text = "Sugar";
            // 
            // txtGlazzedRaised
            // 
            this.txtGlazzedRaised.Location = new System.Drawing.Point(100, 86);
            this.txtGlazzedRaised.Name = "txtGlazzedRaised";
            this.txtGlazzedRaised.ReadOnly = true;
            this.txtGlazzedRaised.Size = new System.Drawing.Size(37, 20);
            this.txtGlazzedRaised.TabIndex = 7;
            // 
            // txtSugarRaised
            // 
            this.txtSugarRaised.Location = new System.Drawing.Point(100, 117);
            this.txtSugarRaised.Name = "txtSugarRaised";
            this.txtSugarRaised.ReadOnly = true;
            this.txtSugarRaised.Size = new System.Drawing.Size(37, 20);
            this.txtSugarRaised.TabIndex = 8;
            // 
            // lblChocolateRaised
            // 
            this.lblChocolateRaised.AutoSize = true;
            this.lblChocolateRaised.Location = new System.Drawing.Point(29, 155);
            this.lblChocolateRaised.Name = "lblChocolateRaised";
            this.lblChocolateRaised.Size = new System.Drawing.Size(55, 13);
            this.lblChocolateRaised.TabIndex = 9;
            this.lblChocolateRaised.Text = "Chocolate";
            // 
            // txtChocolateRaised
            // 
            this.txtChocolateRaised.Location = new System.Drawing.Point(100, 148);
            this.txtChocolateRaised.Name = "txtChocolateRaised";
            this.txtChocolateRaised.ReadOnly = true;
            this.txtChocolateRaised.Size = new System.Drawing.Size(37, 20);
            this.txtChocolateRaised.TabIndex = 10;
            // 
            // lblPlainCake
            // 
            this.lblPlainCake.AutoSize = true;
            this.lblPlainCake.Location = new System.Drawing.Point(210, 88);
            this.lblPlainCake.Name = "lblPlainCake";
            this.lblPlainCake.Size = new System.Drawing.Size(30, 13);
            this.lblPlainCake.TabIndex = 11;
            this.lblPlainCake.Text = "Plain";
            // 
            // txtPlainCake
            // 
            this.txtPlainCake.Location = new System.Drawing.Point(275, 86);
            this.txtPlainCake.Name = "txtPlainCake";
            this.txtPlainCake.ReadOnly = true;
            this.txtPlainCake.Size = new System.Drawing.Size(37, 20);
            this.txtPlainCake.TabIndex = 12;
            // 
            // lvlChocolateCake
            // 
            this.lvlChocolateCake.AutoSize = true;
            this.lvlChocolateCake.Location = new System.Drawing.Point(210, 124);
            this.lvlChocolateCake.Name = "lvlChocolateCake";
            this.lvlChocolateCake.Size = new System.Drawing.Size(55, 13);
            this.lvlChocolateCake.TabIndex = 13;
            this.lvlChocolateCake.Text = "Chocolate";
            // 
            // txtChocolateCake
            // 
            this.txtChocolateCake.Location = new System.Drawing.Point(275, 120);
            this.txtChocolateCake.Name = "txtChocolateCake";
            this.txtChocolateCake.ReadOnly = true;
            this.txtChocolateCake.Size = new System.Drawing.Size(37, 20);
            this.txtChocolateCake.TabIndex = 14;
            // 
            // lblSugarCake
            // 
            this.lblSugarCake.AutoSize = true;
            this.lblSugarCake.Location = new System.Drawing.Point(213, 155);
            this.lblSugarCake.Name = "lblSugarCake";
            this.lblSugarCake.Size = new System.Drawing.Size(35, 13);
            this.lblSugarCake.TabIndex = 15;
            this.lblSugarCake.Text = "Sugar";
            // 
            // txtSugarCake
            // 
            this.txtSugarCake.Location = new System.Drawing.Point(275, 152);
            this.txtSugarCake.Name = "txtSugarCake";
            this.txtSugarCake.ReadOnly = true;
            this.txtSugarCake.Size = new System.Drawing.Size(37, 20);
            this.txtSugarCake.TabIndex = 16;
            // 
            // lblLemonFilled
            // 
            this.lblLemonFilled.AutoSize = true;
            this.lblLemonFilled.Location = new System.Drawing.Point(372, 87);
            this.lblLemonFilled.Name = "lblLemonFilled";
            this.lblLemonFilled.Size = new System.Drawing.Size(39, 13);
            this.lblLemonFilled.TabIndex = 17;
            this.lblLemonFilled.Text = "Lemon";
            // 
            // txtLemonFilled
            // 
            this.txtLemonFilled.Location = new System.Drawing.Point(417, 86);
            this.txtLemonFilled.Name = "txtLemonFilled";
            this.txtLemonFilled.ReadOnly = true;
            this.txtLemonFilled.Size = new System.Drawing.Size(37, 20);
            this.txtLemonFilled.TabIndex = 18;
            // 
            // lblGrapeFilled
            // 
            this.lblGrapeFilled.AutoSize = true;
            this.lblGrapeFilled.Location = new System.Drawing.Point(372, 120);
            this.lblGrapeFilled.Name = "lblGrapeFilled";
            this.lblGrapeFilled.Size = new System.Drawing.Size(36, 13);
            this.lblGrapeFilled.TabIndex = 19;
            this.lblGrapeFilled.Text = "Grape";
            // 
            // txtGrapeFilled
            // 
            this.txtGrapeFilled.Location = new System.Drawing.Point(417, 120);
            this.txtGrapeFilled.Name = "txtGrapeFilled";
            this.txtGrapeFilled.ReadOnly = true;
            this.txtGrapeFilled.Size = new System.Drawing.Size(37, 20);
            this.txtGrapeFilled.TabIndex = 20;
            // 
            // lblCustardFilled
            // 
            this.lblCustardFilled.AutoSize = true;
            this.lblCustardFilled.Location = new System.Drawing.Point(375, 154);
            this.lblCustardFilled.Name = "lblCustardFilled";
            this.lblCustardFilled.Size = new System.Drawing.Size(43, 13);
            this.lblCustardFilled.TabIndex = 21;
            this.lblCustardFilled.Text = "Custard";
            // 
            // txtCustardFilled
            // 
            this.txtCustardFilled.Location = new System.Drawing.Point(417, 152);
            this.txtCustardFilled.Name = "txtCustardFilled";
            this.txtCustardFilled.ReadOnly = true;
            this.txtCustardFilled.Size = new System.Drawing.Size(37, 20);
            this.txtCustardFilled.TabIndex = 22;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(29, 187);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(65, 13);
            this.lblSale.TabIndex = 23;
            this.lblSale.Text = "Current Sale";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(32, 228);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 24;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(29, 210);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(143, 187);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(272, 187);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(146, 228);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(275, 228);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 29;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 30);
            this.listBox1.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(234, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(275, 307);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 32;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(381, 226);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(78, 23);
            this.btnAddToSale.TabIndex = 33;
            this.btnAddToSale.Text = "Add To Sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(381, 262);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(78, 23);
            this.btnRemoveItem.TabIndex = 34;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(381, 305);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 35;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDoughnuts,
            this.mnuCustomers,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDoughnuts
            // 
            this.mnuDoughnuts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMake,
            this.mnuRemoveStale,
            this.menuStop});
            this.mnuDoughnuts.Name = "mnuDoughnuts";
            this.mnuDoughnuts.Size = new System.Drawing.Size(78, 20);
            this.mnuDoughnuts.Text = "Doughnuts";
            // 
            // mnuMake
            // 
            this.mnuMake.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raisedToolStripMenuItem,
            this.cakeToolStripMenuItem,
            this.filledToolStripMenuItem});
            this.mnuMake.Name = "mnuMake";
            this.mnuMake.Size = new System.Drawing.Size(145, 22);
            this.mnuMake.Text = "Make";
            // 
            // raisedToolStripMenuItem
            // 
            this.raisedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRaisedGlazzed,
            this.menuRaisedSugar,
            this.menuRaisedChocolade});
            this.raisedToolStripMenuItem.Name = "raisedToolStripMenuItem";
            this.raisedToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.raisedToolStripMenuItem.Text = "Raised";
            // 
            // menuRaisedGlazzed
            // 
            this.menuRaisedGlazzed.Name = "menuRaisedGlazzed";
            this.menuRaisedGlazzed.Size = new System.Drawing.Size(131, 22);
            this.menuRaisedGlazzed.Text = "Glazzed";
            this.menuRaisedGlazzed.Click += new System.EventHandler(this.mnuRaisedGlazed_Clicked);
            // 
            // menuRaisedSugar
            // 
            this.menuRaisedSugar.Name = "menuRaisedSugar";
            this.menuRaisedSugar.Size = new System.Drawing.Size(131, 22);
            this.menuRaisedSugar.Text = "Sugar";
            this.menuRaisedSugar.Click += new System.EventHandler(this.menuRaisedSugar_Click);
            // 
            // menuRaisedChocolade
            // 
            this.menuRaisedChocolade.Name = "menuRaisedChocolade";
            this.menuRaisedChocolade.Size = new System.Drawing.Size(131, 22);
            this.menuRaisedChocolade.Text = "Chocolade";
            this.menuRaisedChocolade.Click += new System.EventHandler(this.menuRaisedChocolade_Click);
            // 
            // cakeToolStripMenuItem
            // 
            this.cakeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plainToolStripMenuItem,
            this.chocolateToolStripMenuItem,
            this.sugarToolStripMenuItem1});
            this.cakeToolStripMenuItem.Name = "cakeToolStripMenuItem";
            this.cakeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cakeToolStripMenuItem.Text = "Cake";
            // 
            // plainToolStripMenuItem
            // 
            this.plainToolStripMenuItem.Name = "plainToolStripMenuItem";
            this.plainToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.plainToolStripMenuItem.Text = "Plain";
            // 
            // chocolateToolStripMenuItem
            // 
            this.chocolateToolStripMenuItem.Name = "chocolateToolStripMenuItem";
            this.chocolateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.chocolateToolStripMenuItem.Text = "Chocolate";
            // 
            // sugarToolStripMenuItem1
            // 
            this.sugarToolStripMenuItem1.Name = "sugarToolStripMenuItem1";
            this.sugarToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.sugarToolStripMenuItem1.Text = "Sugar";
            // 
            // filledToolStripMenuItem
            // 
            this.filledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lemonToolStripMenuItem,
            this.grapeToolStripMenuItem,
            this.custardToolStripMenuItem});
            this.filledToolStripMenuItem.Name = "filledToolStripMenuItem";
            this.filledToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.filledToolStripMenuItem.Text = "filled";
            // 
            // lemonToolStripMenuItem
            // 
            this.lemonToolStripMenuItem.Name = "lemonToolStripMenuItem";
            this.lemonToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.lemonToolStripMenuItem.Text = "Lemon";
            // 
            // grapeToolStripMenuItem
            // 
            this.grapeToolStripMenuItem.Name = "grapeToolStripMenuItem";
            this.grapeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.grapeToolStripMenuItem.Text = "Grape";
            // 
            // custardToolStripMenuItem
            // 
            this.custardToolStripMenuItem.Name = "custardToolStripMenuItem";
            this.custardToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.custardToolStripMenuItem.Text = "Custard";
            // 
            // mnuRemoveStale
            // 
            this.mnuRemoveStale.Name = "mnuRemoveStale";
            this.mnuRemoveStale.Size = new System.Drawing.Size(145, 22);
            this.mnuRemoveStale.Text = "Remove Stale";
            // 
            // menuStop
            // 
            this.menuStop.Name = "menuStop";
            this.menuStop.Size = new System.Drawing.Size(145, 22);
            this.menuStop.Text = "Stop";
            this.menuStop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddaCustomer,
            this.mnuViewCustomers});
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuAddaCustomer
            // 
            this.mnuAddaCustomer.Name = "mnuAddaCustomer";
            this.mnuAddaCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuAddaCustomer.Text = "Add a Customer";
            this.mnuAddaCustomer.Click += new System.EventHandler(this.mnuAddaCustomer_Click);
            // 
            // mnuViewCustomers
            // 
            this.mnuViewCustomers.Name = "mnuViewCustomers";
            this.mnuViewCustomers.Size = new System.Drawing.Size(180, 22);
            this.mnuViewCustomers.Text = "View Customers";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuContents});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuAbout.Text = "About";
            // 
            // mnuContents
            // 
            this.mnuContents.Name = "mnuContents";
            this.mnuContents.Size = new System.Drawing.Size(122, 22);
            this.mnuContents.Text = "Contents";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 362);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddToSale);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.txtCustardFilled);
            this.Controls.Add(this.lblCustardFilled);
            this.Controls.Add(this.txtGrapeFilled);
            this.Controls.Add(this.lblGrapeFilled);
            this.Controls.Add(this.txtLemonFilled);
            this.Controls.Add(this.lblLemonFilled);
            this.Controls.Add(this.txtSugarCake);
            this.Controls.Add(this.lblSugarCake);
            this.Controls.Add(this.txtChocolateCake);
            this.Controls.Add(this.lvlChocolateCake);
            this.Controls.Add(this.txtPlainCake);
            this.Controls.Add(this.lblPlainCake);
            this.Controls.Add(this.txtChocolateRaised);
            this.Controls.Add(this.lblChocolateRaised);
            this.Controls.Add(this.txtSugarRaised);
            this.Controls.Add(this.txtGlazzedRaised);
            this.Controls.Add(this.lblSugarRaised);
            this.Controls.Add(this.lblGlazedRaised);
            this.Controls.Add(this.lblFilled);
            this.Controls.Add(this.lblCake);
            this.Controls.Add(this.lblRaised);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "The Doughnut Factory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRaised;
        private System.Windows.Forms.Label lblCake;
        private System.Windows.Forms.Label lblFilled;
        private System.Windows.Forms.Label lblGlazedRaised;
        private System.Windows.Forms.Label lblSugarRaised;
        private System.Windows.Forms.TextBox txtGlazzedRaised;
        private System.Windows.Forms.TextBox txtSugarRaised;
        private System.Windows.Forms.Label lblChocolateRaised;
        private System.Windows.Forms.TextBox txtChocolateRaised;
        private System.Windows.Forms.Label lblPlainCake;
        private System.Windows.Forms.TextBox txtPlainCake;
        private System.Windows.Forms.Label lvlChocolateCake;
        private System.Windows.Forms.TextBox txtChocolateCake;
        private System.Windows.Forms.Label lblSugarCake;
        private System.Windows.Forms.TextBox txtSugarCake;
        private System.Windows.Forms.Label lblLemonFilled;
        private System.Windows.Forms.TextBox txtLemonFilled;
        private System.Windows.Forms.Label lblGrapeFilled;
        private System.Windows.Forms.TextBox txtGrapeFilled;
        private System.Windows.Forms.Label lblCustardFilled;
        private System.Windows.Forms.TextBox txtCustardFilled;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDoughnuts;
        private System.Windows.Forms.ToolStripMenuItem mnuMake;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveStale;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuAddaCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuContents;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem raisedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRaisedGlazzed;
        private System.Windows.Forms.ToolStripMenuItem menuRaisedSugar;
        private System.Windows.Forms.ToolStripMenuItem menuRaisedChocolade;
        private System.Windows.Forms.ToolStripMenuItem cakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStop;
    }
}

