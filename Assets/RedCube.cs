using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{

    private void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Get the Renderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
