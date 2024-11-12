using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Character Chr;

    public Slider HpBarSlider;
    // Start is called before the first frame update
    void Start()
    {
        HpBarSlider.maxValue = Chr.Health;
    }

    // Update is called once per frame
    void Update()
    {
        HpBarSlider.value = Chr.Health;
        
    }
}
