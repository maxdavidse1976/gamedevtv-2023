using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace DragonspiritGames_ParallelParadox
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private Animator animator;
        public enum TransitionParameter
        {
            Move
        }

        void Update()
        {
            if (VirtualInputManager.instance.moveRight && VirtualInputManager.instance.moveLeft) 
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (!VirtualInputManager.instance.moveRight && !VirtualInputManager.instance.moveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (VirtualInputManager.instance.moveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }
            if (VirtualInputManager.instance.moveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }
        }
    }
}
