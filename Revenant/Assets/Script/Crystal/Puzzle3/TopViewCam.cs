using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewCam : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other == player)
        {
            player.GetComponent<CameraPlayer>().topView = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == player)
        {
            player.GetComponent<CameraPlayer>().topView = false;
        }
    }
}
