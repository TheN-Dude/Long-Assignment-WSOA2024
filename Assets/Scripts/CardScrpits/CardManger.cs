using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManger : MonoBehaviour
{

    public List<GameObject> Cards = new List<GameObject>(10);
    public GameObject[] cardholder = new GameObject[0];
    public List<GameObject> DiscadPile = new List<GameObject>(10);
    public Drop[] Slots = new Drop[10];
    public List<GameObject> Treasures = new List<GameObject>(4);
    public List<GameObject> TreasureBag = new List<GameObject>(0);
    public GameObject WinScreen;

    int SwapIndex;

    int Counter;

    public static CardManger CMInstance;


    #region Testing Game state switch
    public GameObject CardBarP1;
    public GameObject CardBarP2;
    private int FSCounter;
    private int MSCounter;
    private int GCounter;

    private void Awake()
    {
        //In order to have the game state change due to another action in another script, a scrpit has to subsribe to the OnGameStateChanged 
        //This how to subsribe to it.
        CMInstance = this;
        GameManger.OnGameStateChanged += GameMangerForStateChange;

    }

    private void OnDestroy()
    {
        //This to Unsubscribe. It's apperently good practice to avoid data leakage(Will look into that).
        GameManger.OnGameStateChanged -= GameMangerForStateChange;


    }

    //This is the action for the state change.
    // Using it here to set things Active
    private void GameMangerForStateChange(GameManger.GameState state)
    {
        CardBarP1.SetActive(state == GameManger.GameState.P1Turn);
        CardBarP2.SetActive(state == GameManger.GameState.P2Turn);


    }



    public void SwitchOut2()
    {
        //When this Method is inacted, it will run the switch statment, switch the Game state through the enum-switch statement, and select game state for P2.
        GameManger.GMInstance.UpdateGameState(GameManger.GameState.P2Turn);
    }

    public void SwitchOut()
    {

        GameManger.GMInstance.UpdateGameState(GameManger.GameState.P1Turn);
    }

    #endregion


    // Start is called before the first frame update
    void Start()
    {

        SwapIndex = Random.Range(0, 10);


        for (int i = 0; i < 28; i++)
        {
            GameObject temp = Cards[i];
            Cards[i] = Cards[SwapIndex];
            Cards[SwapIndex] = temp;

        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Cards.Count == 0)
        {
            Reshuffle();
        }

        if(TreasureBag.Count == 4)
        {
            WinScreen.SetActive(true);

        }
    }

    #region MethodForDiscard 
    /*
        public enum FloodCards 
        {
            FC1, FC2, FC3, FC4, FC5, FC6, FC7, FC8, FC9, FC10

        }

        public void DiscardSwitch(int dis)
        {
            FloodCards FCs = (FloodCards)dis;
            switch (FCs)
            {
                case FloodCards.FC1:
                    DiscadPile.Add(cardholder[0]);
                    break;
                case FloodCards.FC2:
                    DiscadPile.Add(cardholder[1]);

                    break;
                case FloodCards.FC3:
                    DiscadPile.Add(cardholder[2]);

                    break;
                case FloodCards.FC4:
                    DiscadPile.Add(cardholder[3]);

                    break;
                case FloodCards.FC5:
                    DiscadPile.Add(cardholder[4]);

                    break;
                case FloodCards.FC6:
                    DiscadPile.Add(cardholder[5]);

                    break;
                case FloodCards.FC7:
                    DiscadPile.Add(cardholder[6]);

                    break;
                case FloodCards.FC8:
                    DiscadPile.Add(cardholder[7]);

                    break;
                case FloodCards.FC9:
                    DiscadPile.Add(cardholder[8]);

                    break;
                case FloodCards.FC10:
                    DiscadPile.Add(cardholder[9]);

                    break;
            }



            for (i = 0; i < cardholder.Length; i++)
            {
                if (cardholder[i] = transform.GetChild(0).gameObject)
                {
                    DiscadPile.Add(cardholder[i]);

                }

            }
        }
    */
    #endregion

    #region 2nd Method
    /*
    public void SwitchItUp(GameObject type)
    {

        switch (type.tag)
        {
            case "F1":
                DiscadPile.Add(cardholder[0]);

                break;
            case "F2":
                DiscadPile.Add(cardholder[1]);

                break;
            case "F3":
                DiscadPile.Add(cardholder[2]);

                break;

            case "F4":
                DiscadPile.Add(cardholder[3]);

                break;
            case "F5":
                DiscadPile.Add(cardholder[4]);

                break;
            case "F6":
                DiscadPile.Add(cardholder[5]);

                break;
            case "F7":
                DiscadPile.Add(cardholder[6]);

                break;
            case "F8":
                DiscadPile.Add(cardholder[7]);

                break;
            case "F9":
                DiscadPile.Add(cardholder[8]);

                break;
            case "F10":
                DiscadPile.Add(cardholder[9]);

                break;

        }

    
    }
    */
    #endregion



    public void Reshuffle()
    {
        Cards.AddRange(DiscadPile);
        DiscadPile.Clear();

    }




    public void InsantiateCard()
    {


        var Cardplace = Instantiate(Cards[0], new Vector2(transform.position.x, transform.position.y), transform.rotation);
        Cardplace.transform.SetParent(transform.parent); //Not false because it spawns object outside canvas
        Cards.RemoveAt(0);



    }

    public void InvenCheckAll()
    {
        FSCounter = 0;
        MSCounter = 0;
        Counter = 0;
        GCounter = 0;


        // Going to use this to make a loop that goes through each slot, to see if spefic object through tag inhabits the slost. If there is 4 then action button can be taken.

        for (int i = 0; i < 4; i++)
        {

            var TheSlot = Slots[i];
            //var Child = TheSlot.GetComponentInChildren<Drop>();

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F1")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F2")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F3")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F4")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "F5")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "M1")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M2")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M3")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M4")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "M5")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "G1")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G2")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G3")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G4")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "G5")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "C1")
            {
                Counter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C2")
            {
                Counter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C3")
            {
                Counter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C4")
            {
                Counter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "C5")
            {
                Counter += 1;
                //Debug.Log("FOUND IT4");
            }



        }

        if (FSCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[0]);
            Treasures.Remove(Treasures[0]);
        }
        if (MSCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[1]);
            Treasures.Remove(Treasures[1]);
        }
        if (GCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[3]);
            Treasures.Remove(Treasures[3]);
        }
        if (Counter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[2]);
            Treasures.Remove(Treasures[2]);
        }

        Debug.Log(Counter);

        Debug.Log(GCounter);

        Debug.Log(MSCounter);

        Debug.Log(FSCounter);
    }

    public void InvenCheckAll2()
    {
        FSCounter = 0;
        MSCounter = 0;
        Counter = 0;
        GCounter = 0;


        // Going to use this to make a loop that goes through each slot, to see if spefic object through tag inhabits the slost. If there is 4 then action button can be taken.

        for (int i = 5; i < 9; i++)
        {

            var TheSlot = Slots[i];
            //var Child = TheSlot.GetComponentInChildren<Drop>();

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F1")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F2")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F3")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "F4")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "F5")
            {
                FSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "M1")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M2")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M3")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "M4")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "M5")
            {
                MSCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "G1")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G2")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G3")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "G4")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "G5")
            {
                GCounter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "C1")
            {
                Counter += 1;
                //Debug.Log("FOUND IT");   
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C2")
            {
                Counter += 1;
                //Debug.Log("FOUND IT2");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C3")
            {
                Counter += 1;
                //Debug.Log("FOUND IT3");
            }

            if (TheSlot.transform.GetChild(0).gameObject.tag == "C4")
            {
                Counter += 1;
                //Debug.Log("FOUND IT4");
            }
            if (TheSlot.transform.GetChild(0).gameObject.tag == "C5")
            {
                Counter += 1;
                //Debug.Log("FOUND IT4");
            }



        }

        if (FSCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[0]);
            Treasures.Remove(Treasures[0]);
        }
        if (MSCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[1]);
            Treasures.Remove(Treasures[1]);
        }
        if (GCounter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[3]);
            Treasures.Remove(Treasures[3]);
        }
        if (Counter >= 4)
        {
            Debug.Log("GIVE US");
            TreasureBag.Add(Treasures[2]);
            Treasures.Remove(Treasures[2]);
        }

        Debug.Log(Counter);

        Debug.Log(GCounter);

        Debug.Log(MSCounter);

        Debug.Log(FSCounter);
    }

    public enum SlotEnum
    {
        Slot1,
        Slot2,
        Slot3,
        Slot4,
        Slot5,
        Slot6,
        Slot7,
        Slot8,
        Slot9,
        Slot10


    }

    public void SlotTradeSwitch(int SlotList)
    {
        SlotEnum SlotE = (SlotEnum)SlotList;

        switch (SlotE)
        {
            case SlotEnum.Slot1:
                for (int i = 5; i < 9; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[0].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }

                break;
            case SlotEnum.Slot2:
                for (int i = 5; i < 9; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[1].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot3:
                for (int i = 5; i < 9; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[2].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot4:
                for (int i = 5; i < 9; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[3].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot5:
                for (int i = 5; i < 9; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[4].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot6:
                for (int i = 0; i < 4; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[5].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot7:
                for (int i = 0; i < 4; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[6].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot8:
                for (int i = 0; i < 4; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[7].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot9:
                for (int i = 0; i < 4; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[8].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
            case SlotEnum.Slot10:
                for (int i = 0; i < 4; i++)
                {

                    var TheSlot = Slots[i];
                    if (TheSlot.transform.childCount == 0)
                    {
                        Slots[9].transform.GetChild(0).gameObject.transform.SetParent(TheSlot.transform);

                    }


                }
                break;
        }



    }


}

