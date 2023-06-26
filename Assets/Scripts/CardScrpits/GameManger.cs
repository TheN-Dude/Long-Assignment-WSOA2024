using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // this so that the instatce of this class can be asccesed anywhere
    public static GameManger GMInstance;


    public GameState State;
    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        //Making connecting the instance of this class to the script (Like an easier way to make an instance)
        GMInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateGameState(GameState.P1Turn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.P1Turn:

                ControlP1Turn();
                break;
            case GameState.P2Turn:
                ControlP2Turn();
                break;
        }

        OnGameStateChanged(newState);

    }

    //These are to get specfic things to be done, automatiaclly maybe condtions for switching or actions to be taken upon a switchnor before a switch, like wait somde time or do an action.
    private void ControlP2Turn()
    {

    }

    private void ControlP1Turn()
    {

    }

    public enum GameState
    {
        Start,
        P1Turn,
        P2Turn,
        Win,
        Lose,

    }
}
