using UnityEngine;

public class WallTrapW : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject wall;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            wall.GetComponent<BoxCollider>().isTrigger = false;
        }
        else
        {
            wall.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}
