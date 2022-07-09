
namespace CoffeeShop2022.Windows
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PrecioDescIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarPrecioAsciIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarZAPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.OredenarAZPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.AnularIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PrecioDescIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarPrecioAsciIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarZAPorProductoiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OredenarAZPorProductoiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.FiltrariconButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.AnularIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 601);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 4;
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortNumericDownAlt;
            this.PrecioDescIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.PrecioDescIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrecioDescIconButton.Location = new System.Drawing.Point(548, 12);
            this.PrecioDescIconButton.Name = "PrecioDescIconButton";
            this.PrecioDescIconButton.Size = new System.Drawing.Size(57, 63);
            this.PrecioDescIconButton.TabIndex = 1;
            this.PrecioDescIconButton.Text = " Asc";
            this.PrecioDescIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrecioDescIconButton.UseVisualStyleBackColor = false;
            // 
            // OrdenarPrecioAsciIconButton
            // 
            this.OrdenarPrecioAsciIconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarPrecioAsciIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarPrecioAsciIconButton.IconChar = FontAwesome.Sharp.IconChar.SortNumericDown;
            this.OrdenarPrecioAsciIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarPrecioAsciIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarPrecioAsciIconButton.Location = new System.Drawing.Point(485, 12);
            this.OrdenarPrecioAsciIconButton.Name = "OrdenarPrecioAsciIconButton";
            this.OrdenarPrecioAsciIconButton.Size = new System.Drawing.Size(57, 63);
            this.OrdenarPrecioAsciIconButton.TabIndex = 2;
            this.OrdenarPrecioAsciIconButton.Text = " Asc";
            this.OrdenarPrecioAsciIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarPrecioAsciIconButton.UseVisualStyleBackColor = false;
            // 
            // OrdenarZAPorProductoiconButton
            // 
            this.OrdenarZAPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarZAPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarZAPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.OrdenarZAPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarZAPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarZAPorProductoiconButton.Location = new System.Drawing.Point(421, 12);
            this.OrdenarZAPorProductoiconButton.Name = "OrdenarZAPorProductoiconButton";
            this.OrdenarZAPorProductoiconButton.Size = new System.Drawing.Size(58, 63);
            this.OrdenarZAPorProductoiconButton.TabIndex = 3;
            this.OrdenarZAPorProductoiconButton.Text = "Alfa Z-A";
            this.OrdenarZAPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarZAPorProductoiconButton.UseVisualStyleBackColor = false;
            // 
            // OredenarAZPorProductoiconButton
            // 
            this.OredenarAZPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OredenarAZPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OredenarAZPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.OredenarAZPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OredenarAZPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OredenarAZPorProductoiconButton.Location = new System.Drawing.Point(357, 12);
            this.OredenarAZPorProductoiconButton.Name = "OredenarAZPorProductoiconButton";
            this.OredenarAZPorProductoiconButton.Size = new System.Drawing.Size(58, 63);
            this.OredenarAZPorProductoiconButton.TabIndex = 4;
            this.OredenarAZPorProductoiconButton.Text = "Alfa A-Z";
            this.OredenarAZPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OredenarAZPorProductoiconButton.UseVisualStyleBackColor = false;
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.Location = new System.Drawing.Point(642, 12);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(62, 63);
            this.CerrarIconButton.TabIndex = 0;
            this.CerrarIconButton.Text = "Cerrar";
            this.CerrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarIconButton.UseVisualStyleBackColor = false;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // FiltrariconButton
            // 
            this.FiltrariconButton.BackColor = System.Drawing.Color.Transparent;
            this.FiltrariconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrariconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltrariconButton.IconColor = System.Drawing.Color.Blue;
            this.FiltrariconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltrariconButton.Location = new System.Drawing.Point(250, 12);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(62, 63);
            this.FiltrariconButton.TabIndex = 0;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(153, 12);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(62, 63);
            this.EditarIconButton.TabIndex = 0;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarIconButton.UseVisualStyleBackColor = false;
            // 
            // AnularIconButton
            // 
            this.AnularIconButton.BackColor = System.Drawing.Color.Transparent;
            this.AnularIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnularIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.AnularIconButton.IconColor = System.Drawing.Color.Red;
            this.AnularIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AnularIconButton.Location = new System.Drawing.Point(85, 12);
            this.AnularIconButton.Name = "AnularIconButton";
            this.AnularIconButton.Size = new System.Drawing.Size(62, 63);
            this.AnularIconButton.TabIndex = 0;
            this.AnularIconButton.Text = "Anular";
            this.AnularIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AnularIconButton.UseVisualStyleBackColor = false;
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.BackColor = System.Drawing.Color.Transparent;
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.LimeGreen;
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(17, 12);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(62, 63);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoIconButton.UseVisualStyleBackColor = false;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVenta,
            this.colFecha,
            this.colImporte});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1167, 491);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colVenta
            // 
            this.colVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVenta.HeaderText = "Venta Nro.";
            this.colVenta.Name = "colVenta";
            this.colVenta.ReadOnly = true;
            this.colVenta.Width = 103;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 601);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton PrecioDescIconButton;
        private FontAwesome.Sharp.IconButton OrdenarPrecioAsciIconButton;
        private FontAwesome.Sharp.IconButton OrdenarZAPorProductoiconButton;
        private FontAwesome.Sharp.IconButton OredenarAZPorProductoiconButton;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton AnularIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
    }
}