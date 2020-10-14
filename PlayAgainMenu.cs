using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  /*  <--  Never forget the SceneManagement  Library       (㇏(•̀ᵥᵥ•́)ノ)       */

public class PlayAgainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void PlayAgain(){    /// Call the game scene in the position 2nd  at the build settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);///From Scene list 0-1-2  = Call the scene 1
    }

    public void BackToMenu(){  ///Call the menu scene in the 1st position at the build settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2); ///From Scene list 0-1-2 = Call the scene 0
    }

}
