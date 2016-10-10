using UnityEngine;
using System.Collections;

public class DestroyOnColliding : MonoBehaviour {

    [Header("Ao colidir vai receber um aviso no console")]
    private string aviso = "Colidiu, objeto destruido!";

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        Destroy(gameObject);
        print(aviso);
    }
}