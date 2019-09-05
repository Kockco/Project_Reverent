using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCrystal : CrystalState
{
    // Start is called before the first frame update
    void Start()
    {
        
        //마테리얼 미리 리소스 로드
        LoadMaterial(state);
        if (myNum <= 0)
        {
            Debug.Log(transform.name + " number none");
        }
    }
}
