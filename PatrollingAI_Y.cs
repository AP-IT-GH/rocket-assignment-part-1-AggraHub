using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingAI_Y : MonoBehaviour
{
    public float speed = 4.44f;
    public float range = 18;

    float startingY;
    int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime * dir);
        if (transform.position.y < startingY || transform.position.y > startingY + range)
            dir *= -1;
    }
}