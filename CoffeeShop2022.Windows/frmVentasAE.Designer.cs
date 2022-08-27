
namespace CoffeeShop2022.Windows
{
    partial class frmVentasAE
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProductosFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TipoProductosPanel = new System.Windows.Forms.Panel();
            this.TipoProductosComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarritoDataGridView = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarritoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TipoProductosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataGridView)).BeginInit();
            this.TotalPanel.SuspendLayout();
            this.CarritoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProductosFlowLayoutPanel);
            this.splitContainer1.Panel1.Controls.Add(this.TipoProductosPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CarritoDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.TotalPanel);
            this.splitContainer1.Panel2.Controls.Add(this.CarritoPanel);
            this.splitContainer1.Size = new System.Drawing.Size(965, 450);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProductosFlowLayoutPanel
            // 
            this.ProductosFlowLayoutPanel.AutoScroll = true;
            this.ProductosFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosFlowLayoutPanel.Location = new System.Drawing.Point(0, 74);
            this.ProductosFlowLayoutPanel.Name = "ProductosFlowLayoutPanel";
            this.ProductosFlowLayoutPanel.Size = new System.Drawing.Size(560, 376);
            this.ProductosFlowLayoutPanel.TabIndex = 1;
            // 
            // TipoProductosPanel
            // 
            this.TipoProductosPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TipoProductosPanel.Controls.Add(this.TipoProductosComboBox);
            this.TipoProductosPanel.Controls.Add(this.label1);
            this.TipoProductosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoProductosPanel.Location = new System.Drawing.Point(0, 0);
            this.TipoProductosPanel.Name = "TipoProductosPanel";
            this.TipoProductosPanel.Size = new System.Drawing.Size(560, 74);
            this.TipoProductosPanel.TabIndex = 0;
            // 
            // TipoProductosComboBox
            // 
            this.TipoProductosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProductosComboBox.FormattingEnabled = true;
            this.TipoProductosComboBox.Location = new System.Drawing.Point(139, 26);
            this.TipoProductosComboBox.Name = "TipoProductosComboBox";
            this.TipoProductosComboBox.Size = new System.Drawing.Size(206, 21);
            this.TipoProductosComboBox.TabIndex = 1;
            this.TipoProductosComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoProductosComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Producto:";
            // 
            // CarritoDataGridView
            // 
            this.CarritoDataGridView.AllowUserToAddRows = false;
            this.CarritoDataGridView.AllowUserToDeleteRows = false;
            this.CarritoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarritoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colPrecio,
            this.colCantidad,
            this.colSubTotal,
            this.colAgregar,
            this.colQuitar});
            this.CarritoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarritoDataGridView.Location = new System.Drawing.Point(0, 74);
            this.CarritoDataGridView.MultiSelect = false;
            this.CarritoDataGridView.Name = "CarritoDataGridView";
            this.CarritoDataGridView.ReadOnly = true;
            this.CarritoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarritoDataGridView.Size = new System.Drawing.Size(401, 295);
            this.CarritoDataGridView.TabIndex = 2;
            this.CarritoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarritoDataGridView_CellContentClick);
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 62;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 57;
            // 
            // colSubTotal
            // 
            this.colSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSubTotal.HeaderText = "SubTot.";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 70;
            // 
            // colAgregar
            // 
            this.colAgregar.HeaderText = "";
            this.colAgregar.Image = global::CoffeeShop2022.Windows.Properties.Resources.add_15px;
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.ReadOnly = true;
            this.colAgregar.Width = 20;
            // 
            // colQuitar
            // 
            this.colQuitar.HeaderText = "";
            this.colQuitar.Image = global::CoffeeShop2022.Windows.Properties.Resources.remove_15px;
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.ReadOnly = true;
            this.colQuitar.Width = 20;
            // 
            // TotalPanel
            // 
            this.TotalPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.TotalPanel.Controls.Add(this.CancelarIconButton);
            this.TotalPanel.Controls.Add(this.CantidadLabel);
            this.TotalPanel.Controls.Add(this.OKIconButton);
            this.TotalPanel.Controls.Add(this.TotalLabel);
            this.TotalPanel.Controls.Add(this.label4);
            this.TotalPanel.Controls.Add(this.label3);
            this.TotalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalPanel.Location = new System.Drawing.Point(0, 369);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(401, 81);
            this.TotalPanel.TabIndex = 1;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.ForeColor = System.Drawing.Color.White;
            this.CantidadLabel.Location = new System.Drawing.Point(232, 11);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(15, 15);
            this.CantidadLabel.TabIndex = 0;
            this.CantidadLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(315, 11);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(15, 15);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // CarritoPanel
            // 
            this.CarritoPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.CarritoPanel.Controls.Add(this.label2);
            this.CarritoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarritoPanel.Location = new System.Drawing.Point(0, 0);
            this.CarritoPanel.Name = "CarritoPanel";
            this.CarritoPanel.Size = new System.Drawing.Size(401, 74);
            this.CarritoPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrito Detalle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.IconSize = 32;
            this.CancelarIconButton.Location = new System.Drawing.Point(268, 37);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 41);
            this.CancelarIconButton.TabIndex = 9;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.IconSize = 32;
            this.OKIconButton.Location = new System.Drawing.Point(141, 38);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 41);
            this.OKIconButton.TabIndex = 10;
            this.OKIconButton.Text = "OK";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // frmVentasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmVentasAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentasAE";
            this.Load += new System.EventHandler(this.frmVentasAE_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TipoProductosPanel.ResumeLayout(false);
            this.TipoProductosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataGridView)).EndInit();
            this.TotalPanel.ResumeLayout(false);
            this.TotalPanel.PerformLayout();
            this.CarritoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel ProductosFlowLayoutPanel;
        private System.Windows.Forms.Panel TipoProductosPanel;
        private System.Windows.Forms.ComboBox TipoProductosComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TotalPanel;
        private System.Windows.Forms.Panel CarritoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CarritoDataGridView;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewImageColumn colAgregar;
        private System.Windows.Forms.DataGridViewImageColumn colQuitar;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
    }
}