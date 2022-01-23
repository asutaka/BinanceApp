namespace BinanceApp.GUI.Child
{
    partial class frmRealTime
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule3ColorScale formatConditionRule3ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule3ColorScale();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet2 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet2 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon5 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon6 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.RateValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoinName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WaveRecent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCoin = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RefValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BottomRecent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCoin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RateValue
            // 
            this.RateValue.AppearanceCell.Options.UseTextOptions = true;
            this.RateValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RateValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RateValue.AppearanceHeader.Options.UseTextOptions = true;
            this.RateValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RateValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RateValue.Caption = "Gia tăng(%)";
            this.RateValue.FieldName = "RateValue";
            this.RateValue.MaxWidth = 85;
            this.RateValue.MinWidth = 85;
            this.RateValue.Name = "RateValue";
            this.RateValue.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.RateValue.Visible = true;
            this.RateValue.VisibleIndex = 6;
            this.RateValue.Width = 85;
            // 
            // CoinName
            // 
            this.CoinName.AppearanceCell.Options.UseTextOptions = true;
            this.CoinName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CoinName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CoinName.AppearanceHeader.Options.UseTextOptions = true;
            this.CoinName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CoinName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CoinName.Caption = "Tên";
            this.CoinName.FieldName = "CoinName";
            this.CoinName.Name = "CoinName";
            this.CoinName.OptionsColumn.AllowEdit = false;
            this.CoinName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CoinName.Visible = true;
            this.CoinName.VisibleIndex = 2;
            // 
            // WaveRecent
            // 
            this.WaveRecent.AppearanceCell.Options.UseTextOptions = true;
            this.WaveRecent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WaveRecent.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WaveRecent.AppearanceHeader.Options.UseTextOptions = true;
            this.WaveRecent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WaveRecent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WaveRecent.Caption = "Sóng gần nhất(%)";
            this.WaveRecent.FieldName = "WaveRecent";
            this.WaveRecent.MaxWidth = 100;
            this.WaveRecent.MinWidth = 100;
            this.WaveRecent.Name = "WaveRecent";
            this.WaveRecent.Visible = true;
            this.WaveRecent.VisibleIndex = 7;
            this.WaveRecent.Width = 100;
            // 
            // cmbCoin
            // 
            this.cmbCoin.Location = new System.Drawing.Point(91, 26);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCoin.Properties.NullText = "";
            this.cmbCoin.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbCoin.Size = new System.Drawing.Size(450, 20);
            this.cmbCoin.TabIndex = 0;
            this.cmbCoin.EditValueChanged += new System.EventHandler(this.cmbCoin_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thêm Coin";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cmbCoin);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 53);
            this.groupControl1.TabIndex = 26;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Location = new System.Drawing.Point(0, 55);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(678, 423);
            this.grid.TabIndex = 27;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Coin,
            this.CoinName,
            this.RefValue,
            this.Value,
            this.BottomRecent,
            this.RateValue,
            this.WaveRecent,
            this.Count,
            this.Rate});
            gridFormatRule1.Column = this.RateValue;
            gridFormatRule1.ColumnApplyTo = this.RateValue;
            gridFormatRule1.Name = "FormatRate";
            formatConditionRuleIconSet1.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionIconSet1.CategoryName = "Directional";
            formatConditionIconSetIcon1.PredefinedName = "Arrows3_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Arrows3_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Arrows3_3.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "Arrows3Colored";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            gridFormatRule2.Column = this.RateValue;
            gridFormatRule2.ColumnApplyTo = this.CoinName;
            gridFormatRule2.Name = "Format1";
            formatConditionRule3ColorScale1.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRule3ColorScale1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            formatConditionRule3ColorScale1.MaximumColor = System.Drawing.Color.Green;
            formatConditionRule3ColorScale1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.MiddleColor = System.Drawing.Color.White;
            formatConditionRule3ColorScale1.MiddleType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            formatConditionRule3ColorScale1.MinimumColor = System.Drawing.Color.Red;
            formatConditionRule3ColorScale1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale1.PredefinedName = "Green, White, Red";
            gridFormatRule2.Rule = formatConditionRule3ColorScale1;
            gridFormatRule3.Column = this.WaveRecent;
            gridFormatRule3.ColumnApplyTo = this.WaveRecent;
            gridFormatRule3.Name = "Format2";
            formatConditionIconSet2.CategoryName = "Symbols";
            formatConditionIconSetIcon4.PredefinedName = "Flags3_1.png";
            formatConditionIconSetIcon5.PredefinedName = "Flags3_2.png";
            formatConditionIconSetIcon5.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon6.PredefinedName = "Flags3_3.png";
            formatConditionIconSetIcon6.Value = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6);
            formatConditionIconSet2.Name = "Flags3";
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2;
            gridFormatRule3.Rule = formatConditionRuleIconSet2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MaxWidth = 45;
            this.STT.MinWidth = 45;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 45;
            // 
            // Coin
            // 
            this.Coin.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.Coin.AppearanceCell.ForeColor = System.Drawing.Color.Green;
            this.Coin.AppearanceCell.Options.UseFont = true;
            this.Coin.AppearanceCell.Options.UseForeColor = true;
            this.Coin.AppearanceCell.Options.UseTextOptions = true;
            this.Coin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Coin.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Coin.AppearanceHeader.Options.UseTextOptions = true;
            this.Coin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Coin.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Coin.Caption = "Coin";
            this.Coin.FieldName = "Coin";
            this.Coin.MaxWidth = 90;
            this.Coin.MinWidth = 90;
            this.Coin.Name = "Coin";
            this.Coin.OptionsColumn.AllowEdit = false;
            this.Coin.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Coin.Visible = true;
            this.Coin.VisibleIndex = 1;
            this.Coin.Width = 90;
            // 
            // RefValue
            // 
            this.RefValue.AppearanceCell.Options.UseTextOptions = true;
            this.RefValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RefValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RefValue.AppearanceHeader.Options.UseTextOptions = true;
            this.RefValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RefValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RefValue.Caption = "Giá tham chiếu";
            this.RefValue.DisplayFormat.FormatString = "\"#,##0.0\"";
            this.RefValue.FieldName = "RefValue";
            this.RefValue.MaxWidth = 80;
            this.RefValue.MinWidth = 80;
            this.RefValue.Name = "RefValue";
            this.RefValue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.RefValue.Visible = true;
            this.RefValue.VisibleIndex = 3;
            this.RefValue.Width = 80;
            // 
            // Value
            // 
            this.Value.AppearanceCell.Options.UseTextOptions = true;
            this.Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.Caption = "Giá hiện tại";
            this.Value.DisplayFormat.FormatString = "#,##0.0";
            this.Value.FieldName = "Value";
            this.Value.MaxWidth = 75;
            this.Value.MinWidth = 75;
            this.Value.Name = "Value";
            this.Value.OptionsColumn.AllowEdit = false;
            this.Value.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Value.Visible = true;
            this.Value.VisibleIndex = 4;
            // 
            // BottomRecent
            // 
            this.BottomRecent.AppearanceCell.Options.UseTextOptions = true;
            this.BottomRecent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BottomRecent.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BottomRecent.AppearanceHeader.Options.UseTextOptions = true;
            this.BottomRecent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BottomRecent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BottomRecent.Caption = "Đáy gần nhất";
            this.BottomRecent.FieldName = "BottomRecent";
            this.BottomRecent.MaxWidth = 80;
            this.BottomRecent.MinWidth = 80;
            this.BottomRecent.Name = "BottomRecent";
            this.BottomRecent.Visible = true;
            this.BottomRecent.VisibleIndex = 5;
            this.BottomRecent.Width = 80;
            // 
            // Count
            // 
            this.Count.AppearanceCell.Options.UseTextOptions = true;
            this.Count.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Count.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Count.AppearanceHeader.Options.UseTextOptions = true;
            this.Count.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Count.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Count.Caption = "Số sóng";
            this.Count.DisplayFormat.FormatString = "#,##0";
            this.Count.FieldName = "Count";
            this.Count.MaxWidth = 75;
            this.Count.MinWidth = 75;
            this.Count.Name = "Count";
            this.Count.OptionsColumn.AllowEdit = false;
            this.Count.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Count.Visible = true;
            this.Count.VisibleIndex = 8;
            // 
            // Rate
            // 
            this.Rate.AppearanceCell.Options.UseTextOptions = true;
            this.Rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Rate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Rate.AppearanceHeader.Options.UseTextOptions = true;
            this.Rate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Rate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Rate.Caption = "Sóng TB(%)";
            this.Rate.DisplayFormat.FormatString = "#,##0.0";
            this.Rate.FieldName = "Rate";
            this.Rate.MaxWidth = 75;
            this.Rate.MinWidth = 75;
            this.Rate.Name = "Rate";
            this.Rate.OptionsColumn.AllowEdit = false;
            this.Rate.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Rate.Visible = true;
            this.Rate.VisibleIndex = 9;
            // 
            // frmRealTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 478);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmRealTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealTime";
            this.VisibleChanged += new System.EventHandler(this.frmRealTime_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCoin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbCoin;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Coin;
        private DevExpress.XtraGrid.Columns.GridColumn CoinName;
        private DevExpress.XtraGrid.Columns.GridColumn RefValue;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn BottomRecent;
        private DevExpress.XtraGrid.Columns.GridColumn RateValue;
        private DevExpress.XtraGrid.Columns.GridColumn WaveRecent;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraGrid.Columns.GridColumn Rate;
    }
}