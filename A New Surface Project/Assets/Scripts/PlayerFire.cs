using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Vector3 projectileVelocity;

    public void FireProjectile()
    {
        GameObject clonedProjectile;

        clonedProjectile = Instantiate(projectilePrefab);

        clonedProjectile.transform.position = transform.position;

        Rigidbody projectileRigidbody;

        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody>();

        projectileRigidbody.velocity = projectileVelocity;

    }

    void update()
    {
        if (Input.GetButton("Fire"))
        {
           
        }
        
    }


}
