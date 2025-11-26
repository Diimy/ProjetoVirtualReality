using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int maxLife = 5;
    public int currentLife;
    public Transform respawnPoint;
    private HeartUIController heartUI;

    [System.Obsolete]
    private void Start()
    {
        currentLife = maxLife;
        
        heartUI = FindObjectOfType<HeartUIController>();
        heartUI.UpdateHearts(currentLife, maxLife);
    }

    public void TakeDamage(int dmg)
    {
        currentLife -= dmg;

        if (currentLife <= 0)
        {
            currentLife = maxLife;
        }

        heartUI.UpdateHearts(currentLife, maxLife);

        Respawn();
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
