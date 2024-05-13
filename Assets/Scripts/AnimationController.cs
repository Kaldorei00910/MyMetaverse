using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected MainController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<MainController>();
    }
}
 