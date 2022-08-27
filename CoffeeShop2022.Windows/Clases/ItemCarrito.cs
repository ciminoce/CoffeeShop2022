namespace CoffeeShop2022.Windows.Clases
{
    public class ItemCarrito
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal => Cantidad * Precio;
    }
}
