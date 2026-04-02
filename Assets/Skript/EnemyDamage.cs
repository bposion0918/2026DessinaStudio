using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float attackInterval = 1f;

    public float attackTimer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        attackTimer += Time.deltaTime;   
    }

    // Update is called once per frame
    private void OnTriggerStay (Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (attackTimer < attackInterval) return;

        PlayerHealth playrtHealth = other.GetComponent<PlayerHealth>();

        if (playrtHealth != null )
        {
            playrtHealth.TakeDamage(damage);
            attackTimer = 0f;
        }

    }
}
