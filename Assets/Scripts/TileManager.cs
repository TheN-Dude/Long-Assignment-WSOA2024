using System.Collections.Generic;
using UnityEngine;


public class TileManager : MonoBehaviour
{
    [Header ("Player Manager: ")]
    private PlayerSetup Player1;
    private PlayerSetup Player2;
    public PlayerSetup currentPlayer;
    public PlayerSetup otherPlayer;

    [Header("Flooded Tiles: ")]
    public Sprite FTile1;
    public Sprite FTile2;
    private SpriteRenderer SpriteRenderer;

    [Header("Tiles: ")]
    public Sprite NTile1;

    [Header ("Tiles ")]
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    public GameObject Tile5;
    public GameObject Tile6;
    public GameObject Tile7;
    public GameObject Tile8;
    public GameObject Tile9;
    public GameObject Tile10;
    public GameObject Tile11;
    public GameObject Tile12;
    public GameObject Tile13;
    public GameObject Tile14;
    public GameObject Tile15;
    public GameObject Tile16;
    public GameObject Tile17;
    public GameObject Tile18;
    public GameObject Tile19;
    public GameObject Tile20;
    public GameObject Tile21;
    public GameObject Tile22;
    public GameObject Tile23;
    public GameObject Tile24;

    [Header("Slot Positions: ")]
    public Transform Slot1;
    public Transform Slot2;
    public Transform Slot3;
    public Transform Slot4;
    public Transform Slot5;
    public Transform Slot6;
    public Transform Slot7;
    public Transform Slot8;
    public Transform Slot9;
    public Transform Slot10;    
    public Transform Slot11;
    public Transform Slot12;
    public Transform Slot13;
    public Transform Slot14;
    public Transform Slot15;
    public Transform Slot16;
    public Transform Slot17;
    public Transform Slot18;
    public Transform Slot19;
    public Transform Slot20;
    public Transform Slot21;
    public Transform Slot22;
    public Transform Slot23;
    public Transform Slot24;

    public enum TileState
    {
        Surfaced,
        Flooded,
        Sunk,
    }
    private TileState CurrentState;

    private List<GameObject> tiles = new List<GameObject>();
    private void Start()
    {
        //Calls the AddTiles & Shuffle function
        AddTiles();
        Shuffle();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CurrentState = TileState.Flooded;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            CurrentState = TileState.Sunk;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentState = TileState.Surfaced;
        }

        if (CurrentState == TileState.Flooded)
        {
            Flooded();
        }

        if (CurrentState == TileState.Sunk)
        {
            Sunk();
        }
        if (CurrentState == TileState.Surfaced)
        {
            Surfaced();
        }
    }

    void AddTiles()
    {
        //Adds the tiles to the list
        tiles.Add(Tile1);
        tiles.Add(Tile2);
        tiles.Add(Tile3);
        tiles.Add(Tile4);
        tiles.Add(Tile5);
        tiles.Add(Tile6);
        tiles.Add(Tile7);
        tiles.Add(Tile8);
        tiles.Add(Tile9);
        tiles.Add(Tile10);
        tiles.Add(Tile11);
        tiles.Add(Tile12);
        tiles.Add(Tile13);
        tiles.Add(Tile14);
        tiles.Add(Tile15);
        tiles.Add(Tile16);
        tiles.Add(Tile17);
        tiles.Add(Tile18);
        tiles.Add(Tile19);
        tiles.Add(Tile20);
        tiles.Add(Tile21);
        tiles.Add(Tile22);
        tiles.Add(Tile23);
        tiles.Add(Tile24);
    }

    void Shuffle()
    {
        //Shuffles the tiles' position in the list
        for (int i = 0; i < tiles.Count; i++)
        {
            GameObject temp = tiles[i];
            int randomIndex = Random.Range(i, tiles.Count);
            tiles[i] = tiles[randomIndex];
            tiles[randomIndex] = temp;
        }
        MoveTiles();
    }

    void MoveTiles()
    {
        //Instantiates the tiles after they have been shuffled
        Instantiate(tiles[0], Slot1.position, Slot1.rotation);
        Instantiate(tiles[1], Slot2.position, Slot2.rotation);
        Instantiate(tiles[2], Slot3.position, Slot3.rotation);
        Instantiate(tiles[3], Slot4.position, Slot4.rotation);
        Instantiate(tiles[4], Slot5.position, Slot5.rotation);
        Instantiate(tiles[5], Slot6.position, Slot6.rotation);
        Instantiate(tiles[6], Slot7.position, Slot7.rotation);
        Instantiate(tiles[7], Slot8.position, Slot8.rotation);
        Instantiate(tiles[8], Slot9.position, Slot9.rotation);
        Instantiate(tiles[9], Slot10.position, Slot10.rotation);
        Instantiate(tiles[10], Slot11.position, Slot11.rotation);
        Instantiate(tiles[11], Slot12.position, Slot12.rotation);
        Instantiate(tiles[12], Slot13.position, Slot13.rotation);
        Instantiate(tiles[13], Slot14.position, Slot14.rotation);
        Instantiate(tiles[14], Slot15.position, Slot15.rotation);
        Instantiate(tiles[15], Slot16.position, Slot16.rotation);
        Instantiate(tiles[16], Slot17.position, Slot17.rotation);
        Instantiate(tiles[17], Slot18.position, Slot18.rotation);
        Instantiate(tiles[18], Slot19.position, Slot19.rotation);
        Instantiate(tiles[19], Slot20.position, Slot20.rotation);
        Instantiate(tiles[20], Slot21.position, Slot21.rotation);
        Instantiate(tiles[21], Slot22.position, Slot22.rotation);
        Instantiate(tiles[22], Slot23.position, Slot23.rotation);
        Instantiate(tiles[23], Slot24.position, Slot24.rotation);
    }

    void Surfaced()
    {
        if (GameObject.Find("BreakingBridge(Clone)"))
        {
            SpriteRenderer = GameObject.Find("BreakingBridge(Clone)").GetComponent<SpriteRenderer>();
            SpriteRenderer.sprite = NTile1;
        }
    }
    void Flooded() // possibly add code to cards themselves and then call it in this script
    {
        if (GameObject.Find("BreakingBridge(Clone)"))
        {
            SpriteRenderer = GameObject.Find("BreakingBridge(Clone)").GetComponent<SpriteRenderer>();
            SpriteRenderer.sprite = FTile1;
        }

        if (GameObject.Find("Observatory(Clone)"))
        {
            SpriteRenderer = GameObject.Find("Observatory(Clone)").GetComponent<SpriteRenderer>();
            SpriteRenderer.sprite = FTile2;
        }
    }

    void Sunk() //Again possibly calling this function on the card itself
    {
        if (GameObject.Find("BreakingBridge(Clone)"))
        {
            if (SpriteRenderer.sprite == FTile1)
            {
                var TileFinder = GameObject.Find("BreakingBridge(Clone)");
                Destroy(TileFinder);
            }
        }

        if (GameObject.Find("Observatory(Clone)"))
        {
            if (CurrentState == TileState.Flooded)
            {
                var TileFinder = GameObject.Find("Observatory(Clone)");
                Destroy(TileFinder);
            }
        }
    }

    /* When the card is drawn from the flood pile
     * check if the card is in a flooded state or not
     * TileFinder = GameObject.Find("TileName")
     * if (TileFinder.CurrentState == Tilestate.Flooded)
     * {CurrentState = TileState.Sunk;
     * Destroy(TileFinder);}
     * else if (TileFinder.CurrentState == Tilestate.Surfaced)
     * {CurrentState = TileState.Flooded;}
     */
}
