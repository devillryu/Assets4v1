using game4v1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Box : MonoBehaviourPun
{
    public GameObject CloseBox;
    public GameObject openBox;
    public static bool isOpen = false;

    public void Update()
    {
        photonView.RPC("OpenChest", RpcTarget.All);
    }

    [PunRPC]
    public void OpenChest()
    {
        if (isOpen == true)
        {
           
            openBox.SetActive(true);
            CloseBox.SetActive(false);
        }
        else
        {

        }
    }


}
