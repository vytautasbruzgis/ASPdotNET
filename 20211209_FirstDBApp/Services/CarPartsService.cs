using _20211209_FirstDBApp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _20211209_FirstDBApp.Services
{
    public class CarPartsService
    {
        private readonly ILogger<CarPartsService> _logger;
        private SqlConnection _connection;
        private List<CarPartModel> _carParts = new List<CarPartModel>();

        public CarPartsService(ILogger<CarPartsService> logger, SqlConnection connection)
        {
            _connection = connection;
            _logger = logger;
        }

        public List<CarPartModel> GetPartsForCarId(int id)
        {
            _connection.Open();
            using var command = new SqlCommand($"SELECT CarPartId, CarId, Name, Manufacturer FROM CarParts WHERE CarId = {id}", _connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                _carParts.Add(new CarPartModel()
                {
                    Id = reader.GetInt32(0),
                    CarId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    Manufacturer = reader.GetValue(3).ToString()
                    
                });
            }
            _connection.Close();
            return _carParts;
        }

        public void Create(CarPartModel carPart)
        {
            _connection.Open();
            string sql = "INSERT INTO CarParts (CarId, Name, Manufacturer) OUTPUT INSERTED.CarPartId Values (" + carPart.CarId + ", '" + carPart.Name + "', '" + carPart.Manufacturer + "')";
            using var command = new SqlCommand(sql, _connection);

            int newId = (int)command.ExecuteScalar();
            _carParts.Add(new CarPartModel()
            {
                Id = newId,
                CarId = carPart.CarId,
                Name = carPart.Name,
                Manufacturer = carPart.Manufacturer
            });

            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();
            string sql = $"DELETE FROM CarParts WHERE CarPartId = {id}";
            using SqlCommand command = new SqlCommand(sql, _connection);
            command.ExecuteScalar();
            _connection.Close();
            _carParts = _carParts.Where(x => x.Id != id).ToList();
        }

        public void Update(CarPartModel carPart)
        {
            var tmp = GetPartById(carPart.Id);
            if (tmp != null)
            {
                _connection.Open();
                string sql = $"UPDATE CarParts SET Name='{carPart.Name}', Manufacturer = '{carPart.Manufacturer}' WHERE CarPartId = {carPart.Id}";
                using SqlCommand command = new SqlCommand(sql, _connection);
                command.ExecuteScalar();
                _connection.Close();
            }
        }

        public CarPartModel GetPartById(int id)
        {
            _connection.Open();
            using var command = new SqlCommand($"SELECT CarPartId, CarId, Name, Manufacturer FROM CarParts WHERE CarPartId = {id}", _connection);
            using var reader = command.ExecuteReader();
            reader.Read();
            var carPart = new CarPartModel()
            {
                Id = reader.GetInt32(0),
                CarId = reader.GetInt32(1),
                Name = reader.GetString(2),
                Manufacturer = reader.GetValue(3).ToString()
            };
            _connection.Close();
            return carPart;
        }

    }
}
