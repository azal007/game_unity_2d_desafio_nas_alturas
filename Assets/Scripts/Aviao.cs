using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forcaImpulsaoCima;
    private Diretor diretor;

    private void Awake() {
        this.fisica = this.GetComponent<Rigidbody2D>();

        // Obtém o objeto diretor, declarado na Unity
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
	private void Update() {
        if (Input.GetButtonDown("Fire1"))  {
            this.Impulsionar();
        }
    }

    private void Impulsionar() {
        // Eliminate the acumulated force (from the gravity and from the clicks) that affects the plane
        this.fisica.velocity = Vector2.zero;

        // Push the plane up
        this.fisica.AddForce(Vector2.up * this.forcaImpulsaoCima, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao) {
        // Stop simulating physics
        this.fisica.simulated = false;

        this.diretor.FinalizarJogo();
    }
}
