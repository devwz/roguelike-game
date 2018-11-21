using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite; // altera o sprite da parede após ataque
    public int hp = 3; // hp da parede

    public AudioClip chopSound1;
    public AudioClip chopSound2;

    // referencia os sprites
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // chamado quando jogador ataca a parede
    public void DamageWall(int loss)
    {
        SoundManager.instance.RandomizeSfx(chopSound1, chopSound2);
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;

        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
