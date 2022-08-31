using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public void GoToGameScene()
{
        // Changes scenes from MainMenu to Game
        SceneManager.LoadScene("Game");

 }
}
