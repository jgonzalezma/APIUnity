using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textCoin;

    int numCoins;
    
    //Funcion publica que va a ser llamada desde el script del Player cuando este obtenga la moneda (onTrigger)
    public void AddCoin()
    {
        numCoins++; //sumo 1
        //muestro por la interfaz;
        textCoin.text = "" + numCoins.ToString();
    }
}
