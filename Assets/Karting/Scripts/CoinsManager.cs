using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static CoinsManager instance { get; private set; }
    public int coinsNumber=0;
    public TMP_Text coinsNum;
    public TMP_Text coinsWin;
    public TMP_Text coinsLose;

    private void Awake()
    {
        instance = this;
    }
    public void AddCoins()
    {
        coinsNumber+=1;
        coinsNum.text = CoinsManager.instance.coinsNumber.ToString();
    }

}
