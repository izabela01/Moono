using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    private float minX = -2;
    private float maxX = 2;
    private float minY = -2;
    private float maxY = 2;
    bool _gameOver = false;

    Vector2 targetPosition;

    public float speed ;

    void Start()
    {
        targetPosition = GetRandomPosition();
        Debug.Log(targetPosition);
        this.speed = 0.005f;
    }

    void Update()
    {
        if((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed);
        } else
        {
            targetPosition = GetRandomPosition();
        }
        
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        Debug.Log(randomX + minX + minY);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Planets")
        {
            SceneManager.LoadScene("Learning");
            Debug.Log("GAME OVER! UNLUCKY!");

        }

        //if (collision.tag == "Planets")
        //{
        //    SceneManager.LoadScene("Game");
        //    Debug.Log("In the collision tag");

        //}

        //if (collision.gameObject.tag == "Planets")
        //{
        //    Debug.Log("Collided with a planet!");
        //}

    }

    //private void OnCollisionEnter(Collider2D collision)
    //{
    //    if (collision.tag == "Planets")
    //    {
    //        //SceneManager.LoadScene("Game");
    //        Debug.Log("COLLISION ENTER");

    //    }

    //}
}
