﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public CameraController cam;
    public int health;
    private int maxHealth = 100;

    private void Start()
    {
        health = maxHealth;
    }

    public int getMaxHealth()
    {
        return maxHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            cam.targets.Remove(transform);
            cam.movable = true;
            Destroy(gameObject);
        }
    }
    public void Heal(int hp)
    {
        health += hp;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

}
