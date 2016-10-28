using UnityEngine;
using System.Collections;

public class MoveFourSides : MonoBehaviour {

    [Header("habilite pra permitir 4 sentidos")]
    public bool Vertical;
    private string horizontal = "Horizontal", vertical = "Vertical";
    [Header("indique a velocidade")]
    public float velocidade;

    void FixedUpdate() {
        if (Input.GetAxis(horizontal) < 0) 
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x - (velocidade / 5), transform.position.y), (velocidade * 5) * Time.deltaTime);
        
        if (Input.GetAxis(horizontal) > 0)
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + (velocidade / 5), transform.position.y), (velocidade * 5) * Time.deltaTime);

        if (Input.GetAxis(vertical) < 0 && Vertical)
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y - (velocidade / 5)), (velocidade * 5) * Time.deltaTime);
      
        if (Input.GetAxis(vertical) > 0 && Vertical)
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y + (velocidade / 5)), (velocidade * 5) * Time.deltaTime);
    }
}
