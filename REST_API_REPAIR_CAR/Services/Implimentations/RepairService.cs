using REST_API_REPAIR_CAR.Models;
using REST_API_REPAIR_CAR.Repositories.Interfaces;
using REST_API_REPAIR_CAR.Services.Interfaces;

namespace REST_API_REPAIR_CAR.Services.Implimentations
{
    public class RepairService : IRepairService
    {
        private IBaseRepository<Document> Documents { get; set; }
        private IBaseRepository<Car> Cars { get; set; }
        private IBaseRepository<Worker> Workers { get; set; }

        public void Work()
        {
            var rand = new Random();
            var carId = Guid.NewGuid();
            var WorkerId = Guid.NewGuid();

            Cars.Create(new Car
            {

            });
        }
    }
}
