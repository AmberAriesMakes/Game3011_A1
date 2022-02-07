using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[System.Serializable]
public class Script : MonoBehaviour
{
    public Sprite sprite;
    public GameObject Intro;
    private BoxCollider2D Spritebox;
    public Text Score;
    public GameObject YOULOSE;
    public float[,] Grid;
    public LayerMask mask;
    public float SweetSpot, GridcountX,GridcountY, SweetSpotCounter, MidSpot, WeakSpot, NoSpot, raylength, score;
    int SCORECOUNT;
    int Height, Width, Column, Row, j, i;

    private void Start()
    {
        YOULOSE.SetActive(false);
        score = 0;
        Height = (int)Camera.main.orthographicSize;
        Width = Height * (Screen.width / Screen.height);
        Column = Width * 2;
        Row = Height * 2;
        Grid = new float[Column, Row];
        for (i = 0; i < Column; i++)
        {
            for (j = 0; j < Row; j++)
            {
                SpawnTile(i, j, 255, 255, 255, NoSpot, "Blank");
            }
        }

    }
    public void CheckTiles()
    {
        Intro.SetActive(false);
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
                    SpawnTile(i, j, 255, 255, 0, WeakSpot, "WeakSpot");
                    
                }
                if (Grid[i, j] == SweetSpot)
                {
                    SpawnTile(i, j, 255, 0, 0, SweetSpot, "SweetSpot");
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
                    SpawnTile(i, j, 255, 165, 0, MidSpot, "MidSpot");
                    score += MidSpot;
                }
            }
        }
    }
    private void Update()
    {

        Score = Score.GetComponent<Text>();
        Score.text = score.ToString();
        if(SCORECOUNT >= 6)
        {
            YOULOSE.SetActive(true);
        }
        if (Input.GetMouseButton(0))
        {


            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && SCORECOUNT < 6)
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                if (hit.collider != null)
                print(hit.collider.name);
                   
                }
                if (hit2D.collider != null && hit2D.collider.name == "WeakSpot")
                {
                    //print(hit2D.);
                    print("HitWeakSpot!");
                    score += WeakSpot;
                    hit2D.collider.name = "NoSpot";
                    SCORECOUNT++;
                }
                if (hit2D.collider != null && hit2D.collider.name == "MidSpot")
                {
                    //print(hit2D.);
                    print("HitMidSpot!");
                    score += MidSpot;
                    hit2D.collider.name = "WeakSpot";
                    SCORECOUNT++;

                }
                if (hit2D.collider != null && hit2D.collider.name == "SweetSpot")
                {
                    //print(hit2D.);
                    print("HitSweetSpot!");
                    score +=SweetSpot;
                    hit2D.collider.name = "MidSpot";
                    SCORECOUNT++;

                    foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
                    {
                        
                    }
                }


            }

            

        }

    }

    private void SpawnTile(int x, int y, float valueR, float valueB, float valueG, float NodeValue, string name)
    {
        GameObject g = new GameObject(name);
        g.AddComponent<BoxCollider2D>();
        g.layer = 4;
        g.transform.position = new Vector3(x - (Width - 0.5f), y - (Height - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(valueR, valueB, valueG);
       
       
    }
   
    // Update is called once per frame

}
