using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Gamemanager : MonoBehaviour
{
    // public Player Playerprefab;
    // [HideInInspector]
    // public Player LocalPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        if (!PhotonNetwork.IsConnected)
        {
            SceneManager.LoadScene("MainMenu");
            return;
        }
        // else
        // print("connect");
        // print("awake");
    }
    void Start()
    {
        // Player.RefreshInstance(ref LocalPlayer, Playerprefab);
        //Foundbug
        CreatePlayer();
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Application.Quit();
        }
    }
    // public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    // {
    //     base.OnPlayerEnteredRoom(newPlayer);
    //     Player.RefreshInstance(ref LocalPlayer, Playerprefab);
    // }
    void CreatePlayer()
    {
        PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "Player"), Vector3.zero, Quaternion.identity);
    }

}
