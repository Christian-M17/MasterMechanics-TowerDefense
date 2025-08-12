using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using TMPro;


public class Gerenciador : MonoBehaviour
{
    public static int money;
    public static int life;
    public static int level;
    public static int contador;
    public static int mortos;
    private bool wavestarted;
    public TMP_Text moneytext;
    public TMP_Text wavetext;
    public TMP_Text lifetext;
    public GameObject[] personagens;
    public static int pativo = 69;
    void Start()
    {
        money = 120;
        life = 100;
        level = 1;
        contador = 0;
        mortos = 0;
        wavestarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        lifetext.text = "Life: " + life;
        moneytext.text = "Money: " + money;
        wavetext.text = "Wave " + level;
        verificadorvida();
        levelsCheck();
        verificadorteclas();
        visualselecionado(pativo);
    }

    void levelsCheck()
    {
        int valor;
        switch (level)
        {
            case 1:
                valor = 10;

                if (wavestarted == true)
                {
                    Debug.Log("Wave atual: " + level);
                    contador = valor;
                    wavestarted = false;
                    mortos = 0;
                }
                else if (mortos == valor) { level += 1;
                    wavestarted = true;
                }
                break;
            case 2:
                valor = 15;

                if (wavestarted == true)
                {
                    Debug.Log("Wave atual: " + level);
                    contador = valor;
                    wavestarted = false;
                    mortos = 0;
                    money += 25;
                }
                else if (mortos == valor) { level += 1; wavestarted = true; }
                break;
            case 3:
                valor = 20;

                if (wavestarted == true)
                {
                    Debug.Log("Wave atual: " + level);
                    contador = valor;
                    wavestarted = false;
                    mortos = 0;
                    money += 25;
                }
                else if (mortos == valor) { wavestarted = true; }

                break;

        }

    }
    void verificadorteclas()
    {
        if (Input.GetKeyDown("0")){
            pativo = 0;
        }
        if (Input.GetKeyDown("1")){
            pativo = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            pativo = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            pativo = 3;
        }
    }

    void verificadorvida()
    {
        if( life <= 0)
        {
            SceneManager.LoadScene("Menu");

        }
    }
    void visualselecionado(int valor)
    {
        for (int i = 0; i < personagens.Length; i++)
        {
            if (personagens[i] != null)
            {
                Image img = personagens[i].GetComponent<Image>();
                if (i == valor)
                {
                    img.color = Color.green; // Define a cor verde para o personagem selecionado
                }
                else
                {
                    img.color = Color.white; // Define a cor branca para os outros personagens
                }
            }
        }
    }
}
