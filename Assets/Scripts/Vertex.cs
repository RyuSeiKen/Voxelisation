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

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Object")
		{
			inside = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Object")
		{
			inside = false;
		}
	}

//	void Update()
//	{
//		if(Input.GetKey(KeyCode.Space))
//		{
//			manager.GetComponent<MarchingCube>().inMesh[vertexNumber] = inside;
//		}
//	}
}
