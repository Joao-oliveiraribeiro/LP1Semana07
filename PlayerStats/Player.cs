namespace PlayerStats
{
    public class Player
    {
        private float _highScore;
        private int _playedGames;
        private int _wonGames;

        public float HighScore
        {
            get => _highScore;
            set
            {
                if (value > _highScore)
                {
                    _highScore = value;
                }
            }
        }

        public string Name { get; }

        public float WinRate
        {
            get
            {
                if (_playedGames == 0)
                {
                    return 0;
                }
                return (float)_wonGames / _playedGames;
            }
        }