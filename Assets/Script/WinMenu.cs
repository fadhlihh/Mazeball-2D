using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void Retry()
    {
        // Mengulang permainan
        // Membuka scene maze
        SceneManager.LoadScene("Maze");
    }

    public void Exit()
    {
        // Keluar Permainan
        Application.Quit();
    }
}
