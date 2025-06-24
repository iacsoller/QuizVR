using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Initial Values")]
    public int totalScore;


    [Header("InGame panel")]
    public Text textScore;

    [Header("GameOver panel")]
    public Text lastScore;

    [Header("ObjectPool")]
    public ObjectPool slippersPool;
    public float slipperSpeed = 10f;




    // Update is called once per frame
    void Update()
    {
        textScore.text = totalScore.ToString();

        //gameOver 
        lastScore.text = totalScore.ToString();

        /*if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Throw();
        }*/
    }

    void Throw()
    {
        GameObject slipper = slippersPool.GetObject();
        slipper.transform.position = transform.position;    
        slipper.transform.rotation = transform.rotation;

        Rigidbody rb = slipper.GetComponent<Rigidbody>();

        if(rb != null )
        {
            rb.velocity = slipper.transform.forward * slipperSpeed;
        }

        StartCoroutine(DeactivateSlipper(slipper));
    }

    IEnumerator DeactivateSlipper(GameObject slipper)
    {
        yield return new WaitForSeconds(2f);
        slippersPool.ReturnObject(slipper);
    }

    public void SlipperThrow(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Throw();
        }
    }
}
