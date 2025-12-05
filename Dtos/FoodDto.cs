namespace FoodMgtApp.Dtos
{
    public class FoodDto
    {
         
        public int Id { get; set;}
        public string Name{get;set;} = default!;
        public string Description{get;set;} = default!;
        public decimal Price{get; set;} 
        public int CategoryId{get;set;}
        public int Quantity{get;set;}

      
    }
    public record RegisterFoodRequest(int CategoryId,string Name, string Description,decimal Price,int Quantity);
      
    public record RegisterFoodResponse(int Id,string Name);
}