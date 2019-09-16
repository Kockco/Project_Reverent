using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStaff : MonoBehaviour
{
    int crystalNum;
    Material mat;
    public Material normalMat;
    public Material[] changeMat;
    C_STATE state;

    private void Start()
    {
        mat = normalMat;
        
        state = C_STATE.EMPTY;
        crystalNum = 0;
    }

    void Update()
    {

    }

    public void ChangeMaterial()
    {
        GetComponent<MeshRenderer>().material = normalMat;
    }
    public void ChangeMaterial(Material changeMate)
    {
        //mat = changeMat;
        //GetComponent<MeshRenderer>().material = mat;

        switch (state)
        {
            case C_STATE.BLUE:
                GetComponent<MeshRenderer>().material = changeMat[0];
                break;
            case C_STATE.WHITE:
                GetComponent<MeshRenderer>().material = changeMat[1];
                break;
            case C_STATE.RED:
                GetComponent<MeshRenderer>().material = changeMat[2];
                break;
            case C_STATE.BLACK:
                GetComponent<MeshRenderer>().material = changeMat[3];
                break;
            case C_STATE.EMPTY:
                GetComponent<MeshRenderer>().material = normalMat;
                break;
        }

    }
    public void ChangeState(C_STATE changeState)
    {
        state = changeState;
    }

    public void ChangeNum(int changeNum) { crystalNum = changeNum; }
    public int GetCrystalNum() { return crystalNum; }
    public C_STATE GetState() { return state; }
    
}
