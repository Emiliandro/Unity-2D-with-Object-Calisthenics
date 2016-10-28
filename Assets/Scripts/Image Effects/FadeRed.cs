using UnityEngine;
using System.Collections;

public class FadeRed : MonoBehaviour {

    [Header("Indique a velocidade da ação")]
    public float tempo;
    private SpriteRenderer sprite;

    void Start () {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        goRed();
    }

    void goRed () {
        sprite.color = Color.red;
        StartCoroutine("anulaRed");

    }

    IEnumerator anulaRed() {
        while (sprite.color.g < 0.99f && sprite.color.b < 0.99f)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g + (Time.deltaTime / tempo), sprite.color.b + (Time.deltaTime / tempo), sprite.color.a);
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }

}
