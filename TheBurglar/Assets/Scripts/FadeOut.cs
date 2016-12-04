using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour
{

    [Header("Indique o tempo da ação")]
    public float tempo;
    [Header("Indique o objeto da ação")]
    public SpriteRenderer sprite;

    void Start()
    {
        StartCoroutine("goFadeOut");
    }

    IEnumerator goFadeOut()
    {
        while (sprite.color.a > 0.01f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a - (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 4);
        }
    }
}
