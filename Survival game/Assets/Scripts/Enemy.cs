using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;

    bool isLive = true;
    Rigidbody2D rigid;
    SpriteRenderer spriter;


    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter= GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (!isLive) return;
        Vector2 dirVec= target.position - rigid.position; //Vi tri giua quai va nguoi choi
        Vector2 nextVec = dirVec.normalized* speed*Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec); //Di chuyen
        rigid.velocity = Vector2.zero;

    }

    void LateUpdate()
    {
        if (!isLive) return;
        spriter.flipX = target.position.x < rigid.position.x;

    }
}
