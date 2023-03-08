using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_Text scoreText;
    public float gameSpeed = 2.5f;
    public float spawnTimeout = 2.5f;
    public float jump = 10f;
    public bool isRunning = true;
    public int score = 0;

    public Transform spawn;
    public Object wall;

    float timeout = 0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        scoreText.text = "Score: " + score;


        if (!isRunning) return;

        if (timeout <= 0)
        {
            GameObject.Instantiate(wall, spawn.position, Quaternion.identity);
            timeout = spawnTimeout;
        }
        timeout -= Time.deltaTime;
    }
}
