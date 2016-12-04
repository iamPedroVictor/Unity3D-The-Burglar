using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour
{

    [Header("Indique o tempo da ação")]
    public float tempo;
    [Header("Indique o objeto da ação")]
    public SpriteRenderer sprite;

    void Start()
    {
        sprite.color = Color.clear;
        StartCoroutine("goFadeIn");
    }

    IEnumerator goFadeIn()
    {
        while (sprite.color.a < 0.99f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a + (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }
}