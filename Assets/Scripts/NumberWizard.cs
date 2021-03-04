using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;



    // Use this for initialization
    void Start()
    {
        Guessing();
    }
    void Guessing()
    {
        guess = Random.Range(min, max +1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess +1;
        Guessing();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        Guessing();
    }

}
