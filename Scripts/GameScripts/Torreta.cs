using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public float tempopadrao;
    float tempo;
    public GameObject bala;
    public Transform torreTransform;
    public Transform pontoReferencia;
    public Transform armaPosicao;
    public float distancia = 5;
    float dist;

    void Start()
    {
        tempo = tempopadrao;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Enemy");
        pontoReferencia = null;
        dist = float.MaxValue;

        foreach (GameObject inimigo in inimigos)
        {
            float distTemp = Vector3.Distance(torreTransform.position, inimigo.transform.position);
            if (distTemp < dist && distTemp < distancia)
            {
                pontoReferencia = inimigo.transform;
                dist = distTemp;
            }
        }

        if (pontoReferencia != null && dist < distancia)
        {
            torreTransform.LookAt(pontoReferencia);
            torreTransform.rotation = Quaternion.Euler(0, torreTransform.rotation.eulerAngles.y, 0);
            tempo -= Time.deltaTime;
            if (tempo <= 0)
            {
                Instantiate(bala, armaPosicao.position + new Vector3(0, 0.3f, 0), torreTransform.rotation);
                tempo = tempopadrao;
            }
        }
        else
        {
            tempo -= Time.deltaTime;
        }
    }
}
