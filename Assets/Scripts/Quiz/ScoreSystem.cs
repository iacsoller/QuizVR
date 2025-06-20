using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreSystem : MonoBehaviour
{
    
    public static int score = 0;

    [SerializeField] private GameObject gameOver;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

        GameOver();
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
