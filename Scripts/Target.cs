using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    public float health = 100;
    private Vector3 dir = Vector3.forward;
    private bool movingLeft;
    public float speed = 5f;

    private void Start()
    {
        movingLeft = true;
    }

    private void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (movingLeft == true)
        {
            dir = Vector3.forward;
            if (transform.position.z >= 6) 
                movingLeft = false;
        }
        else if (movingLeft == false)
        {
            dir = Vector3.back;
            if (transform.position.z <= -6)
                movingLeft = true;
        }
    }

    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }
}
