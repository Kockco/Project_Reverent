using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum C_STATE { BLUE, WHITE, RED, BLACK, EMPTY }

public class CrystalState : MonoBehaviour
{
    public int myNum;
    public C_STATE state;
    public Material[] mat;

    public void LoadMaterial()
    {
        mat = new Material[5];
        mat[0] = Resources.Load<Material>("Test/Crystal1");
        mat[1] = Resources.Load("Test/Crystal2", typeof(Material)) as Material;
        mat[2] = Resources.Load("Test/Crystal3", typeof(Material)) as Material;
        mat[3] = Resources.Load("Test/Crystal4", typeof(Material)) as Material;
        mat[4] = Resources.Load("Test/Empty", typeof(Material)) as Material;
    }

    public void LoadMaterial(C_STATE stat)
    {
        switch (stat)
        {
            case C_STATE.BLUE:
                GetComponent<MeshRenderer>().material = Resources.Load<Material>("Test/Crystal1");
                break;
            case C_STATE.WHITE:
                GetComponent<MeshRenderer>().material = Resources.Load<Material>("Test/Crystal2");
                break;
            case C_STATE.RED:
                GetComponent<MeshRenderer>().material = Resources.Load<Material>("Test/Crystal3");
                break;
            case C_STATE.BLACK:
                GetComponent<MeshRenderer>().material = Resources.Load<Material>("Test/Crystal4");
                break;
            case C_STATE.EMPTY:
                GetComponent<MeshRenderer>().material = Resources.Load<Material>("Test/Empty");
                break;
        }
    }

    public void Reset()
    {
        state = C_STATE.EMPTY;
        myNum = 88;
    }
}
