using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class Gem
{
    public Color color;
    string name;

    Gem(string n, Color c) {
        name = n;
        color = c;
    }

    static Gem Purple = new Gem("Purple", new Color(0.475f, 0.416f, 0.749f));
    static Gem Blue = new Gem("Blue", new Color(0.345f, 0.659f, 0.749f));
    static Gem Pink = new Gem("Pink", new Color(0.749f, 0.529f, 0.647f));
    static Gem Yellow = new Gem("Yellow", new Color(0.981f, 0.926f, 0.616f));

    static Gem[] gems = {Purple, Blue, Pink, Yellow};

    public static Gem getRandomGem() {
        int colorNum = UnityEngine.Random.Range(0, gems.Length);
        return gems[colorNum];
    }
}

public class GemScript : MonoBehaviour
{
    private Gem color;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        Gem gem = Gem.getRandomGem();
        spriteRenderer.color = gem.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
