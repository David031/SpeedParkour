using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_shoot : MonoBehaviour {
    public Rigidbody projectile;
    public float speed = 40;
    public GameObject target;
    public float Timer = 2;
    private float timer;
    // This script will simply instantiate the Prefab when the game starts.
    void Start () {
        timer = Timer;
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(target.transform);
        timer -= 1 * Time.deltaTime;
        if (timer <= 0) {
            Rigidbody p = Instantiate (projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
            timer = Timer;
        };
    }
}