using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int speed;
    public Transform pointA, pointB;
    private Vector2 currentTarget;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pointA.position)
        {
            currentTarget = pointB.position;
            sr.flipX = true;
        }
        else if (transform.position == pointB.position)
        {
            currentTarget = pointA.position;
            sr.flipX = false;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}