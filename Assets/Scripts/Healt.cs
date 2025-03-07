using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    public int maxHealth=100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int _damage)
    {
        currentHealth -= _damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }
    public void Heal(int _healthPoints)
    {
        currentHealth += _healthPoints;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }

}
