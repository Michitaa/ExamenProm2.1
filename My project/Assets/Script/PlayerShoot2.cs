using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot2 : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingPoint;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = shootingPoint.position;
            obj.GetComponent<BulletMovement>().SetDirection(transform.forward);

        }
    }
}