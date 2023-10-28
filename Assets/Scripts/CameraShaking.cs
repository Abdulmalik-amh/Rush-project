using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaking : MonoBehaviour
{
	// The wingsuit script that the player has
    public DiveMovement wc;
    // The amount of shaking
    public float shaking = 0.5f;

    private void LateUpdate()
    {
    	// Will affect the shaking based on the player's x rotation
        float mod_shaking = shaking * wc.percentage;
        // Give the camera a random position based on the percentage and shaking variables
        transform.localPosition = new Vector3(Random.Range(-mod_shaking, mod_shaking), Random.Range(-mod_shaking, mod_shaking), 0);
    }
}