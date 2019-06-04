namespace WinFormsDevExpress
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
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUserColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPlaceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateBegin = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.inputPlace = new DevExpress.XtraEditors.TextEdit();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelFromFilter = new DevExpress.XtraEditors.LabelControl();
            this.labelPlaceFilter = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlace.Properties)).BeginInit();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(247, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(586, 449);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridNameColumn,
            this.gridDateColumn,
            this.gridTimeColumn,
            this.gridUserColumn,
            this.gridPlaceColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridNameColumn
            // 
            this.gridNameColumn.Caption = "Nazwa";
            this.gridNameColumn.FieldName = "Name";
            this.gridNameColumn.Name = "gridNameColumn";
            this.gridNameColumn.OptionsColumn.AllowEdit = false;
            this.gridNameColumn.Visible = true;
            this.gridNameColumn.VisibleIndex = 0;
            // 
            // gridDateColumn
            // 
            this.gridDateColumn.Caption = "Data";
            this.gridDateColumn.FieldName = "Date";
            this.gridDateColumn.Name = "gridDateColumn";
            this.gridDateColumn.OptionsColumn.AllowEdit = false;
            this.gridDateColumn.Visible = true;
            this.gridDateColumn.VisibleIndex = 1;
            // 
            // gridTimeColumn
            // 
            this.gridTimeColumn.Caption = "Godzina";
            this.gridTimeColumn.FieldName = "Time";
            this.gridTimeColumn.Name = "gridTimeColumn";
            this.gridTimeColumn.OptionsColumn.AllowEdit = false;
            this.gridTimeColumn.Visible = true;
            this.gridTimeColumn.VisibleIndex = 2;
            // 
            // gridUserColumn
            // 
            this.gridUserColumn.Caption = "Użytkownik";
            this.gridUserColumn.FieldName = "User";
            this.gridUserColumn.Name = "gridUserColumn";
            this.gridUserColumn.OptionsColumn.AllowEdit = false;
            this.gridUserColumn.Visible = true;
            this.gridUserColumn.VisibleIndex = 3;
            // 
            // gridPlaceColumn
            // 
            this.gridPlaceColumn.Caption = "Lokal";
            this.gridPlaceColumn.FieldName = "Place";
            this.gridPlaceColumn.Name = "gridPlaceColumn";
            this.gridPlaceColumn.OptionsColumn.AllowEdit = false;
            this.gridPlaceColumn.Visible = true;
            this.gridPlaceColumn.VisibleIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 424);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 37);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Zatwierdź";
            this.simpleButton1.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // dateBegin
            // 
            this.dateBegin.EditValue = null;
            this.dateBegin.Location = new System.Drawing.Point(82, 45);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateBegin.Size = new System.Drawing.Size(132, 20);
            this.dateBegin.TabIndex = 3;
            this.dateBegin.EditValueChanged += new System.EventHandler(this.DateBegin_EditValueChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(82, 71);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEnd.Size = new System.Drawing.Size(132, 20);
            this.dateEnd.TabIndex = 4;
            this.dateEnd.ToolTip = "test1";
            this.dateEnd.EditValueChanged += new System.EventHandler(this.DateEnd_EditValueChanged);
            // 
            // inputPlace
            // 
            this.inputPlace.Location = new System.Drawing.Point(82, 19);
            this.inputPlace.Name = "inputPlace";
            this.inputPlace.Size = new System.Drawing.Size(132, 20);
            this.inputPlace.TabIndex = 5;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.labelControl1);
            this.groupFilter.Controls.Add(this.labelFromFilter);
            this.groupFilter.Controls.Add(this.labelPlaceFilter);
            this.groupFilter.Controls.Add(this.dateEnd);
            this.groupFilter.Controls.Add(this.inputPlace);
            this.groupFilter.Controls.Add(this.dateBegin);
            this.groupFilter.Location = new System.Drawing.Point(12, 12);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(220, 105);
            this.groupFilter.TabIndex = 6;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filtr";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Do:";
            // 
            // labelFromFilter
            // 
            this.labelFromFilter.Location = new System.Drawing.Point(8, 48);
            this.labelFromFilter.Name = "labelFromFilter";
            this.labelFromFilter.Size = new System.Drawing.Size(18, 13);
            this.labelFromFilter.TabIndex = 7;
            this.labelFromFilter.Text = "Od:";
            // 
            // labelPlaceFilter
            // 
            this.labelPlaceFilter.Location = new System.Drawing.Point(8, 22);
            this.labelPlaceFilter.Name = "labelPlaceFilter";
            this.labelPlaceFilter.Size = new System.Drawing.Size(68, 13);
            this.labelPlaceFilter.TabIndex = 6;
            this.labelPlaceFilter.Text = "Lokal zawiera:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 469);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Raport";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlace.Properties)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridUserColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridPlaceColumn;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.TextEdit inputPlace;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelFromFilter;
        private DevExpress.XtraEditors.LabelControl labelPlaceFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

