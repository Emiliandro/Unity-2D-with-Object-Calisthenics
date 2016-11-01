using UnityEngine;
using System.Collections;

public class matriz: MonoBehaviour {
    
    // Relacionada a matriz
    public float altura, largura;
    public int linhas, colunas;
    // Relacionada ao power up
    public Transform posicao_inicial;
    public int pow_linha, pow_coluna;
    public GameObject power;

  
    void Start (){
        pow_linha = Random.RandomRange(0,linhas);
        pow_coluna = Random.RandomRange(0,colunas);
        posicao_inicial = gameObject.GetComponent<Transform>();
        Debug.Log("linha: " + pow_linha + ", coluna: " +pow_coluna);
        matrizSetup();


    }
    
    void powerup(int i, int u){
        if ((i == pow_linha) && (u == pow_coluna)){
        Instantiate(power, new Vector2
                    (posicao_inicial.position.x + (i * largura),
                    posicao_inicial.position.y + (u * altura)),
                    Quaternion.identity);    
        }
    }
        void matrizSetup(){
        for (int i=0; i < linhas; i++){
            for (int u = 0; u < colunas; u++){
                powerup(i,u);
            }
        }
    }    
    
}