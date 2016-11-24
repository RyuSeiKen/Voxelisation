using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class VoxelTest : MonoBehaviour
{
    public GameObject parent;
    public GameObject cube;
    GameObject currentCube;

    Vector3 pos;
    Vector3 scale;

    public int nbIteration;


    public bool destroyed = true;

    
    public Vector3[] vertices;
    public int verticeCount;

	int toNextFrame = 0;

	void Start ()
    {
		destroyed = true;
		pos = cube.transform.position;
        scale = cube.transform.localScale;

		StartCoroutine(CollisionCheck());

	}

	//We check the frame after Start if the block has collided with the environement and Divide if 
	public IEnumerator CollisionCheck()
	{
		while(toNextFrame < 1)
		{
			toNextFrame++;
			yield return null;
		}
		if (nbIteration > 0)
		{
			if (destroyed == false)
			{
				Divide();
			}
			Destroy(gameObject);
		}
		else if (destroyed == true)
		{
			Destroy(gameObject);
		}
		else
		{
			GetComponent<MeshRenderer>().enabled = true;
		}
		yield return null;
	}
	void Divide ()
    {
        currentCube = Instantiate(cube, new Vector3(scale.x / 4 + pos.x, scale.y / 4 + pos.y, scale.z / 4 + pos.z), Quaternion.identity)as GameObject;
        Rescale(currentCube);
        
        currentCube = Instantiate(cube, new Vector3(-scale.x / 4 + pos.x, scale.y / 4 + pos.y, scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(scale.x / 4 + pos.x, -scale.y / 4 + pos.y, scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(scale.x / 4 + pos.x, scale.y / 4 + pos.y, -scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(-scale.x / 4 + pos.x, -scale.y / 4 + pos.y, scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(scale.x / 4 + pos.x, -scale.y / 4 + pos.y, -scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(-scale.x / 4 + pos.x, scale.y / 4 + pos.y, -scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        currentCube = Instantiate(cube, new Vector3(-scale.x / 4 + pos.x, -scale.y / 4 + pos.y, -scale.z / 4 + pos.z), Quaternion.identity) as GameObject;
        Rescale(currentCube);

        nbIteration -= 1;
    }
    void Rescale (GameObject c)
    {
        c.transform.localScale = new Vector3(scale.x / 2, scale.y / 2, scale.z / 2);
        c.GetComponent<VoxelTest>().nbIteration = nbIteration - 1;
        c.gameObject.transform.parent = parent.transform;
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == ("Voxellize")) destroyed = false;
    }
}