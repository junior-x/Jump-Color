
using UnityEngine;  ///Just one Library nwo     (㇏(•̀ᵥᵥ•́)ノ) 

public class Rotator : MonoBehaviour   ///Obstacle functions like TRANSFORM.ROTATIONS in this case
{
        public float speed = 100f;  ///Defining defalt rotation velocity
    // Update is called once per frame
    void Update()   ///Calling the function at same time the game start
    {
        transform.Rotate(0f, 0f, speed*Time.deltaTime); 
    }
}
