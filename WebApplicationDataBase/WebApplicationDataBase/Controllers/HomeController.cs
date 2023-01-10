using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationDataBase.Models;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc.Razor;

namespace WebApplicationDataBase.Controllers
{
    public class HomeController : Controller
    {
        [SupportedOSPlatform("windows")]

        //  String connection
        private OleDbConnection _dbConnection;
        // String working db
        private OleDbCommand _dbCommand;
        private OleDbDataReader _dataReader;
        private static int _idClient = 0;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            var stringConnecting =
                "provider=Microsoft.ACE.OLEDB.16.0;Data Source=D:\\Projects\\Chuvsu\\Chuvsu_2Kurs_Database\\СДЭК.accdb";
            _dbConnection = new OleDbConnection(stringConnecting);
            _logger = logger;
        }

        public IActionResult Index(Client client, string FullNameSearch)
        {
            List<Client> clients = new List<Client>();

            switch (client?.Operations)
            {
                case "add": AddData(client); break;
                case "del": DelData(client); break;
                default: break;
            }
            
            clients = UpdateData();

            if (!String.IsNullOrEmpty(FullNameSearch))
            {
                List<Client> newClient = new List<Client>();
                foreach (var cl in clients)
                {
                    if (cl.FullName.Contains(FullNameSearch))
                    {
                        newClient.Add(cl);
                    }
                }

                clients = newClient;
            }
            
            return View(clients);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void DelData(Client client)
        {
            
            _dbConnection.Open();
            string query = $"DELETE FROM Client WHERE Код_клиента = {client.IdClient.ToString()}";
            _dbCommand = new OleDbCommand(query, _dbConnection);
                
            if (_dbCommand.ExecuteNonQuery() != 1)
            {
                // MessageBox.Show("Ошибка выполнения запроса на изменения записей.", "Ошибка!");
                // _dbConnection.Close();
                // return;
            }
            
            _dbConnection.Close();
        }
        
        private void AddData(Client client)
        {
            
            _dbConnection.Open();
            string query = $"INSERT INTO Client (first_name, surname, last_name, phone, address, number_passport, series_passport, address_passport, inn, bank_book) VALUES ('{client.FirstName}', " +
                           $"'{client.Surname}', " +
                           $"'{client.LastName}', " +
                           $"'{client.Phone}', " +
                           $"'{client.Address}', " +
                           $"'{client.NumberPassport}', " +
                           $"'{client.SeriesPassport}', " +
                           $"'{client.AddressPassport}', " +
                           $"'{client.Inn}', " +
                           $"'{client.BankBook}')";
            _dbCommand = new OleDbCommand(query, _dbConnection);
                
            if (_dbCommand.ExecuteNonQuery() != 1)
            {
                // MessageBox.Show("Ошибка выполнения запроса на изменения записей.", "Ошибка!");
                // _dbConnection.Close();
                // return;
            }
            
            _dbConnection.Close();
        }

        private List<Client> UpdateData()
        {
            _dbConnection.Open();
            string query = "SELECT * FROM Client";

            _dbCommand = new OleDbCommand(query, _dbConnection);
            _dataReader = _dbCommand.ExecuteReader();
            List<Client> clients = new List<Client>();

            if (!_dataReader.HasRows)
            {
                
            }
            else
            {
                while (_dataReader.Read())
                {
                    Client client = new Client();
                    client.IdClient = (int)_dataReader["Код_клиента"];
                    client.FirstName = _dataReader["first_name"].ToString();
                    client.Surname = _dataReader["surname"].ToString();
                    client.LastName = _dataReader["last_name"].ToString();
                    client.Phone = _dataReader["phone"].ToString();
                    client.Address = _dataReader["address"].ToString();
                    client.NumberPassport = _dataReader["number_passport"].ToString();
                    client.SeriesPassport = _dataReader["series_passport"].ToString();
                    client.AddressPassport = _dataReader["address_passport"].ToString();
                    client.Inn = _dataReader["inn"].ToString();
                    client.BankBook = _dataReader["bank_book"].ToString();
                    
                    clients.Add(client);
                }
            }

            _dataReader.Close();
            _dbConnection.Close();
            return clients;
        }
    }
}