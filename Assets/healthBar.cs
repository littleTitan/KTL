﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {
    public health hp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hp.damage == 5.98f)
        {
            
            transform.Translate(Vector3.left * 0.0598f);
            hp.damage = 0;
        }
	}
}