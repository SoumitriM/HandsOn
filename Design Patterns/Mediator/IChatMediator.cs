using System;

namespace Mediator
{
    interface IChatMediator
    {
        void AddUser(IUser user);

        void SendMessage(string message, IUser user);
    }
}
