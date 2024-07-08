using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        private readonly UserService _userService;
        private readonly FriendService _friendService;
        public UserMenuView(UserService userService, FriendService friendService)
        {
            _userService = userService;
            _friendService = friendService;
        }
        public void Show(User user)
        {
            while (true)
            {

                Console.WriteLine("Входящие сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("Просмотреть информацию о моём профиле (нажмите 1)");
                Console.WriteLine("Редактировать мой профиль (нажмите 2)");
                Console.WriteLine("Добавить в друзья (нажмите 3)");
                Console.WriteLine("Написать сообщение (нажмите 4)");
                Console.WriteLine("Посмотреть входящие сообщения (нажмите 5)");
                Console.WriteLine("Посмотреть исходящие сообщения (нажмите 6)");
                Console.WriteLine("Выйти из профиля (нажмите 7)");

                string keyValue = Console.ReadLine();

                if (keyValue == "7") break;

                switch (keyValue)
                {
                    case "1": 
                        {
                            StartPoint.userInfoView.Show(user);
                            break; 
                        }
                    case "2":
                        {
                            StartPoint.userDataUpdateView.Show(user);
                            break;
                        }
                    case "3":
                        {
                            StartPoint.friendshipView.Show(user);
                            break;
                        }
                    case "4":
                        {
                            StartPoint.messageSendingView.Show(user);
                            break;
                        }
                    case "5":
                        {
                            StartPoint.userIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }
                    case "6":
                        {
                            StartPoint.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        
                        }
                }

            }

        }
    }
}
