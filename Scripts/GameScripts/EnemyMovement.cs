using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] locais;
    private Transform pontoReferencia;
    public float velocidade;
    private float velocidadepadrao;
    public Transform objetotransform;
    // Start is called before the first frame update
    void Start()
    {
        locais[0] = GameObject.FindWithTag("Finish").transform;
        pontoReferencia = locais[0];
        velocidadepadrao = velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        wavecheck();
        objetotransform.position = Vector3.MoveTowards(objetotransform.position, pontoReferencia.position , velocidade * Time.deltaTime);
    }

    void wavecheck()
    {
        if(Gerenciador.level == 3 && velocidade != (velocidadepadrao + 0.5f))
        {
            velocidade += 0.5f;
        }
    }
}
