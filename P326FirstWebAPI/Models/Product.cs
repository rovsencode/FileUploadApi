namespace P326FirstWebAPI.Models
{
    public class Product:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get;set; }
    }
}
