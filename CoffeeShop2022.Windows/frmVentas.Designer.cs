
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CobrarIconButton = new FontAwesome.Sharp.IconButton();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.PrecioDescIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarPrecioAsciIconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.AnularIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Panel1.Controls.Add(this.CobrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.DetalleIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.PrecioDescIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarPrecioAsciIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.FiltrariconButton);
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
            // CobrarIconButton
            // 
            this.CobrarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.CobrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CobrarIconButton.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.CobrarIconButton.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.CobrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CobrarIconButton.Location = new System.Drawing.Point(236, 12);
            this.CobrarIconButton.Name = "CobrarIconButton";
            this.CobrarIconButton.Size = new System.Drawing.Size(62, 63);
            this.CobrarIconButton.TabIndex = 5;
            this.CobrarIconButton.Text = "Cobrar";
            this.CobrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CobrarIconButton.UseVisualStyleBackColor = false;
            this.CobrarIconButton.Click += new System.EventHandler(this.CobrarIconButton_Click);
            // 
            // DetalleIconButton
            // 
            this.DetalleIconButton.BackColor = System.Drawing.Color.Transparent;
            this.DetalleIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleIconButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.DetalleIconButton.IconColor = System.Drawing.Color.Green;
            this.DetalleIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetalleIconButton.Location = new System.Drawing.Point(319, 12);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(62, 63);
            this.DetalleIconButton.TabIndex = 6;
            this.DetalleIconButton.Text = "Detalle";
            this.DetalleIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DetalleIconButton.UseVisualStyleBackColor = false;
            this.DetalleIconButton.Click += new System.EventHandler(this.DetalleIconButton_Click);
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortNumericDesc;
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
            this.OrdenarPrecioAsciIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown19;
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
            this.FiltrariconButton.Location = new System.Drawing.Point(387, 12);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(62, 63);
            this.FiltrariconButton.TabIndex = 0;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
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
            this.AnularIconButton.Click += new System.EventHandler(this.AnularIconButton_Click);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVenta,
            this.colFecha,
            this.colImporte,
            this.colEstado});
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
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
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
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
        private FontAwesome.Sharp.IconButton AnularIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private FontAwesome.Sharp.IconButton CobrarIconButton;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}