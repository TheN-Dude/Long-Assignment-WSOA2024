using System.Collections;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    private int ActionCounter = 0;
    private int Player2MovementCounter = 0;
    public bool PlayerOne = true;

    [Header("ActionManagers: ")]
    public GameObject Tile;
    public GameObject MoveButton;
    public GameObject ShoreUpButton;
    public GameObject TradeButton;
    public GameObject CollectButton;
    public GameObject ActionScreen;

    void Start()
    {
     
    }
    void Update()
    {
        if (ActionCounter == 3)
        {
            ActionCounter = 0;
            Debug.Log("Turn is over");
            PlayerOne = false;
            MoveButton.SetActive(false);
            ShoreUpButton.SetActive(false);
            TradeButton.SetActive(false);
            CollectButton.SetActive(false);
            ActionCounter = 0;
            GameManger.GMInstance.UpdateGameState(GameManger.GameState.P2Turn);
        }
    }
    IEnumerator PlayerCoroutine()
    {
        yield return new WaitForSeconds(3);
    }

    public void ShoreUp()
    {
        //Brad code
    }

    public void Trade()
    {
        //Nigel code
        //Button accesess code from CardManager
    }

    public void CollectTreasure()
    {
        //Nigel code
        CardManger.CMInstance.InvenCheckAll();
        CardManger.CMInstance.InvenCheckAll2();
    }

    public void ButtonClick()
    {
        ActionCounter++;
        Debug.Log(ActionCounter.ToString());
    }

    public void FinishTurn()
    {
        if (PlayerOne == true)
        {
            PlayerOne = false;
            MoveButton.SetActive(true);
            ShoreUpButton.SetActive(true);
            TradeButton.SetActive(true);
            CollectButton.SetActive(true);
        }
        else if (PlayerOne == false) 
        {
           
            PlayerOne = true;
            MoveButton.SetActive(true);
            ShoreUpButton.SetActive(true);
            TradeButton.SetActive(true);
            CollectButton.SetActive(true);
            GameManger.GMInstance.UpdateGameState(GameManger.GameState.P1Turn);
        }
    }
}
