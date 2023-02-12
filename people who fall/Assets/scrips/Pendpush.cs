using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendpush : MonoBehaviour
{
    [SerializeField] float force;

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Player")) {
            collision.collider.GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0,0), ForceMode.Impulse);
        }
    }
    
}
