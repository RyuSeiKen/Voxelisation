using UnityEngine;
using System.Collections;

public class RenderImage : MonoBehaviour 
{
	public Texture2D image;
	public GameObject sphere;
	GameObject sphereTemp;
	public int scale;
	public int step;

	void Start () 
	{
		sphere.transform.localScale = new Vector3(scale, scale, scale);
		for(int i = 0; i < 500; i +=step)
		{
			for(int j = 0; j < 500; j +=step)
			{
				Color col = image.GetPixel(i, j);
				if(col.a > 0)
				{
					sphereTemp = GameObject.Instantiate(sphere, new Vector3(i, j, 0), Quaternion.identity) as GameObject;
					sphereTemp.GetComponent<Renderer>().material.color = col;
				}
			}
		}
	}
}
