using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.position = new Vector3(Camera.main.ViewportToWorldPoint(Vector3.one).x + 1, 0, 0);
    }
}
