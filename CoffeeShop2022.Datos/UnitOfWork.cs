namespace CoffeeShop2022.Datos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoffeShop2022DbContext context;
        public UnitOfWork(CoffeShop2022DbContext context)
        {
            this.context = context;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
