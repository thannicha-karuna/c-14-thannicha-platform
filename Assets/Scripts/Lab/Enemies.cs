using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies : Character
{
    //if u make get set, make private something so send variable
    private int damageHit = 10;
    public int DamageHit
    {
        get
        {
            return damageHit;
        }

        set
        {
            damageHit = value;
        }
    }

    public abstract void Behavior();
    //methode abtract don't care anything, so don't call it

    private void Start()
    {
        // how to call behavior???
        Behavior();
    }

    
}
