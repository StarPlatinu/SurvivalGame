using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()

    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + inputVec);
    }
}
