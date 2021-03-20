using System;

namespace Mediator
{
    public class PremiumUser : IUser
    {
        private ChatMediator _chatMediator;
        private string _name;

        public PremiumUser(ChatMediator chatMediator, string name)
        {
            _chatMediator = chatMediator;
            _name = name;
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine("{0} recieved the message: {1}", _name, message);
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
