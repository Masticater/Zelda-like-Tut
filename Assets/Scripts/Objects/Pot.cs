﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour, IDamageable<float, Player>
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damageTaken, Player damageGiver)
    {
        Destroy();
        anim.enabled = true;
    }

    public void Destroy()
    {
        anim.SetBool("Destroyed", true);
        Invoke("Disable", 2f);
    }
    
    void Disable()
    {
        anim.SetBool("Destroyed", false);
        gameObject.SetActive(false);
    }
}