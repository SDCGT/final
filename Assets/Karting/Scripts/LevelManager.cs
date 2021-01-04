using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelManager instance;
    public int levelNum= 1 ;
    void Start()
    {
        instance = this;
    }

}
