// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameProgressManager : MonoBehaviour
// {
//     [SerializeField]
//     private const int TURN_LIMIT_NUMBER = 10;
//     private bool isGameSet = false;
//     private int currentTurn = 0;

//     private InputManager inputManager = new InputManager();
//     private OutputManager outputManager = new OutputManager();

//     // void Start()
//     // {
        
//     // }

//     void Update()
//     {
//         if (inputManager.IsInputPhase)
//         {
//             inputManager.StartInput();
//             return;
//         }

//         if (outputManager.IsOutputPhase)
//         {
//             outputManager.StartOutput();
//             return;
//         }

//         if (isGameSet)
//         {
//             Debug.Log("ゲームクリア");
//             // リザルトへ遷移
//         }
//     }
// }
