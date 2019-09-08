using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStaff : MonoBehaviour
{
    int crystalNum;
    Material[] mat;
    public Material normalMat;
    C_STATE state;

    private void Start()
    {
        GetComponent<MeshRenderer>().material = normalMat;
        state = C_STATE.EMPTY;
        crystalNum = 0;
        mat = new Material[5];
        mat[0] = Resources.Load("Nature/Trans/Main_Objects/CCrystal/Crystal_Blue", typeof(Material)) as Material;
        mat[1] = Resources.Load("Nature/Trans/Main_Objects/CCrystal/Crystal_White", typeof(Material)) as Material;
        mat[2] = Resources.Load("Nature/Trans/Main_Objects/CCrystal/Crystal_Red", typeof(Material)) as Material;
        mat[3] = Resources.Load("Nature/Trans/Main_Objects/CCrystal/Crystal_Black", typeof(Material)) as Material;
        mat[4] = Resources.Load("Nature/Trans/Main_Objects/CCrystal/Crystal_Empty", typeof(Material)) as Material;
    }
    
    void Update()
    {
    }

    public void ChangeMaterial()
    {
        switch (state)
        {
            case C_STATE.BLUE:
                GetComponent<MeshRenderer>().material = mat[0];
                break;
            case C_STATE.WHITE:
                GetComponent<MeshRenderer>().material = mat[1];
                break;
            case C_STATE.RED:
                GetComponent<MeshRenderer>().material = mat[2];
                break;
            case C_STATE.BLACK:
                GetComponent<MeshRenderer>().material = mat[3];
                break;
            case C_STATE.EMPTY:
                GetComponent<MeshRenderer>().material = mat[4];
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
