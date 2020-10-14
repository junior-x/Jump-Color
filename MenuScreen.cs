using System.Collections;
using System.Collections.Generic; ///            (㇏(•̀ᵥᵥ•́)ノ) 
using UnityEngine;
using UnityEngine.SceneManagement;  /* <---  Main library to deal with scenes, dont forget     <----*/

public class MenuScreen : MonoBehaviour
{
        public void PlayGame(){   ///Just to call the game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void DebugLob(){     ///make shure everything is cool
        Debug.Log("Hot Dog");
    }
}
