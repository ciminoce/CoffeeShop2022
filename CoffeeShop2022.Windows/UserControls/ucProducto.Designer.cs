
namespace CoffeeShop2022.Windows.UserControls
{
    partial class ucProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.AgregarIconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLabel.Location = new System.Drawing.Point(0, 0);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(179, 36);
            this.DescripcionLabel.TabIndex = 0;
            this.DescripcionLabel.Text = "label1";
            this.DescripcionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(4, 40);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(82, 107);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 1;
            this.ImagenPictureBox.TabStop = false;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PrecioLabel.Location = new System.Drawing.Point(103, 56);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(47, 15);
            this.PrecioLabel.TabIndex = 2;
            this.PrecioLabel.Text = "label1";
            // 
            // AgregarIconButton
            // 
            this.AgregarIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AgregarIconButton.ForeColor = System.Drawing.Color.White;
            this.AgregarIconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarIconButton.IconColor = System.Drawing.Color.White;
            this.AgregarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarIconButton.IconSize = 32;
            this.AgregarIconButton.Location = new System.Drawing.Point(90, 102);
            this.AgregarIconButton.Name = "AgregarIconButton";
            this.AgregarIconButton.Size = new System.Drawing.Size(86, 45);
            this.AgregarIconButton.TabIndex = 9;
            this.AgregarIconButton.Text = "Agregar";
            this.AgregarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarIconButton.UseVisualStyleBackColor = false;
            // 
            // ucProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AgregarIconButton);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Name = "ucProducto";
            this.Size = new System.Drawing.Size(179, 150);
            this.MouseEnter += new System.EventHandler(this.ucProducto_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucProducto_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Label PrecioLabel;
        public FontAwesome.Sharp.IconButton AgregarIconButton;
    }
}
