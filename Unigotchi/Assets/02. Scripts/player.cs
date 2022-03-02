using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Animator anim;
    Vector3 destination;
    public float speed;
    bool isMove;

    void Start()
    {
        anim=GetComponent<Animator>();
        isMove=false;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, destination) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            transform.LookAt(transform.position + destination);
            isMove = true;
        }
        else
        {
            isMove = false;
            transform.LookAt(new Vector3(0,0,-1));
        }
            

        anim.SetBool("isMove", isMove);
        
    }
    public void Move(Vector3 destination)
    {
        this.destination = destination;
    }
    
}
