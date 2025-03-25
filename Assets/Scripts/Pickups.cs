using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public Text scoreText;
    public int levelscore;
    public int score;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {

            Scoring.levelScore++;

            scoreText.text = "PUNTUACIÓN: " + Scoring.levelScore;
            Debug.Log("Puntuación de nivel: " + Scoring.levelScore);

            Destroy(collision.gameObject);
        }
    }
}