using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ThrowObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textScore;
    private Vector3 positionRelease;
    private int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        Event e = Event.current;
        if(e.type == EventType.KeyUp && e.keyCode== KeyCode.G)
        {
            positionRelease = GameObject.Find("Sphere").transform.position;
            if (positionRelease.z < 0)
                score = 150;
            if (positionRelease.z >= 0 && positionRelease.z <= 0.5)
                score = 100;
            if (positionRelease.z > 0.5 && positionRelease.z <= 1)
                score = 75;
            if (positionRelease.z > 1 && positionRelease.z <= 1.5)
                score = 50;
            if (positionRelease.z > 1.5 && positionRelease.z <= 2.2)
                score = 25;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cub100p")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p1")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;

        }
        if (collision.gameObject.name == "cub100p2")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p3")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p4")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p5")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p6")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "cub100p7")
        {
            string scorFinal = "Score: ";
            scorFinal = scorFinal + score + 'p';
            textScore.GetComponent<TextMeshPro>().text = scorFinal;
        }
        if (collision.gameObject.name == "Miss")
        {
            Debug.Log("Cum ai dat pe langa?");
        }
    }
}
