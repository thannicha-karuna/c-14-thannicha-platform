using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }

    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    void OnHitWith(Enemies enemies)
    {
        
    }
    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && BulletTimer <= 0)
        {
            Shoot();
        }
    }
    public void Shoot()
    {

        if (Input.GetButtonDown("Fire1") && BulletTimer <= 0)
        {
           GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
           Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
            //BulletTimer = BulletSpawnTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      Enemies enemies =  collision.gameObject.GetComponent<Enemies>();
        if (enemies != null)
        {
            
        }
    }
}
