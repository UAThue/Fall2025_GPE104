using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{

    public bool isInstaKill;
    public float damageDone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("hit!" + other.gameObject.name);

        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageDone);
        }

    }
}
