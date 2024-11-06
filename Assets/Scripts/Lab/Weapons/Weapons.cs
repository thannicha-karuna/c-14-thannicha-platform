using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField]  int damage;

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

    protected IShootable shooter;

    public abstract void OnhitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner)
    { 
        Damage = _damage; 
        shooter = _owner;
            
     }
    public int GetShootDirection()
    {

        float shootDir = shooter.BulletSpawnPoint.transform.position.x - shooter.BulletSpawnPoint.parent.transform.position.x;
        if (shootDir < 0)
        {

            return -1;//L
        }
        else return 1;//R

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnhitWith(other.GetComponent<Character>()); //this is polymolisim

        //Destroy something object
        Destroy(this.gameObject, 4f);
        
    }
}
