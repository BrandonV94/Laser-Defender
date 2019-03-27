using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField] float backgroundScrollSPeed = 0.5f;
    Material myMaterial;
    Vector2 offSet;

    // Sets the Renederer component on the background to the variable myMaterial.
    // Creates the vector2 variable offSet
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(0, backgroundScrollSPeed);
    }

    // Updates the offset depending on the amount of time that has passed.
    void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
