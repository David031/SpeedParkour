using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Gamekit3D {
    [RequireComponent (typeof (Collider))]
    public class fire_hit : MonoBehaviour {
        // Start is called before the first frame update
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }
        void OnCollisionEnter (Collision other) {
            Destroy(gameObject);
        }
    }
}