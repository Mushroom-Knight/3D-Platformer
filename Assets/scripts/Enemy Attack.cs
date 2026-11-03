using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform playerCheck;
    [SerializeField] LayerMask Player;
    [SerializeField] float attackRadius = 3;

    bool IsGrounded()
    {
        return Physics.CheckSphere(playerCheck.position, attackRadius, Player);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
