using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject first, second, third, fourth;
    public GameObject next, end, prev;
    public int instNum;
    public GameObject me;
    public AudioSource Click;

    void Start()
    {
        me.SetActive(false);
        instNum = 1;
        AudioSource Click = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();
    }
    public void Update()
    {
        if(instNum == 1)
        {
            next.SetActive(true);
            prev.SetActive(false);
            end.SetActive(false);

            first.SetActive(true);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(false);
        }
        if (instNum == 2)
        {
            next.SetActive(true);
            prev.SetActive(true);
            end.SetActive(false);

            first.SetActive(false);
            second.SetActive(true);
            third.SetActive(false);
            fourth.SetActive(false);
        }
        if (instNum == 3)
        {
            next.SetActive(true);
            prev.SetActive(true);
            end.SetActive(false);

            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(true);
            fourth.SetActive(false);
        }
        if (instNum == 4)
        {
            next.SetActive(false);
            prev.SetActive(true);
            end.SetActive(true);

            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(false);
            fourth.SetActive(true);
        }
    }
    public void StartInstructions()
    {
        Click.Play();
        me.SetActive(true);
        instNum = 1;

    }
    public void NextNum()
    {
        Click.Play();
        if (instNum == 5)
        {
            End();
        }
        instNum ++;
    }
    public void End()
    {
        Click.Play();
        me.SetActive(false);
        instNum = 1;
    }
    public void PrevNum()
    {
        Click.Play();
        if (instNum <= 0)
        {
            instNum = 1;
        }
        instNum--;
    }
}
