using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour
{
    ParticleSystem ps;
    void Start()
    {
        ps = GetComponentInChildren<ParticleSystem>();
    }

    public void StartFlame()
    {
        ps.Play();
    }
}
