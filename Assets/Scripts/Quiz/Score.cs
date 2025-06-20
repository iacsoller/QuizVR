using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Apple") )
        {
            gameManager.totalScore += 1;
        }
    }
}
