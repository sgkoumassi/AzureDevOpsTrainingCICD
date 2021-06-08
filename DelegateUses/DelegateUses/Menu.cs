using System;
namespace DelegateUses
{
    class Menu
    {
        private string titre;
        private Action action;
        private ActionDeMenu action_menu;
        public delegate void ActionDeMenu(Menu m); 
        public Menu(string titre, Action action = null)
        {
            this.titre = titre;
            this.action = action;
        }
        public Menu(string titre, ActionDeMenu action_menu)
        {
            this.titre = titre;
            this.action_menu = action_menu;
        }
        public string Titre
        {
            get => titre;
        }

        public void Effectuer()
        {
            action?.Invoke();
            action_menu?.Invoke(this);
        }
        
    }
}