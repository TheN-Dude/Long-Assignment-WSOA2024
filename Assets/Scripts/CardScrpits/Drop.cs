using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{


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

                if (transform.childCount != 0)
                {

                    Debug.Log(transform.GetChild(0).gameObject);
                }


            }


        }
    }
}