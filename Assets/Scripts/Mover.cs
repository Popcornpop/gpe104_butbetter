using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
       public KeyCode keyPress;
       public KeyCode quitKey;
    //Min Max Section
public float xMin;
public float xMax;
public float yMin;
public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            //Generates ne position within our float variables.
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            //Issues Transform command
            transform.SetPositionAndRotation(position, Quaternion.identity);
        }
        if (Input.GetKeyDown(quitKey))
        {
            Application.Quit();
        }
    }
}
