using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text end;
    void Start()
    {
        end.text = CoinsManager.instance.coinsNumber.ToString();
    }
}
