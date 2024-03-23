using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnimate : MonoBehaviour
{
    [Header("Animation")]
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("HAxis", horizontal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
