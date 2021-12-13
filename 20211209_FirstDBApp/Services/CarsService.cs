using _20211209_FirstDBApp.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _20211209_FirstDBApp.Services
{
    public class CarsService
    {
        private readonly ILogger<CarsService> _logger;
        private SqlConnection _connection;
        private CarPartsService _carPartsService;

        public List<CarModel> _cars = new List<CarModel>();

        public CarsService(ILogger<CarsService> logger, SqlConnection connection, CarPartsService carPartsService)
        {
            _connection = connection;
            _logger = logger;
            _carPartsService = carPartsService;
            _cars = GetAllFromDb();

        }
       
        public List<CarModel> GetAll()
        {
            return _cars;
        }

        public void Create(CarModel car)
        {
            _connection.Open();
            string sql = "INSERT INTO Cars (Model, Year, Color) OUTPUT INSERTED.CarId Values ('" + car.Model +"', '"+ car.Year +"', '" + car.Color + "')";
            using var command = new SqlCommand(sql, _connection);
            int newId = (int)command.ExecuteScalar();
             _cars.Add(new CarModel()
            {
                CarId = newId,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color
            });
            _connection.Close();
        }

        public List<CarModel> GetAllFromDb()
        {
              
            _connection.Open();
            using var command = new SqlCommand("SELECT CarId, Model, Year, Color FROM Cars", _connection); 
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                _cars.Add(new CarModel()
                {
                    CarId = reader.GetInt32(0),
                    Model = reader.GetString(1),
                    Year = reader.GetValue(2).ToString(),
                    Color = reader.GetValue(3).ToString()
                });
            }

            _connection.Close();

            return _cars;
        }
        public CarModel GetById(int id)
        {
            return _cars.FirstOrDefault(x => x.CarId == id);
        }

        public CarWithPartsModel GetWithPartsById(int id)
        {
            CarWithPartsModel carInfo = new CarWithPartsModel();
            carInfo.Car = GetById(id);
            carInfo.Parts = _carPartsService.GetPartsForCarId(id);
            return carInfo;
        }

        public void Update(CarModel car)
        {
            _cars[_cars.IndexOf(_cars.First(x => x.CarId == car.CarId))] = car;
        }

        public void Delete(int id)
        {
            var car = _cars.FirstOrDefault(x => x.CarId == id);
            _cars.Remove(car);
            _connection.Open();
            string sql = "DELETE FROM Cars WHERE CarId = " + id.ToString();
            using var command = new SqlCommand(sql, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }
}
