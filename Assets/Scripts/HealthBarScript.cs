using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float currentHealth = 100;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Slider EaseHealthBar;
    private float lerpSpeed = 0.05f;

    [SerializeField] private int nextScene;
    private Counter counter;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        updateHealthBar(currentHealth, maxHealth);
        counter = GameObject.FindGameObjectWithTag("Player").GetComponent<Counter>();
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
            counter.addKilled();
            Destroy(gameObject);
        }
        Debug.Log("enemy health: "+currentHealth);
        
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
