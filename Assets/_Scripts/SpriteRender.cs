using UnityEngine;
using System.Collections;

public class SpriteRender : MonoBehaviour
{

    public Sprite spriteBig;
    public Sprite spriteSmall;

    private bool triggerCount = false;

    private SpriteRenderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        if (rend.sprite == null)
        {
            rend.sprite = spriteBig;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerCount == true)
        {
            ChangeSprite();
        }
    }

    void OnTriggerEnter2D()
    {
        triggerCount = true;
    }

    void ChangeSprite()
    {
        if (rend.sprite == spriteBig)
        {
            rend.sprite = spriteSmall;
            Destroy(GetComponent<CircleCollider2D>());
            gameObject.AddComponent<CircleCollider2D>();
        }
    }
}