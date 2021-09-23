using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Slider hpSlider;

    [SerializeField]
    private AyakotanController ayakotan;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateHealthUI();
    }

    //public void UpdateHealthUI()
    //{
    //    hpSlider.maxValue = ayakotan.maxHealth;
    //    hpSlider.value = ayakotan.currentHealth;
    //}
}
