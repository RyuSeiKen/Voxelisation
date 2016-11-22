using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

   public float speed;

	void Update () {

        


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, -speed * Time.deltaTime);
        }

    }
}
