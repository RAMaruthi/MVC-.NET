using System.Collections.Generic;

namespace WebAppMVC.CurdOpertion
{
    public interface ICarInfoRepo
    {
        void AddNewCar(CarInfo info);
        void DeleteCar(int entryId);
        CarInfo FindCar(int id);
        List<CarInfo> GetAllCars();
        void UpdateCar(CarInfo carInfo);
    }
}