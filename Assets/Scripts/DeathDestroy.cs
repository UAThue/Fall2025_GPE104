using UnityEngine;

public class DeathDestroy : Death
{
    public override void Die()
    {
        // Destroy the game object that this script is on
        Destroy(gameObject);
    }
}
