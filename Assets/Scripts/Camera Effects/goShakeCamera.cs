using UnityEngine;
using System.Collections;

public class goShakeCamera : MonoBehaviour {

    [Header("Qual o alvo?")]
    public GameObject alvo;
    public float velocidade;

    [Header("Tempo de duração efeito")]
    public float tempo_total;
    private float valorAtual, tempo_limite;

    [Header("Controle do efeito")]
    public float minima;
    public float maxima;
    private GameObject camera;
    private int escolha;

    void Start(){
        Time.timeScale = 2f;
        tempo_limite = tempo_total;
        tempo_total = 0;
    }

    void shakeEffect() {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        escolha = Random.RandomRange(0, 4);
        if (escolha == 0) camera.transform.position = new Vector2(camera.transform.position.x + Random.RandomRange(minima, maxima), camera.transform.position.y);
        if (escolha == 1) camera.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y + Random.RandomRange(minima, maxima));
        if (escolha == 2) camera.transform.position = new Vector2(camera.transform.position.x - Random.RandomRange(minima, maxima), camera.transform.position.y);
        if (escolha == 3) camera.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y - Random.RandomRange(minima, maxima));
    }

    void Update () {
        valorAtual += Time.deltaTime;
        Debug.Log(valorAtual);
        if (valorAtual < tempo_limite) shakeEffect();
        if (valorAtual > tempo_limite) AnularEfeito();
    }

    void AnularEfeito() {
        camera.transform.position = Vector2.MoveTowards(transform.position, alvo.transform.position, velocidade * Time.deltaTime);
    }
}
