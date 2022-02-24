using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public player pet;
    public Transform [] target;
    bool isMove;
    public float moveTimer;
    public float stopTime;
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
            Moveto();
            moveTimer = stopTime;
            
            
        }
        anim.SetBool("isMove", isMove);
        
    }
    void Moveto()
    {
        int randomPoint1 = Random.Range(-4, 4);
        int randomPoint2 = Random.Range(0, 3);
        pet.Move(new Vector3(randomPoint1,0,randomPoint2));
        isMove = true;
    }
}
