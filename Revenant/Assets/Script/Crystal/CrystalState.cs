using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum C_STATE { BLUE, WHITE, RED, BLACK, EMPTY }

public class CrystalState : MonoBehaviour
{
    public int myNum;
    public C_STATE state;
    public Material[] mat;
    public GameObject[] colorCrystal;
    public GameObject[] emptyCrystal;

    public void LoadMaterial()
    {
        mat = new Material[5];
        mat[0] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Blue", typeof(Material)) as Material;
        mat[1] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_White", typeof(Material)) as Material;
        mat[2] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Red", typeof(Material)) as Material;
        mat[3] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Black", typeof(Material)) as Material;
        mat[4] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Empty", typeof(Material)) as Material;
    }

    public void LoadMaterial(GameObject obj,int matNum,C_STATE stat)
    {
        Material[] mts = new Material[3];
        switch (stat)
        {
            case C_STATE.BLUE:
                mts[matNum] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Blue", typeof(Material)) as Material;
                obj.GetComponent<MeshRenderer>().materials = mts;
                break;
            case C_STATE.WHITE:
                mts[matNum] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_White", typeof(Material)) as Material;
                obj.GetComponent<MeshRenderer>().materials = mts;
                break;
            case C_STATE.RED:
                mts[matNum] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Red", typeof(Material)) as Material;
                obj.GetComponent<MeshRenderer>().materials = mts;
                break;
            case C_STATE.BLACK:
                mts[matNum] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Black", typeof(Material)) as Material;
                obj.GetComponent<MeshRenderer>().materials = mts;
                break;
            case C_STATE.EMPTY:
                mts[matNum] = Resources.Load("Nature/Trans/Main_Objects/COMMON/CCrystal/Crystal_Empty", typeof(Material)) as Material;
                obj.GetComponent<MeshRenderer>().materials = mts;
                break;
        }
    }

    public void Reset()
    {
        state = C_STATE.EMPTY;
        myNum = 88;
    }
}
