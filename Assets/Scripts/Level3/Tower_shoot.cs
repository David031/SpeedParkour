using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_shoot : MonoBehaviour {
    public Rigidbody projectile;
    public float speed = 40;

    public float Timer = 2;
    // This script will simply instantiate the Prefab when the game starts.
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        Timer -= 1 * Time.deltaTime;
        if (Timer <= 0) {
            Rigidbody p = Instantiate (projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
            Timer = 2;
        };

    }
}