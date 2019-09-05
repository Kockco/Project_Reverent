using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalStairs : CrystalPuzzle
{
    public GameObject[] stairs;
    private void Start()
    {
        c_state = GetComponent<EmptyCrystal>();
        c_state.state = C_STATE.EMPTY;
        stairs = new GameObject[4];
        for (int i = 0; i < 4; i++)
            stairs[i] = transform.GetChild(i).gameObject;
    }
    private void Update()
    {
        if(c_state.isActive == true)
            StairChange();
    }

    void StairChange()
    {
        for (int i = 0; i < 4; i++)
        {
            if (i != (int)c_state.state)
                stairs[i].transform.position = new Vector3(stairs[i].transform.position.x, -2.64f, stairs[i].transform.position.z);
        }
        switch (c_state.state)
        {
            case C_STATE.EMPTY:
                c_state.isActive = false;   
                break;
            case C_STATE.BLUE:
                StairsArrive(stairs[0]);
                stairs[0].SetActive(true);
                if (stairs[0].transform.position.y <=1f)
                stairs[0].transform.Translate(0,5 * Time.deltaTime, 0);
                break;
            case C_STATE.WHITE:
                StairsArrive(stairs[1]);
                stairs[1].SetActive(true);
                if (stairs[1].transform.position.y <= 1f)
                    stairs[1].transform.Translate(0, 5 * Time.deltaTime, 0);
                break;
            case C_STATE.RED:
                StairsArrive(stairs[2]);
                stairs[2].SetActive(true);
                if (stairs[2].transform.position.y <= 1f)
                    stairs[2].transform.Translate(0, 5 * Time.deltaTime, 0);
                break;
            case C_STATE.BLACK:
                StairsArrive(stairs[3]);
                stairs[3].SetActive(true);
                if (stairs[3].transform.position.y <= 1f)
                    stairs[3].transform.Translate(0, 5 * Time.deltaTime, 0);
                break;
        }
    }

    void StairsArrive(GameObject stair)
    {
        if(stair.transform.position.y >=1f)
        {
            c_state.isActive = false;
        }
    }
}
