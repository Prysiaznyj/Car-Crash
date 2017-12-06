using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {

    private Quaternion localRotation; // controle local da rotacao
    public float velocidade = 1.0f;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        // ajustando a rotacao inicial do objeto com o controle local
        localRotation = transform.rotation;
    }


    void Update()
    {
        // velocidade considerando o deltaTime
        float velocidadeAtual = Time.deltaTime * velocidade;

        // primeiro atualize o controle interno de acordo com o input do acelerometro
        localRotation.z -= Input.acceleration.x * velocidadeAtual;
        
        //localRotation.x += Input.acceleration.y * velocidadeAtual;

        // rotacionar o objeto conforme o novo angulo
        transform.rotation = localRotation;
    }
    /*
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 10, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate( 0, -10, 0);
        }
    }*/
}
