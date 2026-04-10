using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;

    public GameObject xpPrefeb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log("¸Â¾ÒÀ½");

        if(currentHp <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        if(xpPrefeb != null)
        {
            Instantiate(xpPrefeb, transform.position, Quaternion.identity);

        }

        Destroy(gameObject);
    }
}
