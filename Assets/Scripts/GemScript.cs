using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

enum GemColor {
    Blue,
    Purple,
    Pink,
    Yellow
}

public class GemScript : MonoBehaviour
{
    private GemColor color;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        int colorNum = UnityEngine.Random.Range(0, 4);
        color = (GemColor) Enum.ToObject(typeof(GemColor), colorNum);
        spriteRenderer.color = getColor();
        Debug.Log(gameObject.name + " : " + spriteRenderer.color);

        Debug.Log(gameObject.name + " : " + color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Color getColor() {
        Color c;
        switch(color) {
            case GemColor.Blue:
            {
                c = new Color(0.345f, 0.659f, 0.749f, 1.0f);
                break;
            }
            case GemColor.Purple:
            {
                c = new Color(0.475f, 0.416f, 0.749f, 1.0f);
                break;
            }
            case GemColor.Pink:
            {
                c = new Color(0.749f, 0.529f, 0.647f, 1.0f);
                break;
            }
            case GemColor.Yellow:
            {
                c = new Color(0.981f, 0.926f, 0.616f, 1.0f);
                break;
            }
            default:
            {
                c = new Color();
                break;
            }
        }
        return c;
    }
}
