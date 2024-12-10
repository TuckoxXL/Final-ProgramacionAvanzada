using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    private int currentHealth;

    public static event Action HealthChanged;

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
        protected set
        {
            if (value > 0 && value < maxHealth)
            {
                currentHealth = value;
            }
            else if (value >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            else if (value <= 0)
            {
                currentHealth = 0;
                SceneManager.LoadScene("Derrota");
            }
        }
    }

    private void Awake()
    {
        CurrentHealth = maxHealth;
        HealthChanged?.Invoke();
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth += damage;
        HealthChanged?.Invoke();
    }
}
