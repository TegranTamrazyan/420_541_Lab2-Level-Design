using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject[] gameObjectsToReset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            other.transform.position = respawnPoint.position;

            Debug.Log("You have died! Player has been respawned at the respawn point.");

            for (int i = 0; i < gameObjectsToReset.Length; i++)
            {
                gameObjectsToReset[i].GetComponent<MeshRenderer>().enabled = false;
                gameObjectsToReset[i].GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }
}
