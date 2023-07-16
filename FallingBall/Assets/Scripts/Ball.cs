using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private static float gravity = 9.8f;
    private static float scale = 0.25f;
    private float width;
    private float height;
    public Vector3 velocity;
    public Vector3 acceleration;
    // Start is called before the first frame update
    void Start()
    {
        // set height to be the height of the camera's view
        width = Camera.main.aspect * Camera.main.orthographicSize * 2.0f;
        height = Camera.main.orthographicSize * 2.0f;
        Debug.Log("Ball.Start");
        this.ResetVectors();
        transform.position = new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-height / 2, height), 0);
    }

    public void SetRandomRadius() {
        float radius = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(radius, radius, radius);
    }

    public void SetRandomColor() {
        float r = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        GetComponent<Renderer>().material.color = new Color(r, g, b);
    }

    private void ResetVectors() {
        transform.position = new Vector3(Random.Range(-width / 2, width / 2), height / 2 + transform.localScale.y / 2 + Random.Range(0, height / 2), 0);
        velocity = new Vector3(0, 0, 0);
        acceleration = new Vector3(0, -gravity * scale, 0);
        this.SetRandomRadius();
        this.SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        // Get position
        Debug.Log("Ball.Update: " + transform.position + " " + velocity + " " + acceleration);
        // Change position
        transform.position += velocity * Time.deltaTime;
        velocity += acceleration * Time.deltaTime;
        // check if the ball is below the bottom of the screen, accounting for the ball's radius
        if (transform.position.y < -height / 2 - transform.localScale.y / 2) {
            this.ResetVectors();
        }

    }
}
