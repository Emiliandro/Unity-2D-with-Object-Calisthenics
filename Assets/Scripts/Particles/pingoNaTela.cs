using UnityEngine;
using System.Collections;

public class pingoNaTela : MonoBehaviour {

    [Header("Objeto a instanciar")]
    public GameObject objeto;

    [Header("Controle do efeito")]
    public float minima;
    public float maxima;


    // Use this for initialization
    void Start () {
        Instantiate(objeto, new Vector2 (Random.RandomRange(minima, maxima), Random.RandomRange(minima, maxima)), Quaternion.identity);
	
	}
	

}
