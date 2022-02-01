using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] public int width, height, increment, _SweetSpot;
    [SerializeField] public GameObject TileSquare, SweetTile;
   [SerializeField] public Sprite MajorRed, PartialOrange, MinorYellow;
    [SerializeField] public SpriteRenderer sprite_TileSquare;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        int Rand = Random.Range(1, 25);
        
        
        sprite_TileSquare = TileSquare.GetComponent<SpriteRenderer>();
        MakeGrid();
        SweetSpot();
            void MakeGrid()
            {
            _SweetSpot = Rand;
            print(_SweetSpot);
            for (int x = 0; x < width; x++)
                {
                for (int y = 0; y < height; y++)
                {

                    var CurrentTile = Instantiate(TileSquare, new Vector2(x, y), Quaternion.identity);
                   
                    if (y == _SweetSpot)
                    {
                        var SweetSpotTile = Instantiate(SweetTile, new Vector2(x, y), Quaternion.identity);
                    }
                    if (x == _SweetSpot)
                    {
                        var SweetSpotTile = Instantiate(SweetTile, new Vector2(x, y), Quaternion.identity);
                    }

                }
                }

            }
        void SweetSpot()
        {
          


        }
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
