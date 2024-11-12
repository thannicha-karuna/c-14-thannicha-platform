using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemies
{
   [SerializeField] private Vector2 velocity;
   [SerializeField] private Transform[] movePoint;

    private void Start()
    {
        //Ant a = new Ant(10);
        //DamageHit = 10;
    }
    /* public Ant(int newHealth)
     {
         Health = newHealth;
     }*/

    private void FixedUpdate()
    {
        Behavior();
    }
    public override void Behavior()
    {
        //override kick old thing and replace a new one
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoint[0].position.x && velocity.x < 0)
        {
            FlipCharacter();
        }

        else if (rb.position.x >= movePoint[1].position.x && velocity.x > 0)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        velocity *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        
        transform.localScale = scale;
    }
}
