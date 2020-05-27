using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {
    [SerializeField]
    private GameObject imagemGameOver;

    public void FinalizarJogo() {
        // Para o jogo, parando o tempo
        Time.timeScale = 0;

        // Habilita a imagem de Game Over
        this.imagemGameOver.SetActive(true);
    }
}
