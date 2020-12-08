using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Gamekit3D {
    [RequireComponent (typeof (Collider))]
    public class hit_detect : MonoBehaviour {
        // Start is called before the first frame update
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }
        void OnTriggerEnter (Collider other) {
            var pc = other.GetComponent<PlayerController> ();
            if (pc != null) {
                pc.Die (new Damageable.DamageMessage ());
            }
        }
    }
}