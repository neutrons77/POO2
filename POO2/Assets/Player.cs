using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 posicao = transform.position;
        
        //esquerda x-
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
        }
        //direita x+
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
        }
        //cima+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
        }
        //cima+
        if (Input.GetKey(KeyCode.Space))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
        }
        //boixo-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
        }
        transform.position = posicao;
    }

}

