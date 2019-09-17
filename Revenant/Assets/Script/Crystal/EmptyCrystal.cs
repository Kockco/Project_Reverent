using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCrystal : CrystalState
{
    public MeshRenderer myMat;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        LoadMaterial();
            myMat = transform.GetChild(0).GetComponent<MeshRenderer>();


        isActive = false;

        if (myNum <= 0)
        {
            Debug.Log(transform.name + " number none");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (delay <= 0.8f)
            delay += Time.deltaTime;

        if(delay > 0.8f)
        ChangeMat();
    }
    public void ChangeMat()
    {
        switch (state)
        {
            case C_STATE.BLUE:
                myMat.material = mat[0];
                break;
            case C_STATE.WHITE:
                myMat.material = mat[1];
                break;
            case C_STATE.RED:
                myMat.material = mat[2];
                break;
            case C_STATE.BLACK:
                myMat.material = mat[3];
                break;
            case C_STATE.EMPTY:
                myMat.material = mat[4];
                break;
        }
    }
}
