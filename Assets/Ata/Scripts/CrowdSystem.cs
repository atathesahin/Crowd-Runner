using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdSystem : MonoBehaviour
{
    [SerializeField] private float angle;
    [SerializeField] private float radius;

    [SerializeField] private Transform runnersParent
        ;
    //private Transform _runners;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RunnerPlace();
    }
    private void RunnerPlace()
    {
        for (int i = 0; i < runnersParent.childCount; i++)
        {
            Vector3 childPosition = GetPosition(i);
            runnersParent.GetChild(i).localPosition = childPosition;
        }
    }
    private Vector3 GetPosition(int index)
    {
        float x = radius * Mathf.Sqrt(index) * Mathf.Cos(index * Mathf.Deg2Rad * angle);
        float z = radius * Mathf.Sqrt(index) * Mathf.Sin(index * Mathf.Deg2Rad * angle);

        return new Vector3(x, 0, z);
    }

   
}
