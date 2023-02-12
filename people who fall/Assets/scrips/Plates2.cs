using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates2 : MonoBehaviour
{
    
    [SerializeField] List<GameObject> plates = new List<GameObject>();
    void Start()
    {
       
    }
      
   
    void Update()
    {
        
    }
    public void OffPlates(int count) {
        plates[count].GetComponent<Collider>().isTrigger = true;
    }
}
