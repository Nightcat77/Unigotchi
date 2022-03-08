using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public player pet;
    public NeedsController needsController;
    public float moveTimer;
    public float stopTime;
    Animator anim;

    public static PetController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one Petcontroller in the Scene");
    }
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
    public void Die()
    {
        Debug.Log("Dead");
    }
}
