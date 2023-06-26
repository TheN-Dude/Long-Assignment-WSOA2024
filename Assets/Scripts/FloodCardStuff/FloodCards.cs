using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodCards : MonoBehaviour
{
    //public bool hasBeenPlayed;
    //public int SlotIndex;

    //private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
        //gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Transform Tag is: " + gameObject.tag);
    }
    //public void onMouseDown()
    //{
    //    if (hasBeenPlayed == false)
    //    {
    //        transform.position += Vector3.up * 1;
    //        hasBeenPlayed = true;
    //        gm.availableCardSlots[SlotIndex] = true;
    //        Invoke("MovetoDiscardPile", 2);
    //    }
    //}

    //void MovetoDiscardPile()
    //{
    //    gm.DiscardDeck.Add(this);
    //    gameObject.SetActive(false);
    //}
}
