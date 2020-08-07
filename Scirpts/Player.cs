﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

namespace game4v1
{
    public class Player : MonoBehaviourPun
    {
        public float speed = 5f;
        public VariableJoystick variableJoystick;

        //Map
        public Button Actionbutton;//Actionbutton
        public Button Skillanditembutton;
        public CharacterController controller;
        public static bool CanInvest = false;
        public static bool canOpenChest = false;
        void Awake()
        {
            if (!photonView.IsMine && variableJoystick != null)
            {
                variableJoystick = null;
            }
        }
        void Start()
        {
            variableJoystick = FindObjectOfType<VariableJoystick>();
            Actionbutton = GameObject.Find("ActionButton").GetComponent<Button>();
            Skillanditembutton = GameObject.Find("SkillanduseitemButton").GetComponent<Button>();
            if (Swaprole.chooserole.Role == "Survival")
            {
                //SurvivalAction()
            }
            else
            {
                speed = 7f;
                //HunterAction()
            }
        }
        public void FixedUpdate()
        {
            Move();

        }
        void Move()
        {
            if (!photonView.IsMine)
                return;
            Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
            controller.Move(direction * speed * Time.fixedDeltaTime);

            if (CanInvest == true)
            {
                CanInvest = false;
            }

            if (canOpenChest == true)
            {
                canOpenChest = false;
            }
        }
        // public static void RefreshInstance(ref Player player,Player Prefab)
        // {
        //     var position = Vector3.zero;
        //     var rotation = Quaternion.identity;

        //     if(player != null && PhotonNetwork.IsMasterClient)
        //     {
        //         position = player.transform.position;
        //         rotation = player.transform.rotation;
        //         PhotonNetwork.Destroy(player.gameObject);
        //     }
        //     player = PhotonNetwork.Instantiate(Prefab.gameObject.name,position,rotation).GetComponent<Player>();
        //     player.transform.position = position;
        // }
        void OnTriggerStay(Collider other)
        {
            if (other.tag == "Investzone")
            {
                CanInvest = true;
            }

            if (other.tag == "Boxcheck")
            {
                canOpenChest = true;
            }

        }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Investzone")
            {
                CanInvest = false;
            }

            if (other.tag == "Boxcheck")
            {
                canOpenChest = false;
            }
        }
    }
}
