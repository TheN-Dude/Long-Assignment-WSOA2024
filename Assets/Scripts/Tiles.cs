using UnityEngine;

public class Tiles : MonoBehaviour
{
    public GameObject Highlight;
    public enum TileState
    {
        Surfaced,
        Flooded,
        Sunk,
    }
    public TileState CurrentState;

    private void Start()
    {
        //Sets the tiles state to surfaced
        CurrentState = TileState.Surfaced;
    }

    private void OnMouseEnter()
    {
        //Highlights tile when mouse hovers over it
        Highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        //Stops highlighting card when mouse leaves
        Highlight.SetActive(false); 
    }
}
