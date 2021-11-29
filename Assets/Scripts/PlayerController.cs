using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 InitialPos = new Vector3 (0, 0, 0);
    private float Speed = 12f;

    private float VerticalInput;
    private float TurnSpeed = 30f;

    private float zMax = 450;

    // Start is called before the first frame update
    void Start()
    {
        //Posición inicial
        transform.position = InitialPos;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento hacia delante
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Tomamos el eje vertical del Input Manager y rotamos en X
        VerticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * TurnSpeed * Time.deltaTime * VerticalInput);

        //Si la variable supera lo establecido FIN DEL JUEGO
        if (transform.position.z >= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
