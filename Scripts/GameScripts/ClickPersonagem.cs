using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPersonagem : MonoBehaviour
{
    public int id;
    public void AtivarPersonagem(int id)
    {

        Gerenciador.pativo = id;

    }

}
