using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_rotation : MonoBehaviour {
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;
    bool isYPlus = false;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        float ySpeedNow = ySpeed * Time.deltaTime;

        if (ySpeedNow > 20 && isYPlus) {
            isYPlus = false;
        } else if (ySpeedNow < -50 && !isYPlus) {
            isYPlus = true;
        }
        if (isYPlus) {
            ySpeedNow = ySpeed * Time.deltaTime;

        } else {
            ySpeedNow = -ySpeed * Time.deltaTime;
        }
        Debug.Log (isYPlus);
        Debug.Log (ySpeedNow);
        transform.Rotate (
            xSpeed * Time.deltaTime,
            ySpeedNow,
            zSpeed * Time.deltaTime
        );
    }
}