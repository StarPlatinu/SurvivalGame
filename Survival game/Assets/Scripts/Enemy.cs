using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
<<<<<<< HEAD
    public float health;
    public float maxHealth;
    public RuntimeAnimatorController[] animCon;

    public Rigidbody2D target;

    bool isLive;

    Rigidbody2D rigid;
    Animator anim;
=======
    public Rigidbody2D target;

    bool isLive = true;

    Rigidbody2D rigid;
>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
    SpriteRenderer spriter;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
        anim= GetComponent<Animator>();
=======
>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
        spriter = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (!isLive)
            return;
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;
    }

    void LateUpdate()
    {
        if (!isLive)
            return;
        spriter.flipX = target.position.x < rigid.position.x;

    }
    void OnEnable()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();
<<<<<<< HEAD
        isLive = true;
        health = maxHealth;
    }
    public void Init(SpawnData data)
    {
        anim.runtimeAnimatorController = animCon[data.spriteType];
        speed = data.speed;
        maxHealth = data.health;
        health = data.health;
=======
>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
    }
}
