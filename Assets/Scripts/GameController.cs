using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float gameSpeed = 2.5f;
    public float spawnTimeout = 5f;
    public float jump = 10f;
    public bool isRunning = true;
    public int score = 0;
    
    public Transform spawn;
    public Object wall;
    public TMP_Text scoreText;

    float timeout = 0f;
    float min, max;

    void Start()
    {
        min = Camera.main.ViewportToWorldPoint(Vector3.zero).y + 2.5f;
        max = Camera.main.ViewportToWorldPoint(Vector3.one).y -2.5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        scoreText.text = "Score: " + score;


        if (!isRunning)
        {

            return;
        }  

        if (timeout <= 0)
        {
            float y = Random.Range(min, max);
            GameObject.Instantiate(wall, new Vector3(spawn.position.x, y, 0), Quaternion.identity);
            timeout = spawnTimeout;
        }
        timeout -= Time.deltaTime * gameSpeed;
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

// Change speed progressively
// Adjust boundaries to display
