using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float minX = -14f;
    public float maxX = 14f;
    public float minZ = -14f;
    public float maxZ = 14f;

    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (playerHealth != null && playerHealth.IsDead) return;
        
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, 0f, z).normalized;

        Vector3 nextPosition = transform.position + moveDir * moveSpeed * Time.deltaTime;

        nextPosition.x = Mathf.Clamp(nextPosition.x, minX, maxX);
        nextPosition.z = Mathf.Clamp(nextPosition.z, minZ, maxZ);
        
        transform.position = nextPosition;

        if(moveDir != Vector3.zero)
        {
            transform.forward = moveDir;
        }
    }
}
