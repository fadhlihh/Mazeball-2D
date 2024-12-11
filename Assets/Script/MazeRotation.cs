using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Jika input 'A' ditekan
        if (Input.GetKey(KeyCode.A))
        {
            // Maka munculkan log "putar maze ke kiri"
            Debug.Log("Putar maze ke kiri");
        }
        // Jika input 'D' ditekan
        if (Input.GetKey(KeyCode.D))
        {
            // Maka munculkan log "putar maze ke kanan"
            Debug.Log("Putar maze ke kanan");
        }
    }
}
