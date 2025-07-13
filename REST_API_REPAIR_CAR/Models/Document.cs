using REST_API_REPAIR_CAR.Models.Base;
using System.ComponentModel;

namespace REST_API_REPAIR_CAR.Models
{
    public class Document : BaseModel
    {
        public Guid CarId { get; set; }
        public Guid WorkerId { get; set; }
        public virtual Car Car { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
