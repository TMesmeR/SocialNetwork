using SocialNetwork.BLL.Exceptions;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        private readonly IFriendRepository _friendRepository;

        public FriendService(IFriendRepository friendRepository)
        {
            _friendRepository = friendRepository;
        }

        public void AddFriend(int userId, int friendId)
        {
            FriendEntity friendEntity = new FriendEntity
            {
                user_id = userId,
                friend_id = friendId
            };

            _friendRepository.Create(friendEntity);
        }
    }
}
