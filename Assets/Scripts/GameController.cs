using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float gameSpeed = 2.5f;
    public float spawnTimeout = 2.5f;
    public float jump = 10f;

    public Transform spawn;
    public Object wall;

    float timeout = 0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        if (timeout <= 0)
        {
            GameObject.Instantiate(wall, spawn.position, Quaternion.identity);
            timeout = spawnTimeout;
        }
        timeout -= Time.deltaTime;
    }
}
