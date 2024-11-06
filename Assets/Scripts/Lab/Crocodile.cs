using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemies, IShootable
{
    [SerializeField] private float attactRange;
    [SerializeField] public Player player;

    [field: SerializeField]public GameObject Bullet { get; set; }
    [field: SerializeField]public Transform BulletSpawnPoint { get; set; }

    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        Behavior();
    }
    public override void Behavior()
    {
        //polysomething

        Vector3 direction = player.transform.position - transform.position;

        float distance = direction.magnitude;

        if (distance < attactRange)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            //animater
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = obj.gameObject.GetComponent<Rock>();
            rock.Init(10, this);
            BulletTimer = 3;
        }
        
    }

}
