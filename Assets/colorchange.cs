﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Color rainbow = Color.gray;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {

            GetComponent<Text>().color = rainbow;
        }
    }
}
