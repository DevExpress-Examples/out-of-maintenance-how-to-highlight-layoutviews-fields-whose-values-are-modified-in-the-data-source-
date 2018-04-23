namespace E1885 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(943, 622);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Table1";
            this.bindingSource1.DataSource = this.dataSet1;
            this.bindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.OnBindingSourceListChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colColumn1,
            this.colColumn2});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomFieldValueStyle += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewFieldValueStyleEventHandler(this.OnLayoutViewCustomFieldValueStyle);
            // 
            // colColumn1
            // 
            this.colColumn1.Caption = "Column1";
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.LayoutViewField = this.layoutViewField_colColumn1;
            this.colColumn1.Name = "colColumn1";
            // 
            // layoutViewField_colColumn1
            // 
            this.layoutViewField_colColumn1.EditorPreferredWidth = 147;
            this.layoutViewField_colColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colColumn1.Name = "layoutViewField_colColumn1";
            this.layoutViewField_colColumn1.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colColumn1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colColumn1.TextSize = new System.Drawing.Size(45, 20);
            // 
            // colColumn2
            // 
            this.colColumn2.Caption = "Column2";
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.LayoutViewField = this.layoutViewField_colColumn2;
            this.colColumn2.Name = "colColumn2";
            // 
            // layoutViewField_colColumn2
            // 
            this.layoutViewField_colColumn2.EditorPreferredWidth = 147;
            this.layoutViewField_colColumn2.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colColumn2.Name = "layoutViewField_colColumn2";
            this.layoutViewField_colColumn2.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colColumn2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colColumn2.TextSize = new System.Drawing.Size(45, 20);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewCard1";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colColumn1,
            this.layoutViewField_colColumn2});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.OnTimerClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 622);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colColumn2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;

    }
}

