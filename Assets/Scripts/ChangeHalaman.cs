﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHalaman : MonoBehaviour
{
    public GameObject next;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePanel()
    {
        next.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
