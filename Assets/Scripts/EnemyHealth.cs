using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

   
    public EnemyHealth instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
 
    }
    private void Update()
    {
       
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
