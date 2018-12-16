namespace Logistic_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageCargo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportation = new Logistic_System.Transportation();
            this.cargoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pageTarnsport = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDistancePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pageStation = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSender = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cargoesTableAdapter = new Logistic_System.TransportationTableAdapters.CargoesTableAdapter();
            this.transportsTableAdapter = new Logistic_System.TransportationTableAdapters.TransportsTableAdapter();
            this.stationsTableAdapter = new Logistic_System.TransportationTableAdapters.StationsTableAdapter();
            this.sendersTableAdapter = new Logistic_System.TransportationTableAdapters.SendersTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingNavigator)).BeginInit();
            this.cargoBindingNavigator.SuspendLayout();
            this.pageTarnsport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingNavigator)).BeginInit();
            this.transportBindingNavigator.SuspendLayout();
            this.pageStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).BeginInit();
            this.stationBindingNavigator.SuspendLayout();
            this.pageSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingNavigator)).BeginInit();
            this.senderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageCargo);
            this.tabControl.Controls.Add(this.pageTarnsport);
            this.tabControl.Controls.Add(this.pageStation);
            this.tabControl.Controls.Add(this.pageSender);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(691, 426);
            this.tabControl.TabIndex = 1;
            // 
            // pageCargo
            // 
            this.pageCargo.Controls.Add(this.dataGridView1);
            this.pageCargo.Controls.Add(this.cargoBindingNavigator);
            this.pageCargo.Location = new System.Drawing.Point(4, 22);
            this.pageCargo.Name = "pageCargo";
            this.pageCargo.Padding = new System.Windows.Forms.Padding(3);
            this.pageCargo.Size = new System.Drawing.Size(683, 400);
            this.pageCargo.TabIndex = 0;
            this.pageCargo.Text = "Вантажі";
            this.pageCargo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.senderIdDataGridViewTextBoxColumn,
            this.departureStationIdDataGridViewTextBoxColumn,
            this.arrivalStationIdDataGridViewTextBoxColumn,
            this.worthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cargoesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderIdDataGridViewTextBoxColumn
            // 
            this.senderIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.senderIdDataGridViewTextBoxColumn.HeaderText = "Відправник";
            this.senderIdDataGridViewTextBoxColumn.Name = "senderIdDataGridViewTextBoxColumn";
            this.senderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureStationIdDataGridViewTextBoxColumn
            // 
            this.departureStationIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureStationIdDataGridViewTextBoxColumn.HeaderText = "Станція відправлення";
            this.departureStationIdDataGridViewTextBoxColumn.Name = "departureStationIdDataGridViewTextBoxColumn";
            this.departureStationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalStationIdDataGridViewTextBoxColumn
            // 
            this.arrivalStationIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalStationIdDataGridViewTextBoxColumn.HeaderText = "Станція прибуття";
            this.arrivalStationIdDataGridViewTextBoxColumn.Name = "arrivalStationIdDataGridViewTextBoxColumn";
            this.arrivalStationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worthDataGridViewTextBoxColumn
            // 
            this.worthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worthDataGridViewTextBoxColumn.HeaderText = "Вартість вантажу";
            this.worthDataGridViewTextBoxColumn.Name = "worthDataGridViewTextBoxColumn";
            this.worthDataGridViewTextBoxColumn.ReadOnly = true;
            this.worthDataGridViewTextBoxColumn.Width = 110;
            // 
            // cargoesBindingSource
            // 
            this.cargoesBindingSource.DataMember = "Cargoes";
            this.cargoesBindingSource.DataSource = this.transportation;
            // 
            // transportation
            // 
            this.transportation.DataSetName = "Transportation";
            this.transportation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoBindingNavigator
            // 
            this.cargoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cargoBindingNavigator.BindingSource = this.cargoesBindingSource;
            this.cargoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cargoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cargoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.cargoBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.cargoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cargoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cargoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cargoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cargoBindingNavigator.Name = "cargoBindingNavigator";
            this.cargoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cargoBindingNavigator.Size = new System.Drawing.Size(677, 25);
            this.cargoBindingNavigator.TabIndex = 2;
            this.cargoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pageTarnsport
            // 
            this.pageTarnsport.Controls.Add(this.dataGridView2);
            this.pageTarnsport.Controls.Add(this.transportBindingNavigator);
            this.pageTarnsport.Location = new System.Drawing.Point(4, 22);
            this.pageTarnsport.Name = "pageTarnsport";
            this.pageTarnsport.Padding = new System.Windows.Forms.Padding(3);
            this.pageTarnsport.Size = new System.Drawing.Size(683, 400);
            this.pageTarnsport.TabIndex = 1;
            this.pageTarnsport.Text = "Транспорти";
            this.pageTarnsport.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.maxWeightDataGridViewTextBoxColumn,
            this.weightDistancePriceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.transportsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(677, 369);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightDataGridViewTextBoxColumn
            // 
            this.maxWeightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maxWeightDataGridViewTextBoxColumn.DataPropertyName = "MaxWeight";
            this.maxWeightDataGridViewTextBoxColumn.HeaderText = "Тонажність";
            this.maxWeightDataGridViewTextBoxColumn.Name = "maxWeightDataGridViewTextBoxColumn";
            this.maxWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // weightDistancePriceDataGridViewTextBoxColumn
            // 
            this.weightDistancePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weightDistancePriceDataGridViewTextBoxColumn.DataPropertyName = "WeightDistancePrice";
            this.weightDistancePriceDataGridViewTextBoxColumn.HeaderText = "Ціна за кілометр кілограм";
            this.weightDistancePriceDataGridViewTextBoxColumn.Name = "weightDistancePriceDataGridViewTextBoxColumn";
            this.weightDistancePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDistancePriceDataGridViewTextBoxColumn.Width = 110;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вага транспорту";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 106;
            // 
            // transportsBindingSource
            // 
            this.transportsBindingSource.DataMember = "Transports";
            this.transportsBindingSource.DataSource = this.transportation;
            // 
            // transportBindingNavigator
            // 
            this.transportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.transportBindingNavigator.BindingSource = this.transportsBindingSource;
            this.transportBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.transportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.transportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.transportBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.transportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.transportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.transportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.transportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.transportBindingNavigator.Name = "transportBindingNavigator";
            this.transportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.transportBindingNavigator.Size = new System.Drawing.Size(677, 25);
            this.transportBindingNavigator.TabIndex = 0;
            this.transportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // pageStation
            // 
            this.pageStation.Controls.Add(this.dataGridView3);
            this.pageStation.Controls.Add(this.stationBindingNavigator);
            this.pageStation.Location = new System.Drawing.Point(4, 22);
            this.pageStation.Name = "pageStation";
            this.pageStation.Padding = new System.Windows.Forms.Padding(3);
            this.pageStation.Size = new System.Drawing.Size(683, 400);
            this.pageStation.TabIndex = 2;
            this.pageStation.Text = "Станції";
            this.pageStation.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.stationsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(677, 369);
            this.dataGridView3.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            this.stationsBindingSource.DataSource = this.transportation;
            // 
            // stationBindingNavigator
            // 
            this.stationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.stationBindingNavigator.BindingSource = this.stationsBindingSource;
            this.stationBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.stationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.stationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.stationBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.stationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.stationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.stationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.stationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.stationBindingNavigator.Name = "stationBindingNavigator";
            this.stationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.stationBindingNavigator.Size = new System.Drawing.Size(677, 25);
            this.stationBindingNavigator.TabIndex = 0;
            this.stationBindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // pageSender
            // 
            this.pageSender.Controls.Add(this.dataGridView4);
            this.pageSender.Controls.Add(this.senderBindingNavigator);
            this.pageSender.Location = new System.Drawing.Point(4, 22);
            this.pageSender.Name = "pageSender";
            this.pageSender.Padding = new System.Windows.Forms.Padding(3);
            this.pageSender.Size = new System.Drawing.Size(683, 400);
            this.pageSender.TabIndex = 3;
            this.pageSender.Text = "Відправники";
            this.pageSender.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.sendersBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 28);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(677, 369);
            this.dataGridView4.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Назва (ПІБ)";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.transportation;
            // 
            // senderBindingNavigator
            // 
            this.senderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.senderBindingNavigator.BindingSource = this.sendersBindingSource;
            this.senderBindingNavigator.CountItem = this.bindingNavigatorCountItem3;
            this.senderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.senderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.senderBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.senderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.senderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.senderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.senderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.senderBindingNavigator.Name = "senderBindingNavigator";
            this.senderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem3;
            this.senderBindingNavigator.Size = new System.Drawing.Size(677, 25);
            this.senderBindingNavigator.TabIndex = 0;
            this.senderBindingNavigator.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "of {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Move previous";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Position";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Move last";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // cargoesTableAdapter
            // 
            this.cargoesTableAdapter.ClearBeforeFill = true;
            // 
            // transportsTableAdapter
            // 
            this.transportsTableAdapter.ClearBeforeFill = true;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Logistic System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pageCargo.ResumeLayout(false);
            this.pageCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingNavigator)).EndInit();
            this.cargoBindingNavigator.ResumeLayout(false);
            this.cargoBindingNavigator.PerformLayout();
            this.pageTarnsport.ResumeLayout(false);
            this.pageTarnsport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingNavigator)).EndInit();
            this.transportBindingNavigator.ResumeLayout(false);
            this.transportBindingNavigator.PerformLayout();
            this.pageStation.ResumeLayout(false);
            this.pageStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).EndInit();
            this.stationBindingNavigator.ResumeLayout(false);
            this.stationBindingNavigator.PerformLayout();
            this.pageSender.ResumeLayout(false);
            this.pageSender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingNavigator)).EndInit();
            this.senderBindingNavigator.ResumeLayout(false);
            this.senderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageCargo;
        private System.Windows.Forms.TabPage pageTarnsport;
        private System.Windows.Forms.TabPage pageStation;
        private System.Windows.Forms.TabPage pageSender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportationTableAdapters.CargoesTableAdapter cargoesTableAdapter;
        private System.Windows.Forms.BindingSource cargoesBindingSource;
        private Transportation transportation;
        private System.Windows.Forms.BindingNavigator cargoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureStationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalStationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingNavigator transportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource transportsBindingSource;
        private TransportationTableAdapters.TransportsTableAdapter transportsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingNavigator stationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private TransportationTableAdapters.StationsTableAdapter stationsTableAdapter;
        private System.Windows.Forms.BindingNavigator senderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private TransportationTableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDistancePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}