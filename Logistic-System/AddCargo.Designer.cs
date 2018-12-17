namespace Logistic_System
{
    partial class AddCargo
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
            this.comboSender = new System.Windows.Forms.ComboBox();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportation = new Logistic_System.Transportation();
            this.comboDeparture = new System.Windows.Forms.ComboBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboArrival = new System.Windows.Forms.ComboBox();
            this.numericWorth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.sendersTableAdapter = new Logistic_System.TransportationTableAdapters.SendersTableAdapter();
            this.stationsTableAdapter = new Logistic_System.TransportationTableAdapters.StationsTableAdapter();
            this.cargoesTableAdapter1 = new Logistic_System.TransportationTableAdapters.CargoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWorth)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSender
            // 
            this.comboSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSender.DataSource = this.sendersBindingSource;
            this.comboSender.DisplayMember = "Name";
            this.comboSender.FormattingEnabled = true;
            this.comboSender.Location = new System.Drawing.Point(130, 36);
            this.comboSender.Name = "comboSender";
            this.comboSender.Size = new System.Drawing.Size(217, 21);
            this.comboSender.TabIndex = 0;
            this.comboSender.ValueMember = "Id";
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.transportation;
            // 
            // transportation
            // 
            this.transportation.DataSetName = "Transportation";
            this.transportation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboDeparture
            // 
            this.comboDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDeparture.DataSource = this.stationsBindingSource;
            this.comboDeparture.DisplayMember = "Name";
            this.comboDeparture.FormattingEnabled = true;
            this.comboDeparture.Location = new System.Drawing.Point(130, 63);
            this.comboDeparture.Name = "comboDeparture";
            this.comboDeparture.Size = new System.Drawing.Size(217, 21);
            this.comboDeparture.TabIndex = 1;
            this.comboDeparture.ValueMember = "Id";
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            this.stationsBindingSource.DataSource = this.transportation;
            // 
            // comboArrival
            // 
            this.comboArrival.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboArrival.DataSource = this.stationsBindingSource;
            this.comboArrival.DisplayMember = "Name";
            this.comboArrival.FormattingEnabled = true;
            this.comboArrival.Location = new System.Drawing.Point(130, 90);
            this.comboArrival.Name = "comboArrival";
            this.comboArrival.Size = new System.Drawing.Size(217, 21);
            this.comboArrival.TabIndex = 2;
            this.comboArrival.ValueMember = "Id";
            // 
            // numericWorth
            // 
            this.numericWorth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericWorth.Location = new System.Drawing.Point(129, 117);
            this.numericWorth.Name = "numericWorth";
            this.numericWorth.Size = new System.Drawing.Size(217, 20);
            this.numericWorth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Відправник:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Станція відправлення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Станція прибуття";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вартість товару";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Додавання вантажу";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(140, 147);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 32);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Додати товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(246, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 32);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // cargoesTableAdapter1
            // 
            this.cargoesTableAdapter1.ClearBeforeFill = true;
            // 
            // AddCargo
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(359, 189);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericWorth);
            this.Controls.Add(this.comboArrival);
            this.Controls.Add(this.comboDeparture);
            this.Controls.Add(this.comboSender);
            this.Name = "AddCargo";
            this.Text = "Додавання вантажу";
            this.Load += new System.EventHandler(this.AddCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWorth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSender;
        private System.Windows.Forms.ComboBox comboDeparture;
        private System.Windows.Forms.ComboBox comboArrival;
        private System.Windows.Forms.NumericUpDown numericWorth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private Transportation transportation;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private TransportationTableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private TransportationTableAdapters.StationsTableAdapter stationsTableAdapter;
        private TransportationTableAdapters.CargoesTableAdapter cargoesTableAdapter1;
    }
}