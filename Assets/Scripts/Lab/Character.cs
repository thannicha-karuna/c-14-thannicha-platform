using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]private int health;
    public int Health
    {
        get
        {
            //if write full get set property, make it return or something
            //this is capsule
            return health;
        }

        set
        {
            health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;

    public bool IsDead()
    {
        return Health <= 0;
        
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
