using UnityEngine;
using System.Collections;

public class GetColor : MonoBehaviour {


    public Color32[] data;
    public Texture text;
    public GameObject objectTexture;
    Renderer rend;
    float r;
    float g;
    float b;
    Color32 myColor;



    void Start()
    {
        text = new Texture();
        rend = GetComponent<Renderer>();
    }

    void Update()
    {

        r = 0;
        g = 0;
        b = 0;
        //data = objectTexture.GetComponent<Renderer>().;

        for (int i = 0; i < data.Length; i++)
        {
            r += data[i].r;
            g += data[i].g;
            b += data[i].b;


        }
        r = (r / data.Length);
        g = (g / data.Length);
        b = (b / data.Length);

        r = (r / 255);
        g = (g / 255);
        b = (b / 255);


        rend.material.color = new Color(r, g, b);
        //Debug.Log(rend.material.color);

    }

void OnTriggerEnter(Collider col)
    {
        //col.
    }
}
