using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.ChangeColor();
    }

    private void ChangeColor() {
        // Gradual shift through the color spectrum -- maybe use noise?
        float r = Mathf.Sin(Time.time * 0.1f) * 0.5f + 0.5f;
        float b = Mathf.Sin(Time.time * 0.1f + 2.0f) * 0.5f + 0.5f;
        float g = Mathf.Sin(Time.time * 0.1f + 4.0f) * 0.5f + 0.5f;
        GetComponent<Renderer>().material.color = new Color(r, g, b);
    }
}
