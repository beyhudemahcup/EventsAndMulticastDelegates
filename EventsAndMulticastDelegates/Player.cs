namespace EventsAndMulticastDelegates
{
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
            
            //these two lines restricted because we make event OnGameStart and OnGameOver methods
            //GameEventManager.OnGameOver = GameOver;
            //GameEventManager.OnGameStart();
        }

        //lets also make them private 
        private void StartGame ()
        {
            Console.WriteLine($"Player is spawning, the ID is : {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Player is removing, name is {PlayerName}");
        }
    }
}
