using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anim;
    public float x, y;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
