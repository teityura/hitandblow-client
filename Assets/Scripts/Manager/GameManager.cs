namespace HitBlow.Manager
{
    public static class GameManager
    {
        // private static readonly int maxTern = 10;

        public enum GAME_PHASE
        {
            LOBBY_START,
            LOBBY_INPUT,
            GAME_START,
            GAME_INPUT,
            GAME_OUTPUT,
            GAME_END,
            RESULT_TIMER,
            RESULT_START,
            END,
        }
        public static GAME_PHASE GamePhase { get; private set; } = GAME_PHASE.GAME_INPUT;

        public enum PLAYER
        {
            PLAYER1=1,
            PLAYER2=2,
        }
        public static readonly PLAYER MyPlayer = PLAYER.PLAYER1;
        public static int CurrentPlayerNumber { private set; get; } = (int)PLAYER.PLAYER1;
        public static int WinnerPlayerNumber { private set; get; } = 0;
        public static int CurrentTurn { private set; get; } = 1;
        public static string RoomName = "Room1";

        public static void SetRoomName(string roomName)
        {
            RoomName = roomName;
        }

        public static void SetGamePhase(GAME_PHASE phase)
        {
            if (phase == GAME_PHASE.GAME_OUTPUT)
            {
                SetNextTurn();
                SetCurrentPlayer();
            }
            // NOTE: GAME_ENDフェーズになると、INPUTフェーズには戻さない
            else if (phase == GAME_PHASE.GAME_INPUT)
            {
                if (GamePhase == GAME_PHASE.GAME_END)
                {
                    return;
                }
            }

            GamePhase = phase;
        }

        private static void SetNextTurn()
        {
            CurrentTurn += 1;
        }

        private static void SetCurrentPlayer()
        {
            CurrentPlayerNumber = CurrentTurn % 2 + 1;
        }

        public static void SetWinnerPlayer(int playerNumber)
        {
            WinnerPlayerNumber = playerNumber;
        }

        public static void InitializeTurn()
        {
            CurrentTurn = 0;
        }
    }
}

