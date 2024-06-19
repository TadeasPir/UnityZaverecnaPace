using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBarScriptEnemy : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float currentHealth = 100;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Slider EaseHealthBar;
    private float lerpSpeed = 0.05f;

    [SerializeField] private int nextScene;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        updateHealthBar(currentHealth, maxHealth);
    }

    public void Update()
    {
        updateHealthBar(currentHealth, maxHealth);
        if (currentHealth <= 0)
        {
            Die();
        }

        if(healthBar.value != EaseHealthBar.value)
        {
            EaseHealthBar.value = Mathf.Lerp(EaseHealthBar.value, currentHealth, lerpSpeed);
        }
    }

    public void updateHealthBar(float currentValue, float maxValue)
    {
        healthBar.value = currentValue;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        Debug.Log("player health: " + currentHealth);
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
