using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pj_movement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private Rigidbody2D pj;
    private Animator anim;
    private SpriteRenderer spritepj;
    private void Awake()
    {
        pj = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spritepj = GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        Movimieto();
    }
    private void Movimieto()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        pj.velocity = new Vector2(horizontal, vertical) * velocidad;
        anim.SetFloat("caminar", Mathf.Abs(pj.velocity.magnitude));
        if (horizontal > 0)
        {
            spritepj.flipX = false;
        }else if (horizontal < 0) 
        {
            spritepj.flipX = true;
        }

    }
}
