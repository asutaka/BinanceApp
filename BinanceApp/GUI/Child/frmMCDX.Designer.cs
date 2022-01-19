﻿
namespace BinanceApp.GUI.Child
{
    partial class frmMCDX
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet3 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet3 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon7 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon8 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon9 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale2 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule3ColorScale formatConditionRule3ColorScale2 = new DevExpress.XtraEditors.FormatConditionRule3ColorScale();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet4 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet4 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon10 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon11 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon12 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.RateValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RefValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoinName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WaveRecent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BottomRecent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MCDXValue = new DevExpress.XtraGrid.Columns.GridColumn();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(795, 495);
            this.grid.TabIndex = 0;
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
            this.MCDXValue});
            gridFormatRule5.Column = this.RateValue;
            gridFormatRule5.ColumnApplyTo = this.RateValue;
            gridFormatRule5.Name = "FormatRate";
            formatConditionRuleIconSet3.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionIconSet3.CategoryName = "Directional";
            formatConditionIconSetIcon7.PredefinedName = "Arrows3_1.png";
            formatConditionIconSetIcon7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon8.PredefinedName = "Arrows3_2.png";
            formatConditionIconSetIcon8.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            formatConditionIconSetIcon8.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon9.PredefinedName = "Arrows3_3.png";
            formatConditionIconSetIcon9.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon9.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon7);
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon8);
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon9);
            formatConditionIconSet3.Name = "Arrows3Colored";
            formatConditionIconSet3.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet3.IconSet = formatConditionIconSet3;
            gridFormatRule5.Rule = formatConditionRuleIconSet3;
            gridFormatRule6.Column = this.RefValue;
            gridFormatRule6.ColumnApplyTo = this.RefValue;
            gridFormatRule6.Name = "Format0";
            formatConditionRule2ColorScale2.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRule2ColorScale2.PredefinedName = "White, Red";
            gridFormatRule6.Rule = formatConditionRule2ColorScale2;
            gridFormatRule7.Column = this.RateValue;
            gridFormatRule7.ColumnApplyTo = this.CoinName;
            gridFormatRule7.Name = "Format1";
            formatConditionRule3ColorScale2.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRule3ColorScale2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            formatConditionRule3ColorScale2.MaximumColor = System.Drawing.Color.Green;
            formatConditionRule3ColorScale2.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale2.MiddleColor = System.Drawing.Color.White;
            formatConditionRule3ColorScale2.MiddleType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            formatConditionRule3ColorScale2.MinimumColor = System.Drawing.Color.Red;
            formatConditionRule3ColorScale2.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRule3ColorScale2.PredefinedName = "Green, White, Red";
            gridFormatRule7.Rule = formatConditionRule3ColorScale2;
            gridFormatRule8.Column = this.WaveRecent;
            gridFormatRule8.ColumnApplyTo = this.WaveRecent;
            gridFormatRule8.Name = "Format2";
            formatConditionIconSet4.CategoryName = "Symbols";
            formatConditionIconSetIcon10.PredefinedName = "Flags3_1.png";
            formatConditionIconSetIcon11.PredefinedName = "Flags3_2.png";
            formatConditionIconSetIcon11.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            formatConditionIconSetIcon11.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon12.PredefinedName = "Flags3_3.png";
            formatConditionIconSetIcon12.Value = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon12.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon10);
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon11);
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon12);
            formatConditionIconSet4.Name = "Flags3";
            formatConditionIconSet4.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet4.IconSet = formatConditionIconSet4;
            gridFormatRule8.Rule = formatConditionRuleIconSet4;
            this.gridView1.FormatRules.Add(gridFormatRule5);
            this.gridView1.FormatRules.Add(gridFormatRule6);
            this.gridView1.FormatRules.Add(gridFormatRule7);
            this.gridView1.FormatRules.Add(gridFormatRule8);
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // MCDXValue
            // 
            this.MCDXValue.AppearanceCell.Options.UseTextOptions = true;
            this.MCDXValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MCDXValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MCDXValue.AppearanceHeader.Options.UseTextOptions = true;
            this.MCDXValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MCDXValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MCDXValue.Caption = "MCDX";
            this.MCDXValue.DisplayFormat.FormatString = "#,##0.##";
            this.MCDXValue.FieldName = "MCDXValue";
            this.MCDXValue.MaxWidth = 75;
            this.MCDXValue.MinWidth = 75;
            this.MCDXValue.Name = "MCDXValue";
            this.MCDXValue.OptionsColumn.AllowEdit = false;
            this.MCDXValue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.MCDXValue.Visible = true;
            this.MCDXValue.VisibleIndex = 8;
            // 
            // frmMCDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 495);
            this.Controls.Add(this.grid);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmMCDX";
            this.Text = "MCDX";
            this.Load += new System.EventHandler(this.frmMCDX_Load);
            this.VisibleChanged += new System.EventHandler(this.frmMCDX_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Coin;
        private DevExpress.XtraGrid.Columns.GridColumn CoinName;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn MCDXValue;
        private DevExpress.XtraGrid.Columns.GridColumn RateValue;
        private DevExpress.XtraGrid.Columns.GridColumn RefValue;
        private DevExpress.XtraGrid.Columns.GridColumn BottomRecent;
        private DevExpress.XtraGrid.Columns.GridColumn WaveRecent;
    }
}