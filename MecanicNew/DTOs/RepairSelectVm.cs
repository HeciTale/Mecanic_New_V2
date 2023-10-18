using MecanicNew.Model;

namespace MecanicNew.DTOs
{
    public class RepairSelectVm
    {
       public List<CarDto> Cars {  get; set; }
       public List<CarOwnerDto> Owner { get; set; }
       public List<DriverDto> Drivers { get; set; }
       public List<UserDto> Users { get; set; }

        public CarAddModel AddCar { get; set; }
        public CarAddStringModel AddCarString { get; set; }

        public int RepairPageId { get; set; }

    }
}
