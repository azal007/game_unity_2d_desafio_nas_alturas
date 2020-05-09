﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forcaImpulsaoCima = 10;

    // Start is called before the first frame update
    void Start()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
	private void Update() {
        if (Input.GetButtonDown("Fire1"))  {
            this.Impulsionar();
        }
    }

    private void Impulsionar() {
        this.fisica.AddForce(Vector2.up * this.forcaImpulsaoCima, ForceMode2D.Impulse);
    }
}
