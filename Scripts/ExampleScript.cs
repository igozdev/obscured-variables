using UnityEngine;
using ObscuredVariables;

// Example usage of OInt
public class ExampleScript : MonoBehaviour
{
    OInt PlayerHealth;
    
    private void Start()
    {
        PlayerHealth = new OInt(100);
        Debug.Log("Player health: " + PlayerHealth.Value());
    }

    public void DamagePlayer(OInt damage)
    {
        PlayerHealth -= damage;
        if (PlayerHealth.Value() <= 0)
            PlayerDeath();

        Debug.Log("Player health: " + PlayerHealth.Value());
    }

    private void PlayerDeath()
    {
        Debug.Log("Player death");
    }

    private void Update()
    {
        // Press 'D' to damage player
        if (Input.GetKeyDown(KeyCode.D))
            DamagePlayer(new OInt(15));
    }
}