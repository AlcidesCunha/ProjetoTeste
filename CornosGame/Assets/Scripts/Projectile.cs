using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float lifeTime;
    public float moveSpeed;

    void Start()
    {
        lifeTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
        lifeTime -= Time.deltaTime;
    }
}
