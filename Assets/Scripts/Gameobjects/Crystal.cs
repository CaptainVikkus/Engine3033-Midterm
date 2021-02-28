using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public int score = 5;
    [SerializeField] private GameObject crystal;
    [SerializeField] private Collider collector;
    public void EnableCollect()
    {
        collector.enabled = true;
        crystal.SetActive(true);
    }

    public void DisableCollect()
    {
        collector.enabled = false;
        crystal.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            GameManager.score += score;
            DisableCollect();
        }

    }
}

