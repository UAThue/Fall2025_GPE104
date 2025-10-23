using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public float score;
    public List<DamageOnOverlap> damageZones;
    [Header("Timer")]
    public float timeRemaining;
    public float maxTime;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        // Start with an empty list
        damageZones = new List<DamageOnOverlap>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTimer()
    {
        // Set the timer to max time
        timeRemaining = maxTime;
    }
}
