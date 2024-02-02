namespace EventsAndMulticastDelegates
{
    public class GameEventManager
    {
        public delegate void GameEvent();

        //we made them static to prevent that creating an object to call this method

        //create two variables for delegate 
        //public static GameEvent OnGameStart, OnGameOver;
        //now we have two different GameEvent delegate named OnGameStart and OnGameOver.

        //lets make this an event
        public static event GameEvent OnGameStart, OnGameOver;
        //this will prevent us to call wrong methods or implement another method in constructor (look Player class)

        //events cant be triggered from outside of the defined class
        //lets trigger them to start 
        public static void TriggerGameStart()
        {
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                OnGameStart();
            }
        }

        //lets trigger them to stop
        public static void TriggerGameOver()
        {
            if(OnGameOver != null)
            {
                Console.WriteLine("The game is over!");
                OnGameOver();
            }
        }
    }
}
