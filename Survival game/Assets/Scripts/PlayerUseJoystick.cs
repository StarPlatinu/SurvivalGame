using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerUseJoystick : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    Animator anim;
    Rigidbody2D rigid;
    SpriteRenderer spriter;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    inputVec.x = Input.GetAxis("Horizontal");
    //    inputVec.y = Input.GetAxis("Vertical");
    //}

    private void FixedUpdate()

    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        // moves the player to the next position
        rigid.MovePosition(rigid.position + nextVec);
    }
    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

}
