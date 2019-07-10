using UnityEngine;
using UnityEditor;

namespace PlayerSpace
{
    public class PlayerInputController
    {
        Ray clickRay;
        RaycastHit clickHit;
        LayerMask clickLayer;
        int walkable;
        int interractive;
        int shootable;

        public PlayerInputController()
        {
            walkable = LayerMask.GetMask("Walkable");
            interractive = LayerMask.GetMask("Interractive");
            shootable = LayerMask.GetMask("Shootable");
        }

        public enum action
        {
            Move,
            Interract,
            Shoot,
            None
        };

        public void InputDetecter()
        {
            if (Input.anyKeyDown)
            {
                
            }

        }

        public action InputController(Camera mainCamera)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                clickRay = mainCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(clickRay, out clickHit, walkable))
                {
                    return action.Move;
                }
                else if (Physics.Raycast(clickRay, out clickHit, interractive))
                {
                    return action.Interract;
                }
                else if (Physics.Raycast(clickRay, out clickHit, shootable))
                {
                    return action.Shoot;
                }
                else return action.None;
            }
            else return action.None;
        }
    }
}
