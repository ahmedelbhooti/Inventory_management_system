namespace inventory_Management_System
{
    internal class SampleDbContext : inventoryMSEntities1
    {
        private object options;

        public SampleDbContext(object options)
        {
            this.options = options;
        }
    }
}