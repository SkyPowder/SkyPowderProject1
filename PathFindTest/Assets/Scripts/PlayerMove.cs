using UnityEngine;
using UnityEditor;
using UnityEngine.AI;

namespace PlayerSpace
{
    public class PlayerMove
    {
        NavMeshAgent playerAgent;
        Rigidbody playerRB;

        public PlayerMove(NavMeshAgent playerAgent, Rigidbody playerRB)
        {
            this.playerAgent = playerAgent;
            this.playerRB = playerRB;
        }

        public void Move(Vector3 target)
        {
            playerAgent.SetDestination(target);
        }
    }
}
