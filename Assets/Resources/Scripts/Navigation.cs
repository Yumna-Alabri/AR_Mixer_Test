using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ShowHomeScene()
        {
            SceneManager.LoadSceneAsync(0);
        }

    public void ShowPlacementOptions()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ShowPlaceOnPlane()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void ShowPlaceOnImage()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void ShowHowToUse()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void ShowRecipes()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void GoBack()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void ShowCleaning()
    {
        SceneManager.LoadSceneAsync(6);
    }

    public void ShowMaintenance()
    {
        SceneManager.LoadSceneAsync(7);
    }


}
