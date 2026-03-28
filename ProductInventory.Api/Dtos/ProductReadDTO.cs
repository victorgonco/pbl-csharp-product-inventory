namespace ProductInventory.Api.Dtos
{
    public class ProductReadDTO
    {
        protected long Id {get;set;}
        protected string Name {get;set;}
        protected bool Active {get;set;}

        public ProductReadDTO()
        {
            this.Id = 0;
            this.Name = "Produto vazio";
            this.Active = false;
        }

        public ProductReadDTO(long Id, string Name, bool Active)
        {
            this.Id = Id;
            this.Name = Name;
            this.Active = Active;
        }
    }

     public class ProductDetailsReadDTO : ProductReadDTO
    {
        protected double Price {get;set;}
        protected int Quantity {get;set;} 
        protected DateTime CreatedAt {get;set;}

        public ProductDetailsReadDTO(long Id, string Name, double Price, int Quantity, bool Active, DateTime CreatedAt)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Active = Active;
            this.CreatedAt = CreatedAt;
        }
    }
}