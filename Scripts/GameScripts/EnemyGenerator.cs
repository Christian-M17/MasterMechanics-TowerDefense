using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EnemyGenerator : MonoBehaviour
{
    public float tempo = 5;
    private float padraotempo;
    public Transform PosicaoGerador;
    public GameObject Inimigo;
    
    

    // Start is called before the first frame update
    void Start()
    {
        padraotempo = tempo;
    }

    // Update is called once per frame
    void Update()
    {
        wavecheck();
        tempo -= Time.deltaTime;
        if(tempo <= 0 && Gerenciador.contador > 0)
        {
            Gerenciador.contador -= 1;
            Instantiate(Inimigo, PosicaoGerador.position + new Vector3(0, 1, 0), PosicaoGerador.rotation);
            tempo = padraotempo;
        }
        
    }
    void wavecheck()
    {
        if(Gerenciador.level >= 2){
            padraotempo = 2;
        }
    }

  
}
