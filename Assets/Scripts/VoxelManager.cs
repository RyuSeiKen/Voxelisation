using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VoxelManager : MonoBehaviour {

    public List<GameObject> myCubes = new List<GameObject>();
    public Bounds b;

    // Use this for initialization
    void Start () {

        b = new Bounds(gameObject.transform.position, gameObject.transform.localScale);
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.R))
        {
            myCubes.Clear();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0;i<myCubes.Count;i++)
            {
                if (myCubes[i].GetComponent<VoxelTest>().destroyed == true)
                {
                    Destroy(myCubes[i]);
                }
            }
        }
	}

    public void ListGen(GameObject currentCube)
    {
        myCubes.Add(currentCube);
    }
}
