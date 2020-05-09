﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    [SerializeField]
    private GameObject manualDeInstrucoes;

    // Quando chega a zero é a hora de criar novo obstáculo
    private float cronometro;

    private void Awake() {
        this.cronometro = this.tempoParaGerar;
    }

	private void Update() {
        this.cronometro -= Time.deltaTime;

        if (this.cronometro < 0) {
            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }

}
