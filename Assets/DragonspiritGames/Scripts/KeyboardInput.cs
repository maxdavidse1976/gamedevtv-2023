using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonspiritGames_ParallelParadox
{
    public class KeyboardInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.instance.moveRight = true;
            }
            else
            {
                VirtualInputManager.instance.moveRight = false;
            }

            if (Input.GetKey(KeyCode.A)) 
            { 
                VirtualInputManager.instance.moveLeft = true;
            }
            else
            {
                VirtualInputManager.instance.moveLeft = false;
            }
        }
    }

}
