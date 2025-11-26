using UnityEngine;

public class GhostFollowPlayer : MonoBehaviour
{

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        
        if (agent.remainingDistance <= 1.0f)
        {

            agent.destination = player.transform.position;
        }       
    }
}
