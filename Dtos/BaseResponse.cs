using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Dtos
{
    public class BaseResponse<T>
    {
        public bool Status{get; set;}
        public string Message{get; set;} = default!;
        public T? Data{get; set;}
    }
}