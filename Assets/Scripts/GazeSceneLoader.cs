using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeSceneLoader : MonoBehaviour
{
    public float holdDuration = 3f;
    public string targetScene = "Space";
    public GameObject progressUI;

    private float timer = 0f;
    private bool isHolding = false;

    void Update()
    {
        if (isHolding)
        {
            timer += Time.deltaTime;

            if (timer >= holdDuration)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(targetScene);
            }
        }
        else
        {
            timer = 0f;
        }
    }

    public void OnHoldStart()
    {
        isHolding = true;
    }

    public void OnHoldEnd()
    {
        isHolding = false;
        timer = 0f;
    }
}