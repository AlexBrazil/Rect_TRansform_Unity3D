using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemple : MonoBehaviour
{
    [SerializeField]
    private int speed; 

    private RectTransform recttransformImage;

    void Start()
    {
        recttransformImage = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        recttransformImage.anchoredPosition += Vector2.right * speed * Time.deltaTime;
        if (recttransformImage.anchoredPosition.x > 1920 ) {
            recttransformImage.anchoredPosition = new Vector2(recttransformImage.anchoredPosition.x - (2 * 1920), recttransformImage.anchoredPosition.y);
        }
    }
}
