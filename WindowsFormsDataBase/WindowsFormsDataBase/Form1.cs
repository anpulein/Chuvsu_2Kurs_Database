#region Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Configuration;

#endregion

namespace WindowsFormsDataBase
{
    public partial class Form1 : Form
    {

        private OleDbConnection _dbConnection;
        private OleDbCommand _dbCommand;
        private int _indexId = 90;
        public Form1()
        {
            InitializeComponent();
            
            string connectionString = ConfigurationManager.ConnectionStrings["AccessConnection"].ConnectionString;
            _dbConnection = new OleDbConnection(connectionString); // Creating connection

            updateDataBase();
        }

        /// <summary>
        /// Exiting the programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Full Name Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_find_Click(object sender, EventArgs e)
        {
            if (client_list.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет данных для поиска", "Внимание!");
                return;
            }
            
            var fullname = FullName.Text;

            if (fullname == String.Empty)
            {
                MessageBox.Show("Введите ФИО в строку поиска", "Внимание!");
                return;
            }

            var endIndex = client_list.Rows.Count;
            bool isFullNameClient = false;

            for (int i = 0; i < endIndex - 1; i++)
            {
                var client = client_list.Rows[i];
                var fullnameClient = $"{client.Cells[1].Value} {client.Cells[2].Value} {client.Cells[3].Value}";

                if (!fullnameClient.Contains(fullname))
                {
                    client.Visible = false;
                }
                else
                {
                    isFullNameClient = true;
                }
            }

            if (!isFullNameClient)
            {
                MessageBox.Show("Клиента с таким ФИО в базе данных не обнаружжено.", "Внимание!");
                updateDataBase();
            }
        }

        /// <summary>
        /// Save data button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_Click(object sender, EventArgs e)
        {
            // Check count selected rows
            // if (client_list.SelectedRows.Count == 0)
            // {
            //     MessageBox.Show("Выберите строки, которые нужно занести в базу данных", "Внимание!");
            //     return;
            // }
            
            var clientRows = client_list.SelectedRows;
            List<int> indexes = new List<int>();
            int endIndex = clientRows.Count;

            for (int i = 0; i < endIndex; i++)
            {
                var index = clientRows[i].Index;
                if (checkDataInTable(clientRows[i])) return;
                indexes.Add(i);
            }
            
            _dbConnection.Open();

            foreach (var index in indexes)
            {
                Client client = new Client();
                client.IdClient = (int)clientRows[index].Cells[0].Value;
                client.FirstName = clientRows[index].Cells[1].Value.ToString();
                client.Surname = clientRows[index].Cells[2].Value.ToString();
                client.LastName = clientRows[index].Cells[3].Value.ToString();
                client.Phone = clientRows[index].Cells[4].Value.ToString();
                client.Address = clientRows[index].Cells[5].Value.ToString();
                client.NumberPassport = clientRows[index].Cells[6].Value.ToString();
                client.SeriesPassport = clientRows[index].Cells[7].Value.ToString();
                client.AddressPassport = clientRows[index].Cells[8].Value.ToString();
                client.Inn = clientRows[index].Cells[9].Value.ToString();
                client.BankBook = clientRows[index].Cells[10].Value.ToString();

                string query = $"UPDATE Client SET " +
                               $"first_name = '{client.FirstName}'," +
                               $"surname = '{client.Surname}'," +
                               $"last_name = '{client.LastName}'," +
                               $"phone = '{client.Phone}'," +
                               $"address = '{client.Address}'," +
                               $"number_passport = '{client.NumberPassport}'," +
                               $"series_passport = '{client.SeriesPassport}'," +
                               $"address_passport = '{client.AddressPassport}'," +
                               $"inn = '{client.Inn}'," +
                               $"bank_book = '{client.BankBook}'" +
                               $"WHERE Код_клиента = {client.IdClient.ToString()}";

                _dbCommand = new OleDbCommand(query, _dbConnection);

                if (_dbCommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Ошибка выполнения запроса на изменения записей.", "Ошибка!");
                    _dbConnection.Close();
                    return;
                }
            }
            
            MessageBox.Show("Данные изменены.", "Внимание!");
            
            _dbConnection.Close();
        }

        
        /// <summary>
        /// Update data button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_update_Click(object sender, EventArgs e)
        {
            updateDataBase();
        }

        /// <summary>
        /// Adding data in Access button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            // Check count selected rows
            if (client_list.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строки, которые нужно занести в базу данных", "Внимание!");
                return;
            }
            
            var clientRows = client_list.SelectedRows;
            List<int> indexes = new List<int>();
            int endIndex = clientRows.Count;

            for (int i = 0; i < endIndex; i++)
            {
                var index = clientRows[i].Index;
                if (checkDataInTable(clientRows[i])) return;
                indexes.Add(i);
            }
            
            _dbConnection.Open();

