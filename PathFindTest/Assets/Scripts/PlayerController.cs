using UnityEngine;
using UnityEditor;
using UnityEngine.AI;

namespace PlayerSpace
{
    public class PlayerController
    {
        PlayerMove playerMove;
        PlayerInputController playerIC;

        public PlayerController(NavMeshAgent playerAgent, Rigidbody playerRB)
        {
            playerMove = new PlayerMove(playerAgent, playerRB);
            playerIC = new PlayerInputController();
        }

        public void PlayerControllerUpdate(float deltaTime)
        {
            
        }
    }
}
