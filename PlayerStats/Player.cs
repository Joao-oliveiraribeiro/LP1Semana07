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

        public Player(string name)
        {
            Name = name;
            _highScore = 0f;
            _playedGames = 0;
            _wonGames = 0;
        }

        public void PlayGame(bool win)
        {
            _playedGames++;  

            if (win)
            {
                _wonGames++;  
            }
        }

        public override string ToString()
        {
            return $"Player: {Name}, HighScore: {_highScore}, " +
                   $"PlayedGames: {_playedGames}, " +
                   $"WonGames: {_wonGames}, " +
                   $"WinRate: {WinRate:P2}";
        }
    }
}