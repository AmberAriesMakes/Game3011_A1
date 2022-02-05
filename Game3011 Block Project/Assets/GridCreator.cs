using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridCreator : MonoBehaviour
{
    public GameObject myButton, resource1, resource2, resource3, resource4, resource5, resource6, resource7, resource8, resource9;
    public ButtonHandler bh1, bh2, bh3, bh4, bh5, bh6, bh7, bh8, bh9;
    public Canvas GameScreen;
    public int i3, rand1,rand2,rand3,rand4,rand5,rand6, rand7, rand8, rand9;

    void Start()
    { 
        rand1 = Random.Range(0, 1025); 
        rand2 = Random.Range(0,1025);  
        rand3 = Random.Range(0,1025);  
        rand4 = Random.Range(0,1025);  
        rand5 = Random.Range(0,1025);  
        rand6 = Random.Range(0,1025);  
        rand7 = Random.Range(0,1025);  
        rand8 = Random.Range(0,1025);  
        rand9 = Random.Range(0,1025);  
        for (int i2 = 0; i2 < 32; i2++) {
            for (int i = 0; i < 32; i++)
            {
                i3++;
                GameObject childObject = Instantiate(myButton, new Vector3(i * 29.0F + 50.0f, 950 - 29.0f * i2, 0), Quaternion.identity) as GameObject;
                childObject.transform.SetParent(GameScreen.transform);
                childObject.name = "" + i3;
            }
        }
   
            resource1 = GameObject.Find("" + rand1);
            bh1 = resource1.GetComponent<ButtonHandler>();
            bh1.value = 100;

            resource2 = GameObject.Find("" + rand2);
            bh2 = resource2.GetComponent<ButtonHandler>();
            bh2.value = 100;

            resource3 = GameObject.Find("" + rand3);
            bh3 = resource3.GetComponent<ButtonHandler>();
            bh3.value = 100;

            resource4 = GameObject.Find("" + rand4);
            bh4 = resource4.GetComponent<ButtonHandler>();
            bh4.value = 100;

            resource5 = GameObject.Find("" + rand5);
            bh5 = resource5.GetComponent<ButtonHandler>();
            bh5.value = 100;

            resource6 = GameObject.Find("" + rand6);
            bh6 = resource6.GetComponent<ButtonHandler>();
            bh6.value = 100;

             resource7 = GameObject.Find("" + rand7);
             bh7 = resource7.GetComponent<ButtonHandler>();
             bh7.value = 100;

            resource8 = GameObject.Find("" + rand8);
            bh8 = resource8.GetComponent<ButtonHandler>();
            bh8.value = 100;

            resource9 = GameObject.Find("" + rand9);
            bh9 = resource9.GetComponent<ButtonHandler>();
            bh9.value = 100;

    }
     void Update()
    {
        
    }
}
