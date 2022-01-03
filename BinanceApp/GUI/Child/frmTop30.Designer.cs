
namespace BinanceApp.GUI.Child
{
    partial class frmTop30
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoinName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Value,
            this.Count,
            this.Rate});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.Value.VisibleIndex = 3;
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
            this.Count.VisibleIndex = 4;
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
            this.Rate.VisibleIndex = 5;
            // 
            // frmTop30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 495);
            this.Controls.Add(this.grid);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTop30";
            this.Text = "Top30";
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
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraGrid.Columns.GridColumn Rate;
    }
}