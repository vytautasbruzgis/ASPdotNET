using _20211209_FirstDBApp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
