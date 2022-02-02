using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Script : MonoBehaviour
{
    public Sprite sprite;
    public float[,] Grid;
    public float SweetSpot, MidSpot, WeakSpot;
    int Height, Width, Column, Row;
    private void Start()
    {
        SweetSpot = 90f; MidSpot = SweetSpot / 2; WeakSpot = MidSpot / 2;
        Height = (int)Camera.main.orthographicSize;
        Width = Height * (Screen.width / Screen.height);
        Column = Width * 2;
        Row = Height * 2;
        Grid = new float[Column, Row];
        for (int i = 0; i < Column; i++)
        {
            for (int j= 0; j<Row; j++)
            {
                Grid[i, j] = Random.Range(0.0f, 1.0f);
                if (Grid[i, j] >= 0.9)
                {
                    Grid[i, j] = SweetSpot;
                    
                }
                if (Grid[i,j] != SweetSpot || Grid[i, j] != MidSpot)
                {
                    SpawnTile(i, j, Grid[i, j], Grid[i, j], Grid[i, j]);
                }
                if (Grid[i,j] == SweetSpot)
                {
                    SpawnTile(i, j, 255, 0, 0);
                }


              
            }
           
        }
      
    }
    private void Update()
    {
       
    }

    private void SpawnTile(int x, int y, float valueR, float valueB, float valueG)
    {
        GameObject g = new GameObject("X: " +x+"y "+y );
        g.transform.position = new Vector3(x - (Width - 0.5f), y - (Height - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(valueR, valueB, valueG);
       
    }
    // Update is called once per frame
  
}
