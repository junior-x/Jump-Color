using UnityEngine;
using UnityEngine.SceneManagement; ///Just some fews library        (㇏(•̀ᵥᵥ•́)ノ) 

public class Player : MonoBehaviour
{
    ///Declare Variables
    public float jumpForce = 10f;   ///Seting the defalt force jump
    public string currentColor;     ///Tags
    public Rigidbody2D rb;          ///Colision component
    public SpriteRenderer sr;       ///Sprite component management
    public Color colorCyan;         ///color tag cyan
    public Color colorPink;         ///color tag pink
    public Color colorYellow;       ///color tag yellow
    public Color colorMagenta;      ///color tag magenta

    void Start(){
        SetRandomColor();           ///Starting already with colors
    }
    // Update is called once per frame
    void Update()   ///Just for call the Jump Function Math
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up*jumpForce;
        }
    }
    void OnTriggerEnter2D(Collider2D col){      ///touching the GameObject and call other randomic color
       
       if (col.tag == "ColorChanger"){
           SetRandomColor();
           Destroy(col.gameObject);
           return;   ///make the process avaible again
       }
        ///Debug.Log(col.tag);
        if(col.tag != currentColor){            // /*If touching another GameObject && Tag*/
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);  ///Calling the game over function
        }
    }
    void SetRandomColor(){                 ///Change color for every call
        int index = Random.Range(0, 4);
        switch(index){
            case 0:
                currentColor = "Magenta"; ///MAGENTA
                sr.color = colorMagenta;
                break;
            case 1:
                currentColor = "Pink";   ///PINK
                sr.color = colorPink;
                break;
            case 2:
                currentColor = "Yellow"; ///YELLOW
                sr.color = colorYellow;
                break;
            case 3:
                currentColor = "Cyan";   ///CYAN
                sr.color = colorCyan;
                break;
        }
    }

}
