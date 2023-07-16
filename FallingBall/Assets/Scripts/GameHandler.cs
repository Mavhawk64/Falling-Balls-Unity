using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Array of Ball
    public GameObject[] balls;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameHandler.Start");
        AddBalls(99);
    }

    private void AddBalls(int count) {
        // Initialize the array of balls
        GameObject[] newBalls = new GameObject[count+balls.Length];
        // Create a ball for each element in the array
        for (int i = 0; i < balls.Length; i++) {
            newBalls[i] = balls[i];
        }

        for (int i = balls.Length; i < newBalls.Length; i++) {
            newBalls[i] = Instantiate(balls[0]);
        }

        balls = newBalls;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
