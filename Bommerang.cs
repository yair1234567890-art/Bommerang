using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bommerang : MonoBehaviour
{

    public NavMeshAgent agent;
    public Vector3 offset;
    Vector3 pos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            pos = transform.position;
            agent.SetDestination(transform.position + offset);
            StartCoroutine(W());
        }
    }

    IEnumerator W()
    {
        agent.SetDestination(transform.position + offset);
        yield return new WaitForSeconds(1f);
        agent.SetDestination(pos);
    }
}
