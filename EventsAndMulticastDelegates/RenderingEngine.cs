namespace EventsAndMulticastDelegates
{
    public class RenderingEngine
    {
        //do the same think that you did in AudioSystem class
        public RenderingEngine() 
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver+= GameOver;
        }

        //same method names like in player class
        //lets make them private
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started!");
            Console.WriteLine("Drawing visuals..");
        }

        private void GameOver() 
        {
            Console.WriteLine("Rendering Engine stopped!");
        }
    }
}
