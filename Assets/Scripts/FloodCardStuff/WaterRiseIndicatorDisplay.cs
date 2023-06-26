using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRiseIndicatorDisplay : MonoBehaviour
{

    public RectTransform WaterRiseTarget1;
    public RectTransform WaterRiseTarget2;
    public RectTransform WaterRiseTarget3;
    public RectTransform WaterRiseTarget4;
    public RectTransform WaterRiseTarget5;
    public RectTransform WaterRiseTarget6;
    public RectTransform WaterRiseTarget7;
    public RectTransform WaterRiseTarget8;
    public RectTransform WaterRiseTarget9;
    public RectTransform WaterRiseTarget10;

    public bool WaterRiseTick1;
    public bool WaterRiseTick2;
    public bool WaterRiseTick3;
    public bool WaterRiseTick4;
    public bool WaterRiseTick5;
    public bool WaterRiseTick6;
    public bool WaterRiseTick7;
    public bool WaterRiseTick8;
    public bool WaterRiseTick9;
    public bool WaterRiseTick10;

    

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        WaterRiseTick1 = true;
        WaterRiseTick2 = false;
        WaterRiseTick3 = false;
        WaterRiseTick4 = false;
        WaterRiseTick5 = false;
        WaterRiseTick6 = false;
        WaterRiseTick7 = false;
        WaterRiseTick8 = false;
        WaterRiseTick9 = false;
        WaterRiseTick10 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (WaterRiseTick1 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget1.transform.position, speed * Time.deltaTime);
        }

        if (WaterRiseTick2 == true)
        {
            WaterRiseTick1 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget2.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick3 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget3.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick4 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget4.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick5 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget5.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick6 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            WaterRiseTick5 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget6.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick7 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            WaterRiseTick5 = false;
            WaterRiseTick6 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget7.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick8 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            WaterRiseTick5 = false;
            WaterRiseTick6 = false;
            WaterRiseTick7 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget8.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick9 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            WaterRiseTick5 = false;
            WaterRiseTick6 = false;
            WaterRiseTick7 = false;
            WaterRiseTick8 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget9.transform.position, speed * Time.deltaTime);
        }
        if (WaterRiseTick10 == true)
        {
            WaterRiseTick1 = false;
            WaterRiseTick2 = false;
            WaterRiseTick3 = false;
            WaterRiseTick4 = false;
            WaterRiseTick5 = false;
            WaterRiseTick6 = false;
            WaterRiseTick7 = false;
            WaterRiseTick8 = false;
            WaterRiseTick9 = false;
            transform.position = Vector2.MoveTowards(transform.position, WaterRiseTarget10.transform.position, speed * Time.deltaTime);
            Debug.Log("GAME OVER!");
        }
    }
}
