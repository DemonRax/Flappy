using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        gameObject.GetComponent<TMP_Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TMP_Text>().enabled = !gameController.isRunning;
    }
}
