using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    public Slider pegaslider;
    public TMP_Text textovolume;
    public float volume;
    // Start is called before the first frame update
    void Start()
    {
        pegaslider.onValueChanged.AddListener((v) => { textovolume.text = v.ToString("0.00");
            volume = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
