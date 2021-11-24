using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 InitialPos;
    public float Speed = 10f;

    public float VerticalInput;
    public float TurnSpeed = 20f;

    public float zMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Speed * Time.deltaTime * VerticalInput);

        if (zMax >= 450)
        {
            Debug.Log("THE END");
        }
    }
}
