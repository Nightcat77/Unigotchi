using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public player pet;
    
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
            
            moveTimer -= Time.deltaTime;
            
        }
        else
        {
            Moveto();
            moveTimer = stopTime;
            
            
        }
        
        
    }
    void Moveto()
    {
        int randomPoint1 = Random.Range(-3, 3);
        int randomPoint2 = Random.Range(0, 3);
        pet.Move(new Vector3(randomPoint1,0,randomPoint2));
        
    }
    public static void Die()
    {

    }
}
