
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    #region Variables
    private NavMeshAgent agent;
    public Transform target;
    #endregion

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
