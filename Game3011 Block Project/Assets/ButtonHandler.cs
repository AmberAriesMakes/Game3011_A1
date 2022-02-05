using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public int ID;
    public GameObject neightbour0, neightbour1, neightbour2, neightbour3, neightbour4, neightbour5, neightbour6, neightbour7, neightbour8, neightbour9, neightbour10, neightbour11, neightbour12, neightbour13, neightbour14, neightbour15, neightbour16, neightbour17, neightbour18, neightbour19, neightbour20, neightbour21, neightbour22, neightbour23;
    int nID0, nID1, nID2, nID3, nID4, nID5, nID6, nID7, nID8, nID9, nID10, nID11, nID12, nID13, nID14, nID15, nID16, nID17, nID18, nID19, nID20, nID21, nID22, nID23;
    public Button self;
    public SC_FPSController playerController;
    public GameObject player;
    public int value;
    public bool uncovered;
    // Start is called before the first frame update
    void Start()
    {
        uncovered = false;
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<SC_FPSController>();
        self = gameObject.GetComponent<Button>();
        ID = int.Parse(gameObject.name);
        nID0 = ID - 33;
        nID1 = ID - 32;
        nID2 = ID - 31;
        nID3 = ID - 1;
        nID4 = ID + 1;
        nID5 = ID + 31;
        nID6 = ID + 32;
        nID7 = ID + 33;
        nID8 = ID - 66;
        nID9 = ID - 65;
        nID10 = ID - 64;
        nID11 = ID - 63;
        nID12 = ID - 62;
        nID13 = ID - 34;
        nID14 = ID - 30;
        nID15 = ID - 2;
        nID16 = ID + 2;
        nID17 = ID + 30;
        nID18 = ID + 34;
        nID19 = ID + 62;
        nID20 = ID + 63;
        nID21 = ID + 64;
        nID22 = ID + 65;
        nID23 = ID + 66;


        //top row
        if (ID < 32 && ID >= 2)
        {
            neightbour3 = GameObject.Find("" + nID3);
            neightbour4 = GameObject.Find("" + nID4);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }

        //first    
        if (ID == 1)
        {
            neightbour4 = GameObject.Find("" + nID4);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }
        //last on top
        if (ID == 32)
        {
            neightbour3 = GameObject.Find("" + nID3);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
        }
        else
        {
            neightbour0 = GameObject.Find("" + nID0);
            neightbour1 = GameObject.Find("" + nID1);
            neightbour2 = GameObject.Find("" + nID2);
            neightbour3 = GameObject.Find("" + nID3);
            neightbour4 = GameObject.Find("" + nID4);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }
        //left collum
        for (int i = 0; i < 32; i++)
        {
            if (ID == 1 + 32 * i)
            {
                //Debug.Log(1 + 32 * i);
                neightbour0 = null;
                neightbour1 = GameObject.Find("" + nID1);
                neightbour2 = GameObject.Find("" + nID2);
                neightbour3 = null;
                neightbour4 = GameObject.Find("" + nID4);
                neightbour5 = null;
                neightbour6 = GameObject.Find("" + nID6);
                neightbour7 = GameObject.Find("" + nID7);
            }
        }
        //right collum
        for (int i = 0; i < 33; i++)
        {
            if (ID == 0 + 32 * i)
            {
                //Debug.Log(0 + 32 * i);

                neightbour0 = GameObject.Find("" + nID0);
                neightbour1 = GameObject.Find("" + nID1);
                neightbour2 = null;
                neightbour3 = GameObject.Find("" + nID3);
                neightbour4 = null;
                neightbour5 = GameObject.Find("" + nID5);
                neightbour6 = GameObject.Find("" + nID6);
                neightbour7 = null;

            }
        }
        if (value == 100)
        {
            populateNeighborsValue();
            gameObject.GetComponent<Image>().color = Color.cyan;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (value == 50)
        {
            gameObject.GetComponent<Image>().color = Color.blue;
        }
        if (value == 25)
        {
            gameObject.GetComponent<Image>().color = Color.magenta;
        }
        if (value < 25)
        {
            value = 0;
            gameObject.GetComponent<Image>().color = Color.white;
        }

    }

    void onClick()
    {
        if (playerController.ScanMode)
        {
            if (playerController.Scans > 0)
            {
                if (neightbour0 != null)
                {
                    neightbour0.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour0.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour1 != null)
                {
                    neightbour1.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour1.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour2 != null)
                {
                    neightbour2.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour2.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour3 != null)
                {
                    neightbour3.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour3.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour4 != null)
                {
                    neightbour4.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour4.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour5 != null)
                {
                    neightbour5.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour5.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour6 != null)
                {
                    neightbour6.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour6.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                if (neightbour7 != null)
                {
                    neightbour7.transform.GetChild(0).gameObject.SetActive(false);
                    ButtonHandler n0h = neightbour7.GetComponent<ButtonHandler>();
                    n0h.uncovered = true;
                }
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                uncovered = true;
                playerController.Scans--;
            }
        }
        if (playerController.ExtractMode && uncovered)
        {
            if (playerController.Extractions > 0)
            {
                if (neightbour0 != null)
                {
                    ButtonHandler n0h = neightbour0.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour1 != null)
                {
                    ButtonHandler n0h = neightbour1.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour2 != null)
                {
                    ButtonHandler n0h = neightbour2.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour3 != null)
                {
                    ButtonHandler n0h = neightbour3.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour4 != null)
                {
                    ButtonHandler n0h = neightbour4.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour5 != null)
                {
                    ButtonHandler n0h = neightbour5.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour6 != null)
                {
                    ButtonHandler n0h = neightbour6.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour7 != null)
                {
                    ButtonHandler n0h = neightbour7.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour9 != null)
                {
                    ButtonHandler n0h = neightbour9.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour10 != null)
                {
                    ButtonHandler n0h = neightbour10.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour11 != null)
                {
                    ButtonHandler n0h = neightbour11.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour12 != null)
                {
                    ButtonHandler n0h = neightbour12.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour13 != null)
                {
                    ButtonHandler n0h = neightbour13.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour14 != null)
                {
                    ButtonHandler n0h = neightbour14.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour15 != null)
                {
                    ButtonHandler n0h = neightbour15.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour16 != null)
                {
                    ButtonHandler n0h = neightbour16.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour17 != null)
                {
                    ButtonHandler n0h = neightbour17.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour18 != null)
                {
                    ButtonHandler n0h = neightbour18.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour19 != null)
                {
                    ButtonHandler n0h = neightbour19.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour20 != null)
                {
                    ButtonHandler n0h = neightbour20.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour21 != null)
                {
                    ButtonHandler n0h = neightbour21.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour22 != null)
                {
                    ButtonHandler n0h = neightbour22.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour23 != null)
                {
                    ButtonHandler n0h = neightbour23.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                if (neightbour8 != null)
                {
                    ButtonHandler n0h = neightbour8.GetComponent<ButtonHandler>();
                    n0h.value = n0h.value / 2;
                }
                playerController.Extractions--;
                playerController.Score += value;
                value = 0;
            }
        }
    }
    void populateNeighborsValue()
    {
        //first
        if (ID == 1)
        {
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (ID == 2)
        {
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (ID == 31)
        {
            neightbour15 = GameObject.Find("" + nID15);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour22 = GameObject.Find("" + nID23);
        }
        //last top
        if (ID == 32)
        {
            neightbour15 = GameObject.Find("" + nID15);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
        }
        if (ID == 33)
        {
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (ID == 64)
        {
            neightbour13 = GameObject.Find("" + nID13);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
        }
        //top without first and last 2
        if (ID < 31 && ID >= 3)
        {

            neightbour15 = GameObject.Find("" + nID15);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);

        }
        //right collum without first or last 2
        for (int i = 2; i < 31; i++)
        {
            if (ID == 0 + 32 * i)
            {


                neightbour8 = GameObject.Find("" + nID8);
                neightbour9 = GameObject.Find("" + nID9);
                neightbour10 = GameObject.Find("" + nID10);
                neightbour13 = GameObject.Find("" + nID13);
                neightbour15 = GameObject.Find("" + nID15);
                neightbour17 = GameObject.Find("" + nID17);
                neightbour19 = GameObject.Find("" + nID19);
                neightbour20 = GameObject.Find("" + nID20);
                neightbour21 = GameObject.Find("" + nID21);

            }
        }
        //second from right collum without first or last 2
        for (int i = 0; i < 28; i++)
        {
            if (ID == 95 + 32 * i)
            {
                neightbour8 = GameObject.Find("" + nID8);
                neightbour9 = GameObject.Find("" + nID9);
                neightbour10 = GameObject.Find("" + nID10);
                neightbour11 = GameObject.Find("" + nID11);
                neightbour13 = GameObject.Find("" + nID13);
                neightbour15 = GameObject.Find("" + nID15);
                neightbour17 = GameObject.Find("" + nID17);
                neightbour19 = GameObject.Find("" + nID19);
                neightbour20 = GameObject.Find("" + nID20);
                neightbour21 = GameObject.Find("" + nID21);
                neightbour22 = GameObject.Find("" + nID22);
            }
        }
        //left without first or last 2
        for (int i = 3; i < 30; i++)
        {
            if (ID == 1 + 32 * i)
            {
                //Debug.Log(1 + 32 * i);
                neightbour10 = GameObject.Find("" + nID10);
                neightbour11 = GameObject.Find("" + nID11);
                neightbour12 = GameObject.Find("" + nID12);
                neightbour14 = GameObject.Find("" + nID14);
                neightbour16 = GameObject.Find("" + nID16);
                neightbour18 = GameObject.Find("" + nID18);
                neightbour21 = GameObject.Find("" + nID21);
                neightbour22 = GameObject.Find("" + nID22);
                neightbour23 = GameObject.Find("" + nID23);
            }
        }
        //second from left without first or last 2
        for (int i = 2; i < 30; i++)
        {
            if (ID == 2 + 32 * i)
            {
                //Debug.Log(1 + 32 * i);
                neightbour9 = GameObject.Find("" + nID9);
                neightbour10 = GameObject.Find("" + nID10);
                neightbour11 = GameObject.Find("" + nID11);
                neightbour12 = GameObject.Find("" + nID12);
                neightbour14 = GameObject.Find("" + nID14);
                neightbour16 = GameObject.Find("" + nID16);
                neightbour18 = GameObject.Find("" + nID18);
                neightbour20 = GameObject.Find("" + nID20);
                neightbour21 = GameObject.Find("" + nID21);
                neightbour22 = GameObject.Find("" + nID22);
                neightbour23 = GameObject.Find("" + nID23);
            }
        }

        if (ID == 34)
        {
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (ID == 63)
        {
            neightbour13 = GameObject.Find("" + nID13);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (ID == 961)
        {
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
        }
        if (ID == 962)
        {
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour18 = GameObject.Find("" + nID18);
        }
        if (ID == 991)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour17 = GameObject.Find("" + nID17);

        }
        if (ID == 992)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour17 = GameObject.Find("" + nID17);

        }
        if (ID == 993)
        {
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
        }
        if (ID == 994)
        {
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour16 = GameObject.Find("" + nID16);
        }
        if (ID == 1023)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour15 = GameObject.Find("" + nID15);
        }
        if (ID == 1024)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour15 = GameObject.Find("" + nID15);
        }
        if (ID < 1023 && ID >= 994)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour16 = GameObject.Find("" + nID16);
        }
        if (ID < 991 && ID >= 962)
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour18 = GameObject.Find("" + nID18);
        }
        //second from top without first and last 2
        if (ID < 63 && ID >= 34)
        {
            neightbour13 = GameObject.Find("" + nID13);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        else
        {
            neightbour8 = GameObject.Find("" + nID8);
            neightbour9 = GameObject.Find("" + nID9);
            neightbour10 = GameObject.Find("" + nID10);
            neightbour11 = GameObject.Find("" + nID11);
            neightbour12 = GameObject.Find("" + nID12);
            neightbour13 = GameObject.Find("" + nID13);
            neightbour14 = GameObject.Find("" + nID14);
            neightbour15 = GameObject.Find("" + nID15);
            neightbour16 = GameObject.Find("" + nID16);
            neightbour17 = GameObject.Find("" + nID17);
            neightbour18 = GameObject.Find("" + nID18);
            neightbour19 = GameObject.Find("" + nID19);
            neightbour20 = GameObject.Find("" + nID20);
            neightbour21 = GameObject.Find("" + nID21);
            neightbour22 = GameObject.Find("" + nID22);
            neightbour23 = GameObject.Find("" + nID23);
        }
        if (neightbour0 != null)
        {
            ButtonHandler n0h = neightbour0.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour1 != null)
        {
            ButtonHandler n0h = neightbour1.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour2 != null)
        {
            ButtonHandler n0h = neightbour2.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour3 != null)
        {
            ButtonHandler n0h = neightbour3.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour4 != null)
        {
            ButtonHandler n0h = neightbour4.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour5 != null)
        {
            ButtonHandler n0h = neightbour5.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour6 != null)
        {
            ButtonHandler n0h = neightbour6.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour7 != null)
        {
            ButtonHandler n0h = neightbour7.GetComponent<ButtonHandler>();
            n0h.value = 50;
        }
        if (neightbour9 != null)
        {
            ButtonHandler n0h = neightbour9.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour10 != null)
        {
            ButtonHandler n0h = neightbour10.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour11 != null)
        {
            ButtonHandler n0h = neightbour11.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour12 != null)
        {
            ButtonHandler n0h = neightbour12.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour13 != null)
        {
            ButtonHandler n0h = neightbour13.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour14 != null)
        {
            ButtonHandler n0h = neightbour14.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour15 != null)
        {
            ButtonHandler n0h = neightbour15.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour16 != null)
        {
            ButtonHandler n0h = neightbour16.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour17 != null)
        {
            ButtonHandler n0h = neightbour17.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour18 != null)
        {
            ButtonHandler n0h = neightbour18.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour19 != null)
        {
            ButtonHandler n0h = neightbour19.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour20 != null)
        {
            ButtonHandler n0h = neightbour20.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour21 != null)
        {
            ButtonHandler n0h = neightbour21.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour22 != null)
        {
            ButtonHandler n0h = neightbour22.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour23 != null)
        {
            ButtonHandler n0h = neightbour23.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
        if (neightbour8 != null)
        {
            ButtonHandler n0h = neightbour8.GetComponent<ButtonHandler>();
            n0h.value = 25;
        }
    }

}