using REST_API_REPAIR_CAR.Models.Base;

namespace REST_API_REPAIR_CAR.Models
{
    public class Car : BaseModel
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
