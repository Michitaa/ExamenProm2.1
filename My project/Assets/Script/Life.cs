using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int life = 3;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Enemy")) 
        {
        Destroy(gameObject);
            life--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
