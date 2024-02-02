using EventsAndMulticastDelegates;

namespace EventAndMulticastDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create an audio system
            AudioSystem audioSystem = new AudioSystem();

            //create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();

            //create player
            Player player1 = new Player("Scooby");
            Player player2 = new Player("Shaggy");
            Player player3 = new Player("Hero");

            /*
            before implementing GameEventManager class
            renderingEngine.StartGame();
            audioSystem.StartGame();
            //spawn players
            player1.StartGame();
            player2.StartGame();

            Console.WriteLine("Game is running, press any key to game over!");
            Console.Read();

            audioSystem.GameOver();
            renderingEngine.GameOver();

            player1.GameOver();
            player2.GameOver();
            */

            //start and end the game takes so much implementation and coding for main class
            //we can assume that the real life examples, there is a lot more method to invoke etc.

            //Multicast Delegation will help to solve this
            //after implementing GameEventManager class
            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game is running, press any key to game over!");
            Console.Read();
            GameEventManager.TriggerGameOver();
        }
    }
}