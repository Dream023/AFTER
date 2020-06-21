using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Rigidbody Enemy;
    [SerializeField] Animator animator;
    public float Lookrange;
    Transform Target;
    NavMeshAgent agent;
    public int Speed;
    public float Gravity = -9.81f, grounddistance = 0.1f;
    public Transform Enemygroundcheck;
    public LayerMask Ground;
    bool isGroundCheck;
    Vector3 velocity;
    void Start()
    {
        Target = PlayerIsTarget.inatance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        isGroundCheck = Physics.CheckSphere(Enemygroundcheck.position, grounddistance, Ground);
        if (isGroundCheck && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float Distance = Vector3.Distance(Target.position, transform.position);
        if (Distance <= Lookrange)
        {
            Enemy.velocity=transform.forward*Speed*Time.deltaTime;
            animator.SetBool("IsMove", true);
            if (Distance <= agent.stoppingDistance)
            {
                LookAtTarget();
            }
        }
        else
        {
            animator.SetBool("IsMove", false);
        }
    }
    void LookAtTarget()
    {
        Vector3 direction = (Target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5f);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Lookrange);
    }
}
