using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Initial Values")]
    public int totalScore;


    [Header("InGame panel")]
    public Text textScore;

    [Header("GameOver panel")]
    public Text lastScore; 



    // Update is called once per frame
    void Update()
    {
        textScore.text = totalScore.ToString();

        //gameOver 
        lastScore.text = totalScore.ToString();
    }
}
