using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectCoins : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource coinsplay;
    public AudioClip coinscollect;

    private void Start()
    {
        coinsplay = this.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="coins")
        {
            CoinsManager.instance.AddCoins();
            Destroy(other.gameObject);
            coinsplay.PlayOneShot(coinscollect);
        }
    }
}
