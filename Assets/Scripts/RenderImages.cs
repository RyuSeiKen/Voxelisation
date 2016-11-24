using UnityEngine;
using System.Collections;

public class RenderImages : MonoBehaviour {

    public Texture2D txt;
    public GameObject cube;
    GameObject cubeTemp;
    int scale;
    public int step;

    void Start ()
    {
        scale = step;
        Voxelize(txt);
    }

    void Voxelize (Texture2D image)
    {
        int imgWidth = image.width;
        int imgHeight = image.height;

        cube.transform.localScale = new Vector3(scale, scale, scale);

        for (int i = 0; i < imgWidth; i += step)
        {
            for (int j = 0; j < imgHeight; j += step)
            {

                Color col = image.GetPixel(i, j);
                if (col.a > 0)
                {
                    cubeTemp = GameObject.Instantiate(cube, new Vector3(i - imgWidth/4, j - imgHeight / 4, col.r), Quaternion.identity) as GameObject;
                    cubeTemp.GetComponent<Renderer>().material.color = col;
                    cubeTemp.transform.parent = transform;
                }              
            }
        }
    }
}
