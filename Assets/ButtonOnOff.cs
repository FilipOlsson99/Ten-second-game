using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnOff : MonoBehaviour
{
    public GameObject GameObjectToHide;
    public float MinTime = 0.5f;
    public float MaxTime = 1f;

    void Start()
    {
        StartCoroutine(ButtonVisibility(GameObjectToHide));
    }

    IEnumerator ButtonVisibility(GameObject button)
    {
        if (button == null) yield break;

        while (true)
        {
            button.SetActive(!button.active);

            yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
