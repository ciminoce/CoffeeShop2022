
namespace CoffeeShop2022.Windows
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarButton = new FontAwesome.Sharp.IconButton();
            this.VentasButton = new FontAwesome.Sharp.IconButton();
            this.ProductosButton = new FontAwesome.Sharp.IconButton();
            this.TipoProductosButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel2.Controls.Add(this.VentasButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProductosButton);
            this.splitContainer1.Panel2.Controls.Add(this.TipoProductosButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CerrarButton
            // 
            this.CerrarButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.ForeColor = System.Drawing.Color.White;
            this.CerrarButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CerrarButton.IconColor = System.Drawing.Color.White;
            this.CerrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarButton.Location = new System.Drawing.Point(634, 280);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(154, 66);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.Text = "Salir";
            this.CerrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarButton.UseVisualStyleBackColor = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // VentasButton
            // 
            this.VentasButton.BackColor = System.Drawing.Color.LimeGreen;
            this.VentasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasButton.ForeColor = System.Drawing.Color.White;
            this.VentasButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.VentasButton.IconColor = System.Drawing.Color.White;
            this.VentasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasButton.Location = new System.Drawing.Point(395, 38);
            this.VentasButton.Name = "VentasButton";
            this.VentasButton.Size = new System.Drawing.Size(154, 66);
            this.VentasButton.TabIndex = 0;
            this.VentasButton.Text = "Ventas";
            this.VentasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VentasButton.UseVisualStyleBackColor = false;
            this.VentasButton.Click += new System.EventHandler(this.VentasButton_Click);
            // 
            // ProductosButton
            // 
            this.ProductosButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ProductosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosButton.ForeColor = System.Drawing.Color.White;
            this.ProductosButton.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.ProductosButton.IconColor = System.Drawing.Color.White;
            this.ProductosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductosButton.Location = new System.Drawing.Point(211, 38);
            this.ProductosButton.Name = "ProductosButton";
            this.ProductosButton.Size = new System.Drawing.Size(154, 66);
            this.ProductosButton.TabIndex = 0;
            this.ProductosButton.Text = "Productos";
            this.ProductosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductosButton.UseVisualStyleBackColor = false;
            this.ProductosButton.Click += new System.EventHandler(this.ProductosButton_Click);
            // 
            // TipoProductosButton
            // 
            this.TipoProductosButton.BackColor = System.Drawing.Color.SandyBrown;
            this.TipoProductosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoProductosButton.ForeColor = System.Drawing.Color.White;
            this.TipoProductosButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.TipoProductosButton.IconColor = System.Drawing.Color.White;
            this.TipoProductosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TipoProductosButton.Location = new System.Drawing.Point(34, 38);
            this.TipoProductosButton.Name = "TipoProductosButton";
            this.TipoProductosButton.Size = new System.Drawing.Size(154, 66);
            this.TipoProductosButton.TabIndex = 0;
            this.TipoProductosButton.Text = "Tipos de Productos";
            this.TipoProductosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TipoProductosButton.UseVisualStyleBackColor = false;
            this.TipoProductosButton.Click += new System.EventHandler(this.TipoProductosButton_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton CerrarButton;
        private FontAwesome.Sharp.IconButton VentasButton;
        private FontAwesome.Sharp.IconButton ProductosButton;
        private FontAwesome.Sharp.IconButton TipoProductosButton;
    }
}

