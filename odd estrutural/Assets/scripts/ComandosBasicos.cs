using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosBasicos : MonoBehaviour
{
    public int velocidade; //VARIAVEL DE VELOCIDADE;
    private Rigidbody2D ODD; //ATRIBUINDO CORPO RIGIDO AO PERSONAGEM;
    public float forcaPulo; //VARIAVEL FLOAT PARA PULO;

    public bool sensor; //COLIZADOR DO SENSOR;
    public Transform posicaoSensor; // POSI��O DO SENSOR;
    public LayerMask layerChao; //AREA DE INTERA��O DO SENSOR;
    // Start is called before the first frame update
    void Start()
    {
        ODD = GetComponent<Rigidbody2D>(); //DEFININDO COMPONENTE PARA PERSONAGEM;
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal"); //ADI�AO DE MOVIMENTO COMPONENTE HORIZONTAL;

        ODD.velocity = new Vector2(movimentoX * velocidade, ODD.velocity.y); //VECTOR DE VELOCIDADE VARIAVEL;

        if (Input.GetButtonDown("Jump") && sensor == true) //MOVIMENTO DE PULO ATRAVES DO SENSOR;
        {
            ODD.AddForce(new Vector2(0, forcaPulo)); //MOVIMENTO DO SALTO/FOR�A;
        }
    }
}
