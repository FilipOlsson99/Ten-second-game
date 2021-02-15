using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttonpress : MonoBehaviour
{
    public Text ScoreText;
    public GameObject Button;
    public int score = 0;
    


    void OnMouseDown()
    {

        gameObject.SetActive(false);

        score++;
        ScoreText.text = "Points: " + score;

        
    }

    
}
