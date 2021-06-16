using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour {

    public enum GameState { Ready = 2, Playing = 4, Pause  = 5, GameOver = 3 };

    public GameState state;

    private void Start()
    {
        state = GameState.Ready;   
    }

    private void Update()
    {
        //switch (state)
        //{
        //    case GameState.Ready:
        //        print("You Are Ready");
        //        break;
        //    case GameState.Playing:
        //        print(" Game Playing");
        //        break;
        //    case GameState.Pause:
        //        print(" Pause");
        //        break;
        //    case GameState.GameOver:
        //        print("GameOver");
        //        break;

        //}


        switch (state)
        {
            case GameState.Ready:
                print((int)GameState.Ready);
                break;
            case GameState.Playing:
                print((int)GameState.Playing);
                break;
            case GameState.Pause:
                print((int)GameState.Pause);
                break;
            case GameState.GameOver:
                print((int)GameState.GameOver);
                break;

        }
    }



}
