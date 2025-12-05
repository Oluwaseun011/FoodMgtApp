namespace FoodMgtApp.Dtos
{
    public class FoodDto
    {
         
        public int Id { get; set;}
        public string Name{get;set;} = null!;
        public string Description{get;set;} = null!;
        public decimal Price{get; set;} 
        public int CategoryId{get;set;}
        public int Quantity{get;set;}

      
    }
    public record RegisterFoodRequest(string Name, string Description,decimal Price,int Quantity);
      
    public record RegisterFoodResponse(string Name,string description,decimal Price,int Quantity);
}