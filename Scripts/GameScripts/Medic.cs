using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic
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
        if (tempo <= 0 && Gerenciador.life <= 100 - regen)
        {
            Gerenciador.life += regen;
            tempo = tempopadrao;
        }
        else if(tempo <= 0)
        {
            tempo = tempopadrao;
        }
        
    }
}
