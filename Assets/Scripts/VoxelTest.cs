using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class VoxelTest : MonoBehaviour
{
    //public GameObject myMesh;
    public GameObject parent;
    public GameObject cube;
    public GameObject sphere;
    GameObject currentCube;
    List<GameObject> cubes = new List<GameObject>();
    List<Vector3> myVertices = new List<Vector3>();
    public GameObject mesh;

    Vector3 pos;
    Vector3 scale;

    public int nbIteration;
    int cubesCount;

    public bool destroyed = true;

    
    public Vector3[] vertices;
    public int verticeCount;


    void Update()
    {


		if (Input.GetKeyDown(KeyCode.Q))
        {
            mesh.GetComponent<VoxelManager>().ListGen(gameObject);
        }

		if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                if (mesh.GetComponent<VoxelManager>().b.Contains(transform.TransformPoint(vertices[i])))
                {

                    verticeCount++;
                }
                
            }
            if (verticeCount != 24)
            {
                verticeCount = 0;
                Divide();               
                Destroy(gameObject);
            }
            
        }

    }
	void Start ()
    {
        //Mesh mesh = myMesh.GetComponent<MeshFilter>().mesh;
        //Vector3[] vertices = mesh.vertices;

        /*for (int i = 0; i<vertices.Length;i++)
        {
            //if (vertices[i])
        }*/

        Mesh meshVertice = GetComponent<MeshFilter>().mesh;
        vertices = meshVertice.vertices;
        //myVertices = transform.TransformPoint.vertices;



            pos = cube.transform.position;
        scale = cube.transform.localScale;
        if (nbIteration>0)
        {
            Divide();
            Destroy(gameObject);
            //GetComponent<Renderer>().enabled;
        }
        
        
        /*for (int i = 1; i<nbIteration;i++)
        {
            cubesCount = cubes.Count;
            for(int j = 0; j<cubesCount;j++)
            {
                pos = cubes[j].transform.position;
                scale = cubes[j].transform.localScale;
                Divide();                
                cubes.Remove(cubes[j]);
                
            }

        }*/


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
        c.GetComponent<VoxelTest>().destroyed = true;
        c.gameObject.transform.parent = parent.transform;
        //c.transform.SetParent(gameObject.transform);
    }

    void OnTriggerEnter (Collider col)
    {
        if (/*nbIteration == 0 &&*/ col.gameObject.tag == ("MYMESH")) /*Destroy(gameObject)*/destroyed = false;
        if (col.gameObject.tag == ("SPHERE"))
        {
                        
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            //gameObject.GetComponent(Physics)
            gameObject.GetComponent<Physics>().enabled = true;
            //gameObject.GetComponent<Rigidbody>().AddForce(1, 1, 1);
        }
        if (col.gameObject.tag == ("DESTROYER"))
        {
            Destroy(gameObject);
        }
    }

    /*void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(sphere, gameObject.transform.position, Quaternion.identity);
        }
    }*/
}
