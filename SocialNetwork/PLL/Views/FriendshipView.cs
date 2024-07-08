using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendshipView
    {
        private readonly UserService _userService;
        private readonly FriendService _friendService;

        public FriendshipView(UserService userService, FriendService friendService)
        {
            _userService = userService;
            _friendService = friendService;
        }

        public void Show(User currentUser)
        {
            Console.Write("Введите почтовый адрес друга: ");
            string friendEmail = Console.ReadLine();

            try
            {
                User friendUser = _userService.FindByEmail(friendEmail);

                _friendService.AddFriend(currentUser.Id, friendUser.Id);

                SuccessMessage.Show($"Пользователь {friendUser.FirstName} {friendUser.LastName} успешно добавлен в друзья.");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с указанным почтовым адресом не найден.");
            }
            catch (Exception ex)
            {
                AlertMessage.Show($"Произошла ошибка при добавлении в друзья: {ex.Message}");
            }
        }
    }
}
