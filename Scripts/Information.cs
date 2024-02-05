namespace Assets
{
    public static class Information
    {
        public enum GameState
        {
            Playing, 
            Pause, 
            Win, 
            Lose
        }
        public static GameState CurrentGameState { get; set; } 
    }
}
