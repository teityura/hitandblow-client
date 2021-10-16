namespace HitBlow.Manager
{
    public static class GameManager
    {
        public enum GAME_PHASE
        {
            START,
            INPUT,
            OUTPUT,
            END,
        }

        private static readonly int maxTurn = 10;
        public static int CurrentTurn { private set; get; } = 0;
        public static int CurrentPlayer { private set; get; } = 0;

        public static GAME_PHASE GamePhase { get; private set; } = GAME_PHASE.INPUT;

        public static void SetGamePhase(GAME_PHASE phase)
        {
            GamePhase = phase;

            if (phase == GAME_PHASE.OUTPUT)
            {
                SetNextTurn();
                SetCurrentPlayer();
            }
        }

        private static void SetNextTurn()
        {
            CurrentTurn += 1;
        }

        private static void SetCurrentPlayer()
        {
            CurrentPlayer = CurrentTurn % 2 + 1;
        }

    }
}

