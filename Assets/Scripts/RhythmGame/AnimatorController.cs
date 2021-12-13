using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    public int initSpeed;
    public float stepMultiplicator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameSpeed < GameManager.instance.maxSpeed)
        {
            animator.speed = (initSpeed * 0.1f) + GameManager.instance.gameSpeed * stepMultiplicator * Time.deltaTime;   
        }
    }
}
