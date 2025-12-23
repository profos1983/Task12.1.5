
using Task12_1_5.Classes;
using Task12_1_5.Utilities;

var users = new User[]
{
    new User() { Login = "Alex", Name = "Алексей", IsPremium = true },
    new User() { Login = "Ivan", Name = "Иван", IsPremium = false },
    new User() { Login = "Alexandr", Name = "Александр", IsPremium = true },
    new User() { Login = "Petr", Name = "Петр", IsPremium = false }
};

Utilities.GretingUsers(users);