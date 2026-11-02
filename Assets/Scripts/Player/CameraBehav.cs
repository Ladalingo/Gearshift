using UnityEngine;

public class CameraBehav : MonoBehaviour
{
    public Transform focusPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followPos = new Vector3(focusPlayer.position.x, focusPlayer.position.y, -10); 
        transform.position = followPos;
    }
}
