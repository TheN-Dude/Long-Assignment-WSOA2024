using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardDisplay : MonoBehaviour
{
    public GameObject Card;

    private void OnMouseDown()
    {
        Card.SetActive(true);
    }

}
