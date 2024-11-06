using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapons
{
    [SerializeField] Rigidbody2D rb2d;
    Vector2 force;

    private void Start()
    {
        Move();
        //Debug.Log("Rock damage" + Damage);
        Damage = 10;

        rb2d = GetComponent<Rigidbody2D>();
        //thorwing rock
        force = new Vector2(GetShootDirection()*10  , 99);
    }

    public override void Move()
    {
        //Debug.Log("Rock is movig with Rigidbody: Force");
        //mage rock move projectlie
        rb2d.AddForce(force);

    }
    public override void OnhitWith(Character character)
    {
        //do nothing either...do something

        if(character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