            foreach (var index in indexes)
            {
                Client client = new Client();
                client.IdClient = ++_indexId;
                client.FirstName = clientRows[index].Cells[1].Value.ToString();
                client.Surname = clientRows[index].Cells[2].Value.ToString();
                client.LastName = clientRows[index].Cells[3].Value.ToString();
                client.Phone = clientRows[index].Cells[4].Value.ToString();
                client.Address = clientRows[index].Cells[5].Value.ToString();
                client.NumberPassport = clientRows[index].Cells[6].Value.ToString();
                client.SeriesPassport = clientRows[index].Cells[7].Value.ToString();
                client.AddressPassport = clientRows[index].Cells[8].Value.ToString();
                client.Inn = clientRows[index].Cells[9].Value.ToString();
                client.BankBook = clientRows[index].Cells[10].Value.ToString();

                string query = $"INSERT INTO Client (first_name, surname, last_name, phone, address, number_passport, series_passport, address_passport, inn, bank_book) VALUES (" +
                               $"'{client.FirstName}', " +
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
                    MessageBox.Show("Ошибка выполнения запроса на изменения записей.", "Ошибка!");
                    _dbConnection.Close();
                    return;
                }
            }
            
            MessageBox.Show("Данные добавлены.", "Внимание!");
            
            _dbConnection.Close();
        }

        /// <summary>
        /// Deleting data in Access button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_del_Click(object sender, EventArgs e)
        {
             // Check count selected rows
            if (client_list.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строки, которые нужно занести в базу данных", "Внимание!");
                return;
            }
            
            var clientRows = client_list.SelectedRows;
            List<int> indexes = new List<int>();
            int endIndex = clientRows.Count;

            for (int i = 0; i < endIndex; i++)
            {
                var index = clientRows[i].Index;
                indexes.Add(i);
            }
            
            _dbConnection.Open();

            foreach (var index in indexes)
            {
                Client client = new Client();
                client.IdClient = (int)clientRows[index].Cells[0].Value;
                client.FirstName = clientRows[index].Cells[1].Value.ToString();
                client.Surname = clientRows[index].Cells[2].Value.ToString();
                client.LastName = clientRows[index].Cells[3].Value.ToString();
                client.Phone = clientRows[index].Cells[4].Value.ToString();
                client.Address = clientRows[index].Cells[5].Value.ToString();
                client.NumberPassport = clientRows[index].Cells[6].Value.ToString();
                client.SeriesPassport = clientRows[index].Cells[7].Value.ToString();
                client.AddressPassport = clientRows[index].Cells[8].Value.ToString();
                client.Inn = clientRows[index].Cells[9].Value.ToString();
                client.BankBook = clientRows[index].Cells[10].Value.ToString();

                string query = $"DELETE FROM Client WHERE Код_клиента = {client.IdClient.ToString()}";

                _dbCommand = new OleDbCommand(query, _dbConnection);

                if (_dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса на удаления клиентов(а).", "Ошибка!");
                else
                    MessageBox.Show("Данные удалены.", "Внимание!");
            }
            
            _dbConnection.Close();
        }


        /// <summary>
        /// Check data in table
        /// </summary>
        /// <param name="dataGridViewRow"></param>
        /// <returns></returns>
        private bool checkDataInTable(DataGridViewRow dataGridViewRow)
        {
            var cellsCount = dataGridViewRow.Cells.Count;
            var textMessage = $"Не заполнены поля: ";
            bool isError = false;
            dataGridViewRow.Selected = true;
            int[] notIndex = new int[] { 0, 3, 9 };
            for (int i = 0; i < cellsCount; i++)
            {
                if (notIndex.Contains(i)) continue;
                
                if (dataGridViewRow.Cells[i].Value == null)
                {
                    textMessage += $"{client_list.Columns[i].HeaderText} ";
                    isError = true;
                    client_list.CurrentCell = dataGridViewRow.Cells[i];
                }
            }

            if (isError) MessageBox.Show(textMessage, "Внимание!");

            return isError;
        }


        private void updateDataBase()
        {
            client_list.Rows.Clear();
            client_list.Refresh();
            
            // Running Query in Db
            _dbConnection.Open(); // Open connecting
            string query = "SELECT * FROM Client;"; // string query
            _dbCommand = new OleDbCommand(query, _dbConnection); // command
            OleDbDataReader dbDataReader = _dbCommand.ExecuteReader(); // reading data
            
            
            // Check data
            if (!dbDataReader.HasRows)
            {
                MessageBox.Show("Данные были не найдены.", "Ошибка чтения!");
            }
            else
            {
                // Writing data in table forms
                while (dbDataReader.Read())
                {
                    client_list.Rows.Add(
                        dbDataReader["Код_клиента"],
                        dbDataReader["first_name"], dbDataReader["surname"], dbDataReader["last_name"],
                        dbDataReader["phone"], dbDataReader["address"],
                        dbDataReader["number_passport"], dbDataReader["series_passport"],
                        dbDataReader["address_passport"],
                        dbDataReader["inn"], dbDataReader["bank_book"]
                    );
                }

                var indexEnd = client_list.Rows.Count;
                for (int i = 0; i < indexEnd - 1; i++)
                {
                    _indexId = _indexId < (int)(client_list.Rows[i].Cells[0].Value) ? (int)(client_list.Rows[i].Cells[0].Value) : _indexId;
                }
            }
            
            // Exiting connection
            dbDataReader.Close();
            _dbConnection.Close();
        }
    }
}