using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour
{
    public int score = 0;
    public int winCondition = 10;
    public GameObject winner;
    public GameObject loser;
    public Text scoreText;
    public float countDown = 30f;
    public Text timeLeft;
    public GameObject playAgainButton;

    // Start is called before the first frame update
    void Start()
    {
        winner.SetActive(false);
        loser.SetActive(false);
        playAgainButton.SetActive(false);
        
    }

    private void Update()
    {
        if(countDown > 0)
        {
            countDown -= Time.deltaTime;
        }
        
        if(countDown < 0f && score < winCondition)
        {
            loser.SetActive(true);
            playAgainButton.SetActive(true);
        }
        timeLeft.text = "Time Left: " + Mathf.RoundToInt(countDown);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "apple")
        {
            score += 1;
            scoreText.text = "Score: " + score;
            if(score >= winCondition)
            {
                winner.SetActive(true);
                playAgainButton.SetActive(false);
            }
            Destroy(other.gameObject);
        }
    }
}
