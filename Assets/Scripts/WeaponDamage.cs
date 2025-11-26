using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public float minVelocityToDamage = 1f;
    public int damage = 1;

    private Vector3 lastPosition;

    private void FixedUpdate()
    {
        lastPosition = transform.position;
    }

    private void OnCollisionEnter(Collision col)
    {
        float velocity = col.relativeVelocity.magnitude;

        if (velocity < minVelocityToDamage) return;

        if (col.gameObject.CompareTag("Enemy"))
        {
            EnemyAI e = col.gameObject.GetComponent<EnemyAI>();
            if (e != null)
                e.TakeDamage(damage);
        }
    }
}
