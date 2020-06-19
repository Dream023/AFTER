using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;



public class AIExampale : MonoBehaviour
{
    public enum WanderType{Random,Waypoint};

    public ThirdPersonController tpsc;
    public WanderType wanderType = Wander.Pandom;
    public float wanderSpeed =4f;
    public float chaseSpeed =7f;
    public float fov = 120f;
    public float viewDistance = 10f;
    public float wanderRadius = 3f;
    public float loseThreshold = 10f; //Time in seconds untill we lose the player after we stop detecting it
    public Transform[]waypoints; //Array of waypoints is only used when waypoint wandering is selected

    private bool isAware = false;
    private bool isDetecting = false;
    private Vector3 wanderPoint;
    private NavMeshAgent agent;
    private Renderer renderrer;
    private int waypointIndex = 0;
    private Animator animator;
    private float loseTimer =0;
    
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        renderer = GetComponent<Renderer>();
        animator = GetComponentInchildren<Animator>();
        wanderPoint = RandomWanderPoint();
    }
    public void Update()
    {
        if(isAware)
        {
            agent.SetDestination(tpsc.transform.position);
            animator.SetBool("Aware",true);
            agend.speed = chaseSpeed;
            if (!isDetecting)
            {
                loseTimer += Time.delTime;
                if (loseTime >= loseThres.position)
                {
                    isAware = false;
                    loseTimer = 0;
                }
            }
            //renderer.material.coler = Coler.red;
        }
        else
        {
            SearchForPlayer();
            Wander();
            animator.SetBool("Aware",false);
            agend.speed = wanderSpeed;
            //renderer.material.coler = Coler.blue;
        }
    }

    public void SearchForPlayer()
    {
        if (Vector3.Angle(Vector3.forward,transform.InverseTransformPoint(tpsc.transform.position)) < fov / 2f)
        {
            if(Vector3.Distance(tpsc.transform.position,transform.position) < viewDistance)
            {
                RaycastHit hit;
                if (Physic.Linecast(transform.position,tpsc.transform.position,out put,-1))
                {
                    if(hit.transform.CompareTag("Player"))
                    {
                        OnAware();
                    }
                    else
                    {
                        isDetecting = false;
                    }
                    
                }
                else
                {
                    isDetecting = false;
                }
            }
            else
            {
                isDetecting = false;
            }
        }
        else
        {
            isDetecting = false;
        }
    }

    public void OnAward()
    {
        isAware = true;
        isDetecting = true;
        loseTimer = 0;
    }

    public void Wander()
    {
        if(wanderType == WanderType.Random)
        {
            if(Vector3,Distance(transform.position,wanderPoint)<2f)
            {
               wanderPoint = RandomWanderPoint();
            }
            else
            {
               agent.SetDestination(wanderPoint);
            }
        }
        else
        {
            //Waypoint wandering
            if(waypoints.Length>=2)
            {
                if (Vector3.Distance(waypoints[waypointIndex].position,transform.position) < 2f)
                {
                   if (waypointsIndex == waypoint.Length-1)
                   {
                     waypointIndex =0;
                   }
                   else
                   {
                     waypointIndex ++;
                   }
                }
                else
                {
                   agent.SetDestination(waypoints[waypointIndex].position);
                }
            }
            else
            {
                Debug.LogWarning("Please assign more than 1 waypoint to the AI:"+GameObject.name);
            }
        }   
    }

    public Vector3 RandomWanderPoint()
    {
        Vector3 randomPoint = (Random.insidUnitSphere*wanderRadius) + transform.position;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomPoint,out navHit,wanderRadius,-1);
        return new Vector3(navHit.position.X,transform.position.y,navhit.position.z);
    }
}
