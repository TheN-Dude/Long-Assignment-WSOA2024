using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<FloodCards> FloodDeck = new List<FloodCards>();
    public List<FloodCards> DiscardDeck = new List<FloodCards>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public WaterRiseIndicatorDisplay WaterRiseindicator;

    private void Start()
    {
 
    }

    public void DrawCard()
    {
        if (WaterRiseindicator.WaterRiseTick1 == true|| WaterRiseindicator.WaterRiseTick2 == true)
        {
            if (FloodDeck.Count >= 1)
            {
                FloodCards randCard = FloodDeck[Random.Range(0, FloodDeck.Count)];
                for (int i = 0; i <= 1; i++)
                {
                    if (availableCardSlots[i] == true)
                    {
                        randCard.gameObject.SetActive(true);
                        //randCard.SlotIndex = i;
                        randCard.transform.position = cardSlots[i].position;
                        availableCardSlots[i] = false;
                        FloodDeck.Remove(randCard);
                        randCard.transform.SetParent(cardSlots[i].transform);
                        return;
                    }
                    if (availableCardSlots[1] == false)
                    {
                        Invoke("MoveToDiscard", 2);
                        Debug.Log("2 Flood cards played");
                        //DiscardDeck.Add(randCard);
                    }
                }
            }
           
        }

        if (WaterRiseindicator.WaterRiseTick3 == true || WaterRiseindicator.WaterRiseTick4 == true || WaterRiseindicator.WaterRiseTick5 == true)
        {
            if (FloodDeck.Count >= 1)
            {
                FloodCards randCard = FloodDeck[Random.Range(0, FloodDeck.Count)];
                for (int i = 0; i <= 2; i++)
                {
                    if (availableCardSlots[i] == true)
                    {
                        randCard.gameObject.SetActive(true);
                        //randCard.SlotIndex = i;
                        randCard.transform.position = cardSlots[i].position;
                        availableCardSlots[i] = false;
                        FloodDeck.Remove(randCard);
                        randCard.transform.SetParent(cardSlots[i].transform);
                        
                        if (availableCardSlots[2] == false)
                        {
                            Debug.Log("3 Flood cards played");
                            //DiscardDeck.Add(randCard);
                        }
                        return;
                    }
                }
            }
        }

        if (WaterRiseindicator.WaterRiseTick6 == true || WaterRiseindicator.WaterRiseTick7 == true)
        {
            if (FloodDeck.Count >= 1)
            {
                FloodCards randCard = FloodDeck[Random.Range(0, FloodDeck.Count)];
                for (int i = 0; i <= 3; i++)
                {
                    if (availableCardSlots[i] == true)
                    {
                        randCard.gameObject.SetActive(true);
                        //randCard.SlotIndex = i;
                        randCard.transform.position = cardSlots[i].position;
                        availableCardSlots[i] = false;
                        FloodDeck.Remove(randCard);
                        randCard.transform.SetParent(cardSlots[i].transform);
                        
                        if (availableCardSlots[3] == false)
                        {
                            Debug.Log("4 Flood cards played");
                            //DiscardDeck.Add(randCard);
                        }
                        return;
                    }
                }
            }
        }

        if (WaterRiseindicator.WaterRiseTick8 == true || WaterRiseindicator.WaterRiseTick9 == true)
        {
            if (FloodDeck.Count >= 1)
            {
                FloodCards randCard = FloodDeck[Random.Range(0, FloodDeck.Count)];
                for (int i = 0; i <= 4; i++)
                {
                    if (availableCardSlots[i] == true)
                    {
                        randCard.gameObject.SetActive(true);
                        //randCard.SlotIndex = i;
                        randCard.transform.position = cardSlots[i].position;
                        availableCardSlots[i] = false;
                        FloodDeck.Remove(randCard);
                        randCard.transform.SetParent(cardSlots[i].transform);
                        
                        if (availableCardSlots[4] == false)
                        {
                            Debug.Log("5 Flood cards played");
                            //DiscardDeck.Add(randCard);
                        }
                        return;
                    }
                }
            }
        }

        if (WaterRiseindicator.WaterRiseTick10 == true)
        {
            Debug.Log("GAME OVER! YOU LOSE!");
        }
    }
    /*public void MoveToDiscard()
    {
        FloodCards randCard = FloodDeck[Random.Range(0, FloodDeck.Count)];
        DiscardDeck.Add(randCard);
        randCard.gameObject.SetActive(false);
        availableCardSlots[0] = true;
        availableCardSlots[1] = true;
        availableCardSlots[2] = true;
        availableCardSlots[3] = true;
        availableCardSlots[4] = true;


    }*/
}
