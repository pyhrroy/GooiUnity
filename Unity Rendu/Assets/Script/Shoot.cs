using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 30f;
    public AudioSource shoot;

    void Start()
    {
        Cursor.visible = false;
        shoot = GetComponent<AudioSource>();

    }

    // If Left-Clic, create Rigidbody "projectile" > Bullet, in the direction of the Cam transform
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            shoot.Play();
        }
    }
}