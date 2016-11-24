using UnityEngine;
using System.Collections;

public class CubeCreator : MonoBehaviour 
{
	public GameObject cube;

	void Awake () 
	{
		for(int i = 0; i < 10; i++)
		{
			for(int j = 0; j < 10; j++)
			{
				for(int k = 0; k < 10; k++)
				{
					GameObject newCube = Instantiate(cube, new Vector3((i * 0.25f) - 1.125f, (j * 0.25f) - 1.125f, (k * 0.25f) - 1.125f), Quaternion.Euler(0, 0, 0)) as GameObject;
				}
			}
		}
	}

}
