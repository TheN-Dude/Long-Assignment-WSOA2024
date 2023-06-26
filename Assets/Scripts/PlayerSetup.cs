using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetup : MonoBehaviour
{
    public int Number;

    public Material Engineer;
    public Material Pilot;
    public Material Diver;
    public Material Explorer;
    public Material Messenger;
    public Material Navigator;

    public GameObject Player1;
    public GameObject Player2;

    public LayerMask InteractLayer;

    private GameObject Gate;
    private Transform CorrectGate;

    public GameObject EngineerCard;
    public GameObject ExplorerCard;
    public GameObject PilotCard;
    public GameObject DiverCard;
    public GameObject NavigatorCard;
    public GameObject MessngerCard;

    private void Start()
    {
        Adventurer();
        if (Number == 1)
        {
            GetComponent<Renderer>().material = Engineer;
            EngineerAdventurer();
        }
        else if (Number == 2)
        {
            GetComponent<Renderer>().material = Pilot;
            PilotAdventurer();
        }
        else if (Number == 3)
        {
            GetComponent<Renderer>().material = Diver;
            DiverAdventurer();
        }
        else if (Number == 4)
        {
            GetComponent<Renderer>().material = Explorer;
            ExplorerAdventurer();
        }
        else if (Number == 5)
        {
            GetComponent<Renderer>().material = Messenger;
            MessengerAdventurer();
        }
        else if (Number == 6)
        {
            Player1.GetComponent<Renderer>().material = Navigator;
            NavigatorAdventurer();
        }
        transform.position = Vector3.MoveTowards(transform.position, CorrectGate.position, 5f);
    }
    void Update()
    {

    }
    private void Adventurer()
    {
        Dictionary<int, string> Adventurer = new Dictionary<int, string>();

        Adventurer.Add(1, "Engineer");
        Adventurer.Add(2, "Pilot");
        Adventurer.Add(3, "Diver");
        Adventurer.Add(4, "Explorer");
        Adventurer.Add(5, "Messenger");
        Adventurer.Add(6, "Navigator");

        Number = UnityEngine.Random.Range(1, 6);

        Debug.Log(Adventurer[Number]);
    }
    void EngineerAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Bronze Gate");
        CorrectGate = Gate.transform;
        EngineerCard.SetActive(true);
    }
    void PilotAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Fool's Landing");
        CorrectGate = Gate.transform;
        PilotCard.SetActive(true);
    }
    void DiverAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Iron Gate");
        CorrectGate = Gate.transform;
        DiverCard.SetActive(true);
    }
    void ExplorerAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Copper Gate");
        CorrectGate = Gate.transform;
        ExplorerCard.SetActive(true);
    }
    void MessengerAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Silver Gate");
        CorrectGate = Gate.transform;
        MessngerCard.SetActive(true);
    }
    void NavigatorAdventurer()
    {
        Gate = GameObject.FindGameObjectWithTag("Golden Gate");
        CorrectGate = Gate.transform;
        NavigatorCard.SetActive(true);
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if (InteractLayer == 6)
        {
            Debug.Log("Board found");
        }
        else
        {
            Debug.Log("Board not found");
        }
    }*/

}
