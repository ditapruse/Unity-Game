using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour //Rename "Gunfire" to what your script name is
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("Gunshot"); //Rename to what your animation is called
        }

    }
}
