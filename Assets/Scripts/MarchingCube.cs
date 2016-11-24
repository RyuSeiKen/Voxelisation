using UnityEngine;
using System.Collections;

public class MarchingCube : MonoBehaviour 
{
	Vector3[] vertices = new Vector3[8];
	public bool[] inMesh = new bool[8];
	GameObject newCube;

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

	GameObject[] cubes;

	void Awake()
	{
		//On prend la position de tous les gameobject "vertex" enfant du cube original.

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			cubes = GameObject.FindGameObjectsWithTag("Cube");
			foreach(GameObject cube in cubes)
			{
				CubeReplacer(cube);
			}
		}
	}

	//Cette fonction remplace le cube par le marching cube adapté en fonction de la position de ses vertices.
	public void CubeReplacer(GameObject cube)
	{
		int j = 0;
		foreach(Transform child in cube.transform)
		{
			inMesh[j] = child.GetComponent<Vertex>().inside;
			j++;
		}
			
		//En cas d'absence du mesh, on ne créé rien.
//		if(!inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
//		{			
//			return;
//		}

		//Cube1. généré dans 1 cas
		if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube1, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}

		//Cube2, généré dans 8 cas
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

		//Cube3, généré dans 12 cas
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 0, 180)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -90, 180)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 180, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 180)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube3, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}

		//Cube4, généré dans 12 cas
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(-90, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(-90, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(90, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube4, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}

		//Cube5, généré dans 24 cas
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, -90, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 180, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(-90, -90, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(90, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(-90, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(90, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(-90, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(90, 90, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(0, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(-90, 180, -90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(180, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube5, cube.transform.position, Quaternion.Euler(90, 180, -90)) as GameObject;
		}

		//Cube6, généré dans 6 cas
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(180, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(-90, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(0, 0, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube6, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}

		//Cube7, généré dans 24 cas
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, -90, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 180, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 90, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(-90, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(90, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(-90, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(90, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(180, 90, -90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(-90, 90, -90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 90, -90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(90, 90, -90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(-180, 0, -90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(-90, 0, -90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(0, 0, -90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube7, cube.transform.position, Quaternion.Euler(90, 0, -90)) as GameObject;
		}

		//Cube8, généré dans 2 cas
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube8, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube8, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}

		//Cube9, généré dans 8 cas
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 180, 180)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 90, 180)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 0, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, -90, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube9, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}

		//Cube10, généré dans 12 cas
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 180, 180)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 90, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, 0, 180)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(0, -90, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(180, 0, 90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(180, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(180, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube10, cube.transform.position, Quaternion.Euler(180, 90, 90)) as GameObject;
		}

		//Cube11, généré dans 4 cas
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube11, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube11, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube11, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube11, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}

		//Cube12, généré dans 24 cas
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(-90, 180, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(-90, 180, -90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(-90, 180, 180)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(-90, 180, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(90, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(90, 180, 180)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(90, 180, -90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(90, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, -90, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 180, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 0, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(180, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 180, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube12, cube.transform.position, Quaternion.Euler(0, -90, 90)) as GameObject;
		}

		//Cube13, généré dans 8 cas
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(90, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(90, 0, 180)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube13, cube.transform.position, Quaternion.Euler(90, 0, -90)) as GameObject;
		}

		//Cube14, généré dans 6 cas
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(90, 0, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(0, 90, 90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube14, cube.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
		}

		//Cube15, généré dans 12 cas
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(90, 0, -90)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(90, 0, 0)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(90, 0, 90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(90, 0, 180)) as GameObject;
		}
		else if(inMesh[0] && !inMesh[1] && !inMesh[2] && inMesh[3] && !inMesh[4] && !inMesh[5] && inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(180, -90, 90)) as GameObject;
		}
		else if(inMesh[0] && inMesh[1] && !inMesh[2] && !inMesh[3] && inMesh[4] && !inMesh[5] && !inMesh[6] && inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(180, 180, 90)) as GameObject;
		}
		else if(!inMesh[0] && inMesh[1] && inMesh[2] && !inMesh[3] && inMesh[4] && inMesh[5] && !inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(180, 90, 90)) as GameObject;
		}
		else if(!inMesh[0] && !inMesh[1] && inMesh[2] && inMesh[3] && !inMesh[4] && inMesh[5] && inMesh[6] && !inMesh[7])
		{
			newCube = Instantiate(marchingCube15, cube.transform.position, Quaternion.Euler(180, 0, 90)) as GameObject;
		}

		if(newCube != null)
		{
			newCube.transform.localScale = cube.transform.localScale;
		}

		//Desactivation du cube original
		cube.SetActive(false);
		//Dans tous les autres cas, c'est à dire que moins de 4 vertices du cube sont dans le mesh, on n'affiche rien.
//		else
//		{
//			return;
//		}

	}

//	public void StandardCube()
//	{
//		cube.SetActive(true);
//		newCube.SetActive(false);
//	}
//	public void AdvancedCube()
//	{
//		cube.SetActive(false);
//		newCube.SetActive(true);
//	}

//	void OnDrawGizmos()
//	{
//		for(int i = 0; i < vertices.Length; i++)
//		{
//			if(inMesh[i])
//			{
//				Gizmos.color = Color.green;
//			}
//			else
//			{
//				Gizmos.color = Color.red;
//			}
//			Gizmos.DrawSphere(cube.transform.position + vertices[i], 0.1f);
//		}
//	}
}