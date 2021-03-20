using System;
using System.Collections.Generic;

namespace Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser _user)
        {
            Console.WriteLine("Mediator broadcasting message...");
            foreach (var user in users)
            {
                if(user != _user)
                user.RecieveMessage(message);
            }
        }
    }
}
