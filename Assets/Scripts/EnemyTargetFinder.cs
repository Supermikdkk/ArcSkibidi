using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargetFinder : MonoBehaviour
{
    [SerializeField] private Pathfinding.AIDestinationSetter aIDestinationSetter;
    private GameObject target;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        aIDestinationSetter.target = target.transform;
    }
}
