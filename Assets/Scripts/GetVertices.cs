using UnityEngine;
using System.Collections;

public class GetVertices : MonoBehaviour
{
    Vector3 currentCubeScale;
    Vector3 cubePos;
    public Vector3 cubeScale;
    public GameObject cube;
    void Start()
    {
        cube.transform.localScale = cubeScale;
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        for (int i = 0; i<vertices.Length/3;i++)
        {
            currentCubeScale = transform.localScale;
            cubePos = transform.position;
            transform.localScale = new Vector3(1, 1, 1);
            transform.position = Vector3.zero;
           print(vertices[i]);
           GameObject currentCube =  GameObject.Instantiate(cube, new Vector3(vertices[i].x, vertices[i].y, vertices[i].z), Quaternion.identity)as GameObject;
           currentCube.transform.SetParent(gameObject.transform);
            transform.localScale = currentCubeScale;
            transform.position = cubePos;
            
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
    }
}