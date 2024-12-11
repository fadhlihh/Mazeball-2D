using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{
    // Atribut SerializeField untuk memunculkan variable di inspector
    [SerializeField]
    private Transform mazeTransform; // Membuat variable mazeTransform untuk menyimpan komponen Transform dari maze

    void Start()
    {

    }

    void Update()
    {
        // Jika input 'A' ditekan
        if (Input.GetKey(KeyCode.A))
        {
            // Memutar maze di sumbu z sebesar 50 derajat tiap detik ke arah kiri
            mazeTransform.Rotate(0, 0, 50 * Time.deltaTime);
        }
        // Jika input 'D' ditekan
        if (Input.GetKey(KeyCode.D))
        {
            // Memutar maze di sumbu z sebesar 50 derajat tiap detik ke arah kanan
            mazeTransform.Rotate(0, 0, -50 * Time.deltaTime);
        }
    }
}
