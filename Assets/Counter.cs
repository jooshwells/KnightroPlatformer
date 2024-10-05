using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Counter : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    void Start()
    {
        
    }

    void Update()
    {
        coinText.text = "Coint Count: " + coinCount.ToString();
    }
}
