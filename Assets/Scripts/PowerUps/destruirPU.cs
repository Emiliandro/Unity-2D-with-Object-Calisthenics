using UnityEngine;
using System.Collections;

public class destruirPU : MonoBehaviour {

    [Header("Indique o tempo da ação")]
    public float tempo;

    void Start()
    {
        Invoke("anularEfeito", tempo);
    }

    void anularEfeito()
    {
        Destroy(this.gameObject);
    }

}
