using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Walls : MonoBehaviour
{
    GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        gameObject.transform.position += new Vector3(-gameController.gameSpeed*Time.deltaTime, 0, 0);
    }
}
