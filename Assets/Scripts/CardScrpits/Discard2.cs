using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Discard2 : MonoBehaviour, IDropHandler
{
    CardManger cs_CM;
    public GameObject CM;
    int i;
    GameObject type;
    bool addelist = false;
    bool Inhere = false;

    public GameObject SB;
    public GameObject Heli;

    private void Start()
    {
        cs_CM = CM.GetComponent<CardManger>();
    }

    public void OnDrop(PointerEventData eventData)
    {

        // Debug.Log("On Drop");
        if (transform.childCount == 0) //Meaning if there is no children in the object, then you can drop an object in there. But if there is 1, then code does not run
        {

            if (eventData.pointerDrag != null) //if the drag is done the this code runs
            {
                Debug.Log("dRAG IS DONE");
                //invent.RestListy();


                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                Drag drag = eventData.pointerDrag.GetComponent<Drag>(); //Accesing the D&D script and making it realted with this scrpit

                //linked with the drag&Drop scrpit. So the object's, with D&D scrpit's, transform will equal the transform of the object with this JustDrop Scrpit.
                //(So making the D&D object, the child of the JustDrop Object)
                drag.parentafterdrag = transform;

                Debug.Log("In Here Boy");

                Inhere = true;

                if (transform.childCount != 0)
                {
                    #region if tag method
                    /*   if(type.tag == transform.GetChild(0).gameObject.tag)
                         {
                             cs_CM.SwitchItUp(type); 

                         }*/
                    #endregion

                    Debug.Log("In Here Boy");
                }


            }


        }
    }


    public void Capture()
    {
        var Dr = transform.GetChild(0).GetComponent<Drag>();


        Dr.enabled = false;

    }

    private void Update()
    {

        if (transform.childCount != 0 && addelist == false)
        {
            IfTag();
            // Debug.Log(transform.GetChild(0).gameObject);
            addelist = true;
        }

        if (transform.childCount == 0)
        {
            addelist = false;
        }

        if (Inhere == true)
        {
            Capture();

        }

    }

    public void IfTag()
    {
        if (transform.GetChild(0).gameObject.tag == "F1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[0]);
          
            //ChaosControl.CCInt.StartButtonWork();

        }
        else if (transform.GetChild(0).gameObject.tag == "F2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[1]);
          
        }
        else if (transform.GetChild(0).gameObject.tag == "F3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[2]);
        }
        else if (transform.GetChild(0).gameObject.tag == "F4")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[3]);
        }
        else if (transform.GetChild(0).gameObject.tag == "F5")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[4]);
        }
        else if (transform.GetChild(0).gameObject.tag == "M1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[5]);
        }
        else if (transform.GetChild(0).gameObject.tag == "M2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[6]);
        }
        else if (transform.GetChild(0).gameObject.tag == "M3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[7]);
        }
        else if (transform.GetChild(0).gameObject.tag == "M4")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[8]);
        }
        else if (transform.GetChild(0).gameObject.tag == "M5")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[9]);
        }
        if (transform.GetChild(0).gameObject.tag == "C1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[10]);
        }
        else if (transform.GetChild(0).gameObject.tag == "C2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[11]);
        }
        else if (transform.GetChild(0).gameObject.tag == "C3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[12]);
        }
        else if (transform.GetChild(0).gameObject.tag == "C4")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[13]);
        }
        else if (transform.GetChild(0).gameObject.tag == "C5")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[14]);
        }
        else if (transform.GetChild(0).gameObject.tag == "G1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[15]);
        }
        else if (transform.GetChild(0).gameObject.tag == "G2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[16]);
        }
        else if (transform.GetChild(0).gameObject.tag == "G3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[17]);
        }
        else if (transform.GetChild(0).gameObject.tag == "G4")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[18]);
        }
        else if (transform.GetChild(0).gameObject.tag == "G5")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[19]);
        }
        if (transform.GetChild(0).gameObject.tag == "SB1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[20]);
            SB.SetActive(true);
        }
        else if (transform.GetChild(0).gameObject.tag == "SB2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[21]);
            SB.SetActive(true);
        }
        else if (transform.GetChild(0).gameObject.tag == "WR1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[22]);
        }
        else if (transform.GetChild(0).gameObject.tag == "WR2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[23]);
        }
        else if (transform.GetChild(0).gameObject.tag == "WR3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[24]);
        }
        else if (transform.GetChild(0).gameObject.tag == "HL1")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[25]);
            Heli.SetActive(true);
        }
        else if (transform.GetChild(0).gameObject.tag == "HL2")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[26]);
            Heli.SetActive(true);
        }
        else if (transform.GetChild(0).gameObject.tag == "HL3")
        {
            cs_CM.DiscadPile.Add(cs_CM.cardholder[27]);
            Heli.SetActive(true);
        }

    }


    public void GetRidofCard()
    {
        Destroy(transform.GetChild(0).gameObject);
        Inhere = false;

    }


    public void SetFalseSB()
    {
        SB.SetActive(false);
    }

    public void SetFalseHeli()
    {
        Heli.SetActive(false);
    }
}

