using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] List<GameObject> rbDoors = new List<GameObject>();
    void Start()
    {
        //3 = row 3 = doors

       for (var i = 0; i < rbDoors.Count; i += rbDoors.Count / 3) {
           var x = Random.Range(i, i + 3);
           RigidbodyDoor(x);
       } 
    }
      
   
    void Update()
    {
        
    }
    public void RigidbodyDoor(int count) {
        Rigidbody rb = rbDoors[count].gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
    }
}
