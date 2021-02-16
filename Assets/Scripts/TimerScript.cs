using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class TimerScript : MonoBehaviour
{
    public float Timer = 10;
    public Text TimerText;

    // Update is called once per frame
    void Update()
    {


        TimerText.text = (Timer).ToString("0");


        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
            
            Debug.Log("End of timer");

        }
    }
}
