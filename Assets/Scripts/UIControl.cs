using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public void turnLeft()
    {
        if (player.canimove == true & player.laneLeft == false)
        {
            player.canimove = false;
            player.animator.SetInteger("Turn", 1);
            player.zvelocity = -4.3f;
            player.laneRight = false;
            StartCoroutine(player.ChangeLane());
        }
    }
    public void turnRight()
    {
        if (player.canimove == true & player.laneRight == false)
        {
            player.canimove = false;
            player.animator.SetInteger("Turn", 2);
            player.zvelocity = 4.3f;
            player.laneLeft = false;
            StartCoroutine(player.ChangeLane());
        }
    }
}
