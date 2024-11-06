using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapons
{
    [SerializeField] float speed;

    private void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
       
        Move();
       // Debug.Log("Banana damage" + Damage + "Banana speed" + speed);

    }

    public override void Move()
    {
        //Debug.Log("Banana is moving with constant speed by using transform");
        //s = speed * time(Physic)
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newposition = new Vector2(newX, newY); 
        transform.position = newposition;
    }

    private void FixedUpdate()
    {
        Move();
    }

    public override void OnhitWith(Character character)
    {
        //do nothing...do something shoot
        if(character is Enemies)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
