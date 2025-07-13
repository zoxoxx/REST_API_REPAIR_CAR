using REST_API_REPAIR_CAR.Models.Base;

namespace REST_API_REPAIR_CAR.Models
{
    public class Worker : BaseModel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
    }
}
