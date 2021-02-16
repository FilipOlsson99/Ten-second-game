using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttonmiss : MonoBehaviour
{


    public GameObject MissArea;



    void OnMouseDown()
    {

        SceneManager.LoadScene("GameOver");


    }
}
