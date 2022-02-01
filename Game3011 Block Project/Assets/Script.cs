using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Script : MonoBehaviour
{
    public Sprite sprite;
    public float[,] Grid;
    int Height, Width, Column, Row;
    private void Start()
    {
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
                SpawnTile(i,j, Grid[i,j]);
            }
        }
    }

    private void SpawnTile(int x, int y, float value)
    {
        GameObject g = new GameObject("X: " +x+"y "+y );
        g.transform.position = new Vector3(x - (Width - 0.5f), y - (Height - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(value, value, value);
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
}
