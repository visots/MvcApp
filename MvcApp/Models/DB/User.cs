using System;

namespace MvcApp.Models.DB
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class User
    {
        // Уникальный идентификатор сущности в базе
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}