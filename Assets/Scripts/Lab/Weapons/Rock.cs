using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapons
{
    private Rigidbody2D rb2d;
    private Vector2 force;

    private void Start()
    {
        Move();
        Debug.Log("Rock damage" + Damage);

    }

    public override void Move()
    {
        Debug.Log("Rock is movig with Rigidbody: Force");
    }
    public override void OnhitWith(Character character)
    {
        //do nothing either...
    }
}
