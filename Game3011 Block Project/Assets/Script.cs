using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Script : MonoBehaviour
{
    public Sprite sprite;
    public float[,] Grid;
    public float SweetSpot, GridcountX,GridcountY, SweetSpotCounter, MidSpot, WeakSpot, NoSpot;
    int Height, Width, Column, Row, j, i;

    private void Start()
    {
        Height = (int)Camera.main.orthographicSize;
        Width = Height * (Screen.width / Screen.height);
        Column = Width * 2;
        Row = Height * 2;
        Grid = new float[Column, Row];
        for (i = 0; i < Column; i++)
        {
            for (j = 0; j < Row; j++)
            {
                SpawnTile(i, j, 255, 255, 255, NoSpot);
            }
        }

    }
    public void CheckTiles()
    {
        SweetSpot = 2500f; MidSpot = SweetSpot / 2; WeakSpot = MidSpot / 2;
        Height = (int)Camera.main.orthographicSize;
        Width = Height * (Screen.width / Screen.height);
        Column = Width * 2;
        Row = Height * 2;
        Grid = new float[Column, Row];
        for (i = 0; i < Column; i++)
        {
            GridcountY++;
            for (j = 0; j < Row; j++)
            {
                GridcountX++;
                Grid[i, j] = Random.Range(0.0f, 1.0f);
                if (Grid[i, j] >= 0.95 && SweetSpotCounter < 2)
                {
                    Grid[i, j] = SweetSpot;
                    SweetSpotCounter++;

                }
                if (Grid[i, j] != SweetSpot || Grid[i, j] != MidSpot)
                {
                    SpawnTile(i, j, 255, 255, 0, WeakSpot);
                }
                if (Grid[i, j] == SweetSpot)
                {
                    SpawnTile(i, j, 255, 0, 0, SweetSpot);
                }



            }

        }
        CheckAgain();
    }
    private void CheckAgain()
    {
        for (i = 0; i < Column; i++)
        {
            for (j = 0; j < Row; j++)
            {
                if (Grid[i, j] == SweetSpot)
                {

                    Grid[i + 1, j]  = MidSpot;
                    Grid[i + 1, j + 1] = MidSpot;
                    Grid[i, j + 1 ] = MidSpot;
                   



                }

                if (Grid[i, j] == MidSpot)
                {
                    SpawnTile(i, j, 255, 165, 255, MidSpot);
                }
            }
        }
    }
    private void Update()
    {
        

    }

    private void SpawnTile(int x, int y, float valueR, float valueB, float valueG, float NodeValue)
    {
        GameObject g = new GameObject("X: " +x+"y "+y );
        g.transform.position = new Vector3(x - (Width - 0.5f), y - (Height - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(valueR, valueB, valueG);
       
    }
    // Update is called once per frame
  
}
