using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public Transform respawnPosition; //where the object spawns after hitting a collider
    //private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(prefab, transform.position, transform.rotation);
        transform.position = respawnPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            //Instantiate(prefab, transform.position, transform.rotation);
            RespawnObject();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basket"))
        {
            RespawnObject();
        }
    }

    void RespawnObject()
    {
        transform.position = respawnPosition.position;

        //resets the velocity 
        GetComponent <Rigidbody>().velocity = Vector3.zero;
        GetComponent <Rigidbody>().angularVelocity = Vector3.zero;
    }
}
