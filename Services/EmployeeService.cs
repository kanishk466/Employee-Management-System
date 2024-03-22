﻿using Employee_Management_System.Models;
using MongoDB.Driver;

namespace Employee_Management_System.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> _employee;

        public EmployeeService(IEmsDatabaseSetting setting, IMongoClient mongoClient)
        {

            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _employee = database.GetCollection<Employee>(setting.EmployeeCollectionName);

        }


        public Employee Create(Employee employee)
        {
            _employee.InsertOne(employee);
            return employee;
        }

        public List<Employee> Get()
        {
            return _employee.Find(employee => true).ToList();
        }

        public Employee Get(string id)
        {
            return _employee.Find(employee => employee.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _employee.DeleteOne(employee => employee.Id == id);
        }

        public void Update(string id, Employee employee)
        {
            _employee.ReplaceOne(employee => employee.Id == id, employee);
        }
    }
}
