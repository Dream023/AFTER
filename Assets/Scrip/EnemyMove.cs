using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Rigidbody Enemy;
    public float Lookrange;
    Transform Target;
    NavMeshAgent agent;
    public int Speed;
    void Start()
    {
        Target = PlayerIsTarget.inatance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        float Distance = Vector3.Distance(Target.position, transform.position);
        if (Distance <= Lookrange)
        {
            Enemy.velocity=transform.forward*Speed*Time.deltaTime;
            if (Distance <= agent.stoppingDistance)
            {
                LookAtTarget();
            }
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
