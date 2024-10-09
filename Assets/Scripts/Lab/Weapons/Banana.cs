using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapons
{
    [SerializeField] private float speed;

    private void Start()
    {
        Move();
        Debug.Log("Banana damage" + Damage + "Banana speed" + speed);
    }

    public override void Move()
    {
        Debug.Log("Banana is moving with constant speed by using transform");
    }

    public override void OnhitWith(Character character)
    {
        //do nothing...
    }
}
