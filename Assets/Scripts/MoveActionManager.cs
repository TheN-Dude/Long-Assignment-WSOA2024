using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MoveActionManager : MonoBehaviour
{
    Vector3 targetPosition;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject ActionScreen;

    private MovementTest Actions;
    public GameObject ActionManager;

    private void Start()
    {
        Actions = ActionManager.GetComponent<MovementTest>();
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Actions.PlayerOne == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    targetPosition = hit.point;
                    Player1.transform.position = targetPosition;
                    StartCoroutine(PlayerCoroutine());
                }
            }
        }
        else if (Actions.PlayerOne == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    targetPosition = hit.point;
                    Player2.transform.position = targetPosition;
                    StartCoroutine(PlayerCoroutine());
                }
            }
        }
    }

    IEnumerator PlayerCoroutine()
    {
        yield return new WaitForSeconds(1);
        ActionScreen.SetActive(true);
    }
}
