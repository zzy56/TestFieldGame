using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkBackGround : MonoBehaviour
{
    public Image image;
    public GameObject player;
    public Vector3 startingPosition;
    public Color colorToBeUsed = new Color(0f, 0f, 0f, 0f);
    public float alpha;
    public float currentAlpha;
    public float speedOfTransition = 70;

    private Vector3 playerPos;
    


    // Start is called before the first frame update
    void Start()
    {
        
        image = GetComponent<Image>();

        colorToBeUsed = image.color;

        currentAlpha = image.color.a;

    }

    // Update is called once per frame
    void Update()
    {
        alpha = colorToBeUsed.a;

        currentAlpha = player.transform.position.x;
        if (currentAlpha > 0.1)
        {
            colorToBeUsed.a = currentAlpha / speedOfTransition;

            image.color = colorToBeUsed;
        }
        
    }
}
