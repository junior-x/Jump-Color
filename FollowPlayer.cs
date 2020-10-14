///
using UnityEngine;  ///Only Main Engine for camera candies   (㇏(•̀ᵥᵥ•́)ノ) 

public class FollowPlayer : MonoBehaviour
{
    public Transform player;        ///call the infos about Player Transform
    void Update(){
        if(player.position.y > transform.position.y){   ///parameters
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z); ///What to do
        }
    }
}