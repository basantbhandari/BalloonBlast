using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject reStartButton;
    int score = 0;

  

    // Update is called once per frame
    void Update()
    {
        
    }

    //to change the score

   public void ScoreUp()
    {
        score++;
        if (score >= 5) {
            Win();
        }
    }

    //when all the balls get destroyed
    void Win() {

        winText.SetActive(true);
        reStartButton.SetActive(true);

    }


    //in order to restart the game
    public void Restart() {
        SceneManager.LoadScene("Game");

    }






}
