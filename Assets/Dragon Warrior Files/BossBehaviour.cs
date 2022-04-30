using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public enum State
    {
        Walk,
        Attack,
        Attack1
    }

    public State currentState;
    public Transform player;
    public float thresholdDist = 2f;
    public Animator anim;

    public float timeBwAttack = 1f;
    public float attackTime = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector2.Distance(transform.position, player.position) <= thresholdDist && currentState == State.Walk)
        {
            currentState = State.Attack1;

        }
        else if(Vector2.Distance(transform.position, player.position) > thresholdDist)
        {
            currentState = State.Walk;
        }

        if(currentState == State.Attack1)
        {
            print("attack1");
            anim.SetBool("Walk", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Attack1", true);
        }
        else
        {
            print("walk");
            anim.SetBool("Walk", true);
            anim.SetBool("Attack", false);
            anim.SetBool("Attack1", false);
        }

        

    }
}
