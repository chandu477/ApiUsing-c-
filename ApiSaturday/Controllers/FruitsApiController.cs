using Microsoft.AspNetCore.Mvc;

namespace ApiSaturday.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class FruitsApiController:ControllerBase{

public List<String>fruits =new List<string>(){

    "Apple",
    "Banana",
    "Cherry",
    "Date",
    "Elderberry",
    "Fig",
    "Grape",
    "Honeydew"

};
      [HttpGet]
    public List<String> GetFruits(){
    return fruits;
    }
[HttpGet("{id}")]
    public String GetFruitByIndex(int id){
    return fruits.ElementAt(id);
    }
        [HttpDelete("{id}")]
        public void DeleteFruitByIndex(int id){
          if (id >= 0)
    {
        fruits.RemoveAt(id);
      
    }
 
        }
    }
}