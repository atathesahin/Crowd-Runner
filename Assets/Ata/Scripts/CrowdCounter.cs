using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrowdCounter : MonoBehaviour
{
    [SerializeField] private TextMeshPro crowdText;
    [SerializeField] private Transform runnersParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crowdText.text = runnersParent.childCount.ToString();
    }
}
