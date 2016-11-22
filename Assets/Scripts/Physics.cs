using UnityEngine;
using System.Collections;

public class Physics : MonoBehaviour
{

    Vector3 initialForce;
    Vector3 initialRotationForce;

    float rotationPush;
    float rotationLateral;
    float rotationForward;

    float push;
    float lateral;
    float lateralb;
    float randomRotation;
    float randomRotationb;
    float randomRotationc;

    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        push = Random.Range(-5.0f, 5.0f);
        lateral = Random.Range(-5.0f, 5.0f);
        lateralb = Random.Range(-5.0f, 5.0f);
        randomRotation = Random.Range(0.0f, 180.0f);
        randomRotationb = Random.Range(0.0f, 180.0f);
        randomRotationc = Random.Range(0.0f, 180.0f);

        float rotationPush = Random.Range(10.0f, 360.0f);
        float rotationLateral = Random.Range(10.0f, 360.0f);
        float rotationForward = Random.Range(10.0f, 360.0f);


        initialForce = new Vector3(push, lateral, lateralb);
        initialRotationForce = new Vector3(rotationPush, rotationLateral, rotationForward);

        rb = GetComponent<Rigidbody>();

        rb.AddForce(initialForce, ForceMode.Impulse);
        rb.AddTorque(initialRotationForce, ForceMode.Impulse);

        Quaternion rotation = Quaternion.identity;
        rotation.eulerAngles = new Vector3(randomRotation, randomRotationb, randomRotationc);
        rb.rotation = rotation;

    }

}