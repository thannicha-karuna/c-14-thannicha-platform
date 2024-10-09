using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField] private int damage;
    public int Damage 
    {
        get 
        {
            return damage;
        }

        set 
        {
            damage = value;
        }
    }

    protected string owner;
    public abstract void OnhitWith(Character character);
    public abstract void Move();
    public int GetShootDirection()
    {
        return 1;
    }

}
