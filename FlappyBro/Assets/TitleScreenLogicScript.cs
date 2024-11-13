using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TitleScreenLogicScript : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }

}

