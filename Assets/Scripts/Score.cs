﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //recupere le component text et lui attribut la valeur de Score en String
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();    
    }
}
