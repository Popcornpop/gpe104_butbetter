using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public KeyCode keyPress;
    public KeyCode quitKey;
    public KeyCode resetKey;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public float playerSpeed;
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
        if (Input.GetKeyDown(resetKey))
        {
            Vector3 position = new Vector3(0, 0, 0);
            //Issues Transform command
            transform.SetPositionAndRotation(position, Quaternion.identity);
        }
        //Movement Scripting
        if (Input.GetKey(upKey))
        {
            transform.position = transform.position + Vector3.up * playerSpeed *Time.deltaTime;
        }
         if (Input.GetKey(downKey))
        {
            transform.position = transform.position + Vector3.down * playerSpeed * Time.deltaTime;
        }
        //Simple hot fix to correct the directional movements(Probable fix is simply rotating the object to cafe the correct direction)
         if (Input.GetKey(leftKey))
        {
            transform.position = transform.position + Vector3.right * playerSpeed * Time.deltaTime;
        }
         if (Input.GetKey(rightKey))
        {
            transform.position = transform.position + Vector3.left * playerSpeed * Time.deltaTime;
        }
    }
}
