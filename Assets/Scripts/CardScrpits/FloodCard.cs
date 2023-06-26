using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Flood Cards")]


public class FloodCard : ScriptableObject
{
    public string CardName;

    public Sprite CardPic;

    [TextArea]
    public string Descrption;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
