using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer theRenderer;
    public Color spriteColor;
    void Start()
    {
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        //opacity
        spriteColor.a = 1.0f;
        spriteColor.r = 1.0f;
        spriteColor.g = 1.0f;
        spriteColor.b = Random.Range(0.0f , 1.0f);
        //Color changer
        if (theRenderer != null)
        {
            theRenderer.color = spriteColor;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
