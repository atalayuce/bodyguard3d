using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public bool laneLeft,laneRight;
    public Rigidbody playerRB;
    public float zvelocity;
    public bool canimove = true;
    public int health = 3;
    public GameObject leftGuard, rightGuard;
    public BoxCollider bc;
    public int score = 0;
    public Text scoreboard;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
        score = Mathf.FloorToInt(Time.timeSinceLevelLoad * 5);
        scoreboard.text = score.ToString();
    }
    void PlayerControl()
    {
        playerRB.velocity = new Vector3(0, 0, zvelocity);   
        if (Input.GetKeyDown(KeyCode.A) & canimove==true & laneLeft == false)
        {
            canimove = false;
            animator.SetInteger("Turn",1);
            zvelocity = -4.3f;
            laneRight = false;
            StartCoroutine(ChangeLane());
        }
        if (Input.GetKey(KeyCode.D) & canimove == true & laneRight == false)
        {
            canimove = false;
            animator.SetInteger("Turn", 2);
            zvelocity = 4.3f;
            laneLeft = false;
            StartCoroutine(ChangeLane());
        }
        if (health == 2)
        {
            leftGuard.SetActive(false);
        }
        else if (health == 1)
        {
            rightGuard.SetActive(false);
            bc.size = new Vector3(3.2f, 1, 2.2f);
            bc.center = new Vector3(3.9f, 1.9f, 2.61f);

        }
        else if (health == 0)
        {
            Time.timeScale = .2f;
            Invoke("restartLevel",0.2f);
        }
    }
    public IEnumerator ChangeLane()
    {
        yield return new WaitForSeconds(.6f);
        zvelocity = 0;
        canimove = true;
        animator.SetInteger("Turn", 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Leftsidewalk")
        {
            laneLeft = true;
        }
        else if (collision.transform.tag == "Rightsidewalk")
        {
            laneRight = true;
        }
        else if (collision.transform.tag == "Enemy")
        {
            health--;
            collision.gameObject.SetActive(false);
        }
    }
    void restartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
