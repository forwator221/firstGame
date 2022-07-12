using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;

    public GameObject deadScreen;
    public HealthBar healthBar;

    AnimatorManager animatorManager;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
    }

    void Start()
    {
        deadScreen.SetActive(false);
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        healthBar.SetCurrentHealth(currentHealth);

        animatorManager.PlayTargetAnimation("GetHit", true);

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            animatorManager.PlayTargetAnimation("Dead", true);
            deadScreen.SetActive(true);
        }
    }
}
