using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTube : MonoBehaviour

{
    public GameObject[] tubes;
    public GameObject fire;
    public float speed = 20;
    public float TimerSet = 1;
    public float destroyTime = 1;
    float Timer;

    int index = 0;
    bool isAsc = true;
    // Start is called before the first frame update
    void Start () {
        Timer = TimerSet;
    }
    void fireInstantiate () {

        GameObject p = Instantiate (fire, tubes[index].transform.position, tubes[index].transform.rotation);
        Rigidbody r = p.GetComponent<Rigidbody> ();
        r.velocity = transform.forward * -1 * speed;
        if (isAsc) {
            index += 1;
        } else {
            index -= 1;
        }
        if (index == tubes.Length - 1 || index == 0) {
            isAsc = !isAsc;
        }
        Destroy (p, destroyTime);
    }
    // Update is called once per frame
    void Update () {
        Timer -= 1 * Time.deltaTime;
        if (Timer <= 0) {
            fireInstantiate ();
            Timer = TimerSet;
        };
    }
}