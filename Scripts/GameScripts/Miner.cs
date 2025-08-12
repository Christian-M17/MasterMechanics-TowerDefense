using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner
    : MonoBehaviour
{
    public float tempopadrao;
    public int regen;
    float tempo;
    
   
    float dist;

    void Start()
    {
        tempo = tempopadrao;
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            Gerenciador.money += regen;
            tempo = tempopadrao;
        }
    }
}
