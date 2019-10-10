/*
 * 1. Регистрация и вход (sms - код / email код) - сделать до 11/10
 * 2. История покупок
 * 3. Категория и товары (картинка в файловой системы)
 * 4. Покупка (корзина), оплата и доставка (Paypal/Qiwi/etc)
 * 5. Коментарии и рейтинги
 * 6. Поиск (пагинация)
 * 
 * Кто сделает 3 версии (Подключенный, автономный и Entity Framework) получит автомат на экзамен.
 */
using Shop.DataAccess;
using Shop.DataAccessAbstract;
using Shop.Domain;
using System;

namespace Shop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Category category = new Category
                {
                    Name = "Бытовая техника",
                    ImagePath = @"C:/data",
                };

                ICategoryRepository repository = new CategoryRepository();
                repository.Add(category);
                var result = repository.GetAll();
            }
        }
        
    }
}
