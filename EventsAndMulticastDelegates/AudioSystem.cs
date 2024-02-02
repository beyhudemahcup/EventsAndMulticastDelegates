namespace EventsAndMulticastDelegates
{
    public class AudioSystem
    {
        public AudioSystem() 
        {
            //achieve private classes and subscribe them to the OnGameStart and OnGameOver
            //events from GameEventManager
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //same method names like in player class
        //lets make them their access modifiers private for achieve limited access.
        private void StartGame()
        {
            Console.WriteLine("Audio system started!");
            Console.WriteLine("Playing Audio..");
        }

        private void GameOver()
        {
            Console.WriteLine("Audio system stopped!");
        }
    }
}
