using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration du thread
            Thread myThread;

            // Instanciation du thread, on spécifie dans le 
            // délégué ThreadStart le nom de la méthode qui
            // sera exécutée lorsque l'on appelle la méthode
            // Start() de notre thread.
            myThread = new Thread(new ThreadStart(ThreadLoop));

            // Lancement du thread
            Console.WriteLine("Lancement du thread...");
            myThread.Start();
          
            // Lancement du threadPool
            Console.WriteLine("Lancement du thread pool...");
            ThreadPool.QueueUserWorkItem(HelloWorldFromThreadPool);

            // Appel de la task
            Task taskVoid = Task.Run(() => { HelloWorldFromTask(); });
            Console.WriteLine("Statut du taskVoid : {0}", taskVoid.Status);
            // Appel du task qui retourn une valeur
            Task<string> taskReturnValue = Task.Run(new Func<string>(TaskThatReturnValue));
            Console.WriteLine(taskReturnValue.Result);
            Console.WriteLine("Statut du taskReturnValue : {0}", taskReturnValue.Status);

        }

        // Cette méthode est appelée lors du lancement du thread
        // C'est ici qu'il faudra faire notre travail.
        public static void ThreadLoop()
        {
            // Tant que le thread n'est pas tué, on travaille
            while (Thread.CurrentThread.IsAlive)
            {
                
                Console.WriteLine("Je travaille guys...");
                Thread.Sleep(5000);
            }
        }

        // Creation d'un threadpool
        private static void HelloWorldFromThreadPool(object data)
        {
            Console.WriteLine("Hello World depuis une tâche");
        }

        // Creation d'un task
        private static void HelloWorldFromTask()
        {
            Console.WriteLine("Hello world depuis un Task");
        }

        // Task qui retourn une valeur
        private static string TaskThatReturnValue()
        {
            return "Une chaîne d'autre Task...";
        }

    }
}
