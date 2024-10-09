using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemies
{
    [SerializeField]private float attactRange;
    public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTimer;

    private void Update()
    {
        bulletTimer -= Time.deltaTime;
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

    private void Shoot()
    {
        if (bulletTimer <= 0)
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);

            bulletTimer = bulletSpawnTime;
        }
        
    }

}
