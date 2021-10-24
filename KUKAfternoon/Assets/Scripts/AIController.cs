using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    //ใช้งาน AI ผ่าน NavMeshAgent ของ Unity
    NavMeshAgent agent;
    // เป้าหมายที่ AI จะเดินผ่าน NavMesh ไปจนถึง
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // !!! Warning !!! การ SetDestination ใน Update ไม่ควรทำเพราะใช้ CPU มาก
            agent.SetDestination(target.transform.position);
        }
        
    }

}
