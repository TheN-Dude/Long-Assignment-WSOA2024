using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpCardDisplay : MonoBehaviour
{


    public SpecialCardsSOjs SpCSOJs;
    public Image display;






    // Start is called before the first frame update
    void Start()
    {


        display.sprite = SpCSOJs.CardPic;


    }


}