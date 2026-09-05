using Unity.VisualScripting;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject wall;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has triggered the trap!");

            wall.GetComponent<MeshRenderer>().enabled = true;
            wall.GetComponent<BoxCollider>().isTrigger = false;

        }
    }
}
