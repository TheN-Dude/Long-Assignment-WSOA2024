using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Regular Cards")]
public class CardSOjs : ScriptableObject
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
