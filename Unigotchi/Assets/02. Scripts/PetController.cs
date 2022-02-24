using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public float speed = 100f;
    public Transform [] target;
    bool isMove;
    float moveTimer=3f;
    float stopTime;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        stopTime = moveTimer;
    }

    void Update()
    {

        if (moveTimer > 0)
        {
            isMove = false;
            moveTimer -= Time.deltaTime;
            
        }
        else
        {
            Move();
            moveTimer = stopTime;
        }
        anim.SetBool("isMove", isMove);
        transform.LookAt(transform.forward);
    }
    void Move()
    {
        int point = Random.Range(0, target.Length);
        transform.position = Vector3.MoveTowards(transform.position, target[point].position, speed * Time.deltaTime);
        isMove = true;
    }
}
