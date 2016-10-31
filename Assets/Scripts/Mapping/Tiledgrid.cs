using UnityEngine;
using System.Collections;

public class Tiledgrid : MonoBehaviour {

    [Header("Informações da imagem")]
    public GameObject tiled;
    private Transform posicao_inicial;
    public int altura;
    public int largura;

    [Header("Informações do grid")]
    public int blocos_de_altura;
    public int blocos_de_largura;

    void Start () {
        posicao_inicial = gameObject.GetComponent<Transform>();
        gridSetup();	
	}

	public void gridSetup () {
        for (int i=0; i < blocos_de_largura; i++)
        {
            for (int u = 0; u < blocos_de_altura; u++)
            {
                Instantiate(tiled, new Vector2
                    (posicao_inicial.position.x + (i * largura),
                    posicao_inicial.position.y + (u * altura)),
                    Quaternion.identity);
            }
        }
	}
}
