using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{


    public CardSOjs CSOJs;
    public Image display;






    // Start is called before the first frame update
    void Start()
    {


        display.sprite = CSOJs.CardPic;


    }


}