using game4v1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Photon.Pun;

public class Box : MonoBehaviour
{
    public GameObject CloseBox;
    public GameObject openBox;
    public static bool isOpen = false;

    public void Update()
    {
        OpenChest();
    }

    public void OpenChest()
    {
        if (isOpen == true) 
        {
            // photonView.RPC("Openchest",RpcTarget.All);
            openBox.SetActive(true);
            CloseBox.SetActive(false);
        }
        else
        {

        }
    }


}
