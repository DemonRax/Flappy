using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.position = new Vector3(Camera.main.ViewportToWorldPoint(Vector3.zero).x - 2f, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject.transform.parent.gameObject);
    }
}
