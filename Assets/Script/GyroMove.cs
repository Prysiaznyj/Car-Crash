using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour {

    public float speed = 1f;

    void Update()
    {
        float vel = Input.acceleration.x;

        transform.Translate(vel * speed, 0, 0);

    }

   /* //private Quaternion localRotation; // controle local da rotacao
    private Quaternion localRotation;
    public float velocidade = 1.0f;

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
        if (Input.acceleration.x > 0.1 || Input.acceleration.x < -0.1)
        {
            localRotation.y += Input.acceleration.x * velocidadeAtual;
        }
        //localRotation.x += Input.acceleration.y * velocidadeAtual;

        // rotacionar o objeto conforme o novo angulo
        transform.rotation = localRotation;
    }*/

    /*public bool isFlat = true;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rigid.AddForce(tilt);
        
    }*/

    /*bool gyroEnabled = false;

	
	void Start () {
        gyroEnabled = Input.gyro.enabled;

        if (!gyroEnabled)
            Input.gyro.enabled = true;
	}

	void Update () {
        var gyroSpeed_z = Input.gyro.rotationRateUnbiased.z;
        var rotateFactor = 300.0f;
        var carSpeed = 6.00f;

        //Giroscopio 
        if(Mathf.Abs(gyroSpeed_z) > 0.08f)
        {
            transform.RotateAround(transform.position, Vector3.down,
                gyroSpeed_z * rotateFactor * Time.deltaTime);
        }
        //Mover o carro automaticamente
        transform.Translate(Vector3.down * carSpeed * Time.deltaTime);
	}
    void OnApplicationQuit()
    {
        if(!gyroEnabled)
        {
            Input.gyro.enabled = false;
        }
        
    }*/
}
