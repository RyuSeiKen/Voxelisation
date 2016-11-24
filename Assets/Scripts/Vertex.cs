using UnityEngine;
using System.Collections;

public class Vertex : MonoBehaviour 
{	
	public int vertexNumber;
	public bool inside = false;
	GameObject manager;

	void Start()
	{
		manager = GameObject.Find("CubeManager");
	}

	void OnTriggerEnter()
	{
		inside = true;
	}
	void OnTriggerExit()
	{
		inside = false;
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			manager.GetComponent<MarchingCube>().inMesh[vertexNumber] = inside;
		}
	}
}
