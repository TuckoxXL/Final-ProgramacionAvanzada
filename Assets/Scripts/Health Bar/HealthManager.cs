using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private Image HealthBar;
    [SerializeField] private PlayerHealth Health;

    private void OnEnable()
    {
        PlayerHealth.HealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        PlayerHealth.HealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar()
    {
        float currentHealth = Health.CurrentHealth;
        float maxHealth = Health.MaxHealth;
        HealthBar.fillAmount = currentHealth / maxHealth;
    }
}
