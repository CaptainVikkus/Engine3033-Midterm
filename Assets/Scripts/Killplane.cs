using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killplane : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject playerPrefab;
    private int playerLayer;

    private void Start()
    {
        playerLayer = LayerMask.NameToLayer("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == playerLayer)
        {
            Destroy(other.gameObject);
            Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

}
