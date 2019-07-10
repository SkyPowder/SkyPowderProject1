using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace PlayerSpace
{
    public class Player : MonoBehaviour
    {
        NavMeshAgent playerAgent;
        Rigidbody playerRB;
        Camera mainCamera;
        PlayerController playerController;

        public void PlayerAwake()
        {
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            playerAgent = GetComponent<NavMeshAgent>();
            playerRB = GetComponent<Rigidbody>();
            playerController = new PlayerController(playerAgent, playerRB);
        }
    }
}

