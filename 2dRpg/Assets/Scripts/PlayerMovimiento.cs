using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{

    public float velocidad;
    private Rigidbody2D rigidbody2D;
    private Vector3 cambio;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cambio = Vector3.zero;
        cambio.x = Input.GetAxisRaw("Horizontal");
        cambio.y = Input.GetAxisRaw("Vertical");
        ActualizarAnimacion();
    }

    void ActualizarAnimacion()
    {
        if (cambio != Vector3.zero)
        {
            Mover();
            animator.SetFloat("MoverX", cambio.x);
            animator.SetFloat("MoverY", cambio.y);
            animator.SetBool("Moviendose", true);
        }
        else
        {
            animator.SetBool("Moviendose", false);
        }
    }

    void Mover()
    {
        rigidbody2D.MovePosition(transform.position + cambio * velocidad * Time.deltaTime);
    }
}
