using UnityEngine;
using System.Collections;

public class MarchingCube : MonoBehaviour 
{
	Vector3[] vertices = new Vector3[8];
	public bool[] inMesh = new bool[8];
	public GameObject cube;
	GameObject newCube;
	public GameObject largeObject;

	public GameObject marchingCube1;
	public GameObject marchingCube2;
	public GameObject marchingCube3;
	public GameObject marchingCube4;
	public GameObject marchingCube5;
	public GameObject marchingCube6;
	public GameObject marchingCube7;
	public GameObject marchingCube8;
	public GameObject marchingCube9;
	public GameObject marchingCube10;
	public GameObject marchingCube11;
	public GameObject marchingCube12;
	public GameObject marchingCube13;
	public GameObject marchingCube14;
	public GameObject marchingCube15;

	void Awake()
	{
		//On prend la position de tous les gameobject "vertex" enfant du cube original.
		int j = 0;
		foreach(Transform child in cube.transform)
		{
			vertices[j] = child.localPosition;
			j++;
		}
	}

	public void CubeReplacer()
	{
		//Desactivation du cube original
		cube.SetActive(false);

		//Cube1
		if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube1, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}

		//Cube2
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, -180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube2, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}

		//Cube3
//		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
//		}
//		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -180, 90)) as GameObject;
//		}
//		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
//		}
//		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
//		}
//		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
//		}
//		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
//		{
//			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
//		}

		else
		{			
			newCube = Instantiate(marchingCube1, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
	}

	public void StandardCube()
	{
		cube.SetActive(true);
		newCube.SetActive(false);
	}
	public void AdvancedCube()
	{
		cube.SetActive(false);
		newCube.SetActive(true);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		for(int i = 0; i < vertices.Length; i++)
		{
			if(inMesh[i])
			{
				Gizmos.color = Color.green;
			}
			else
			{
				Gizmos.color = Color.red;
			}
			Gizmos.DrawSphere(cube.transform.position + vertices[i], 0.1f);
		}
	}
}