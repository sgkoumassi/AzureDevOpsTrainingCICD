using System;
using System.Collections.Generic;

namespace DelegateUses
{
    class MessageAleatoire
    {
        private List<string> messages;
        public MessageAleatoire(IEnumerable<string> messages)
        {
            this.messages = new List<string>(messages);
        }
        public void Afficher()
        {
            int indice = new Random().Next(this.messages.Count);
            Console.WriteLine(this.messages[indice]);
        }
    }
}
