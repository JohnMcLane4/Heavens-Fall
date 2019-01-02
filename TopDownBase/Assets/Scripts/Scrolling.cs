﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

    [SerializeField]
    private float scrollSpeed = 1;

	// Update is called once per frame
	void Update ()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * 0.05f * scrollSpeed, 0);
	}
}
