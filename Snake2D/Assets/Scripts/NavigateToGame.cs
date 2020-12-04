using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateToGame : MonoBehaviour
{
    public void NavigateToGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
