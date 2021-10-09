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
        private static int currentTurn = 0;

        public static GAME_PHASE GamePhase { get; private set; } = GAME_PHASE.INPUT;

        public static void SetGamePhase(GAME_PHASE phase)
        {
            GamePhase = phase;

            if (phase == GAME_PHASE.OUTPUT)
            {
                NextTurn();
            }
        }

        private static void NextTurn()
        {
            currentTurn += 1;
        }
    }
}

