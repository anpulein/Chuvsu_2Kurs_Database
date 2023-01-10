namespace WebApplicationDataBase.Models
{
    public class Client
    {
        /// <summary>
        /// Id Клиента
        /// </summary>
        public int IdClient { get; set; }
        
        public string FullName
        {
            get => $"{FirstName} {Surname} {LastName}";
            set {}
        }
        
        /// <summary>
        /// Фамилия
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Место жительства
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string NumberPassport { get; set; }
        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string SeriesPassport { get; set; }
        /// <summary>
        /// Адрес регистрации
        /// </summary>
        public string AddressPassport { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }
        /// <summary>
        /// Лецевой счет
        /// </summary>
        public string BankBook { get; set; }
        
        public string Operations { get; set; }
    }
}