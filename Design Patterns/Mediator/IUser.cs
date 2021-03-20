using System;

namespace Mediator
{
    public interface IUser
    {
        void RecieveMessage(string message);

        void SendMessage(string message);
    }
}
