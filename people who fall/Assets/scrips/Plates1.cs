using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates1 : MonoBehaviour
{
    [SerializeField] List<GameObject> plates = new List<GameObject>();
   
    void Start()
    {
        plates[Random.Range(0,3)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(3,6)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(6,9)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(9,12)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(12,15)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(15,18)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(18,21)].GetComponent<Collider>().isTrigger = true;
        plates[Random.Range(21,24)].GetComponent<Collider>().isTrigger = true;


    }

    
    void Update()
    {
        
    }
}
