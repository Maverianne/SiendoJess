using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decisions : MonoBehaviour
{
    public Image img;
    public GameObject myButtons;
    public Button button;
    public GameObject me;
    public GameObject Second_Decision;
    public GameObject nextManager;
    public AudioSource Click;

    [Header("Types of Decisions")]
    public bool twoSprite;
    public bool twoSpriteB;
    public bool twoSpriteC;
    public bool goNext;
    public bool secondDecision;
    public bool nextScene;
    public bool gives_Points;

    [Header("Option A")]
    public bool optionA_S;
    public int A;
    public int A_Point;
    public Sprite nextSpriteA;
    public Sprite nextSprite1A;


    [Header("Option B")]
    public bool optionB_S;
    public int B;
    public int B_Point;
    public Sprite nextSpriteB;
    public Sprite nextSprite1B;


    [Header("Option C")]
    public bool optionC_S;
    public int C;
    public int C_Point;
    public Sprite nextSpriteC;
    public Sprite nextSprite1C;


    public void Start()
    {
        AudioSource Click = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();
        button.interactable = false;
    }

    public void OptionA()
    {
        optionA_S = true;
        myButtons.SetActive(false);
        img.GetComponent<Image>().sprite = nextSpriteA;
        button.interactable = true;
        Click.Play();

        if (gives_Points)
        {
            GameManager.instance.empathy = GameManager.instance.empathy + A_Point;
        }
    }
    public void OptionB()
    {
        optionB_S = true;
        Click.Play();
        myButtons.SetActive(false);
        img.GetComponent<Image>().sprite = nextSpriteB;
        button.interactable = true;
        if (gives_Points)
        {
            GameManager.instance.empathy = GameManager.instance.empathy + B_Point;
        }
    }
    public void OptionC()
    {
        optionC_S = true;
        Click.Play();
        myButtons.SetActive(false);
        img.GetComponent<Image>().sprite = nextSpriteC;
        button.interactable = true;
        if (gives_Points)
        {
            GameManager.instance.empathy = GameManager.instance.empathy + C_Point;
        }
    }
    public void Next_Sprite()
    {
        if (goNext)
        {
            Next_Decision();
        }
        if (optionA_S == true && twoSprite == true && secondDecision == false)
        {
            img.GetComponent<Image>().sprite = nextSprite1A;
            twoSprite = false;
        }
        else if (secondDecision == true && optionA_S == true && twoSprite == true)
        {
            img.GetComponent<Image>().sprite = nextSprite1A;
            goNext = true;
        }
        else if (optionA_S == true && twoSprite == false && secondDecision == false && nextScene == false)
        {
            nextManager.SetActive(true);
            Destroy(me);
        }
        else if (optionA_S == true && twoSprite == false && secondDecision == false && nextScene == true)
        {
            Next_Scene();
            Destroy(me);
        }
        else if (optionA_S == true && twoSprite == false && secondDecision == true)
        {
            Next_Decision();
        }
        if (optionB_S == true && twoSpriteB == true && secondDecision == false)
        {
            img.GetComponent<Image>().sprite = nextSprite1B;
            twoSpriteB = false;
        }
        else if (secondDecision == true && optionB_S == true && twoSpriteB == true)
        {
            img.GetComponent<Image>().sprite = nextSprite1B;
            goNext = true;
        }
        else if (optionB_S == true && twoSpriteB == false && secondDecision == false && nextScene == false)
        {
            nextManager.SetActive(true);
            Destroy(me);
        }
        else if (optionB_S == true && twoSpriteB == false && secondDecision == false && nextScene == true)
        {
            Next_Scene();
            Destroy(me);
        }
        else if (optionB_S == true && twoSpriteB == false && secondDecision == true)
        {
            Next_Decision();
        }
        if (optionC_S == true && twoSpriteC == true && secondDecision == false)
        {
            img.GetComponent<Image>().sprite = nextSprite1C;
            twoSpriteC = false;
        }
        else if (secondDecision == true && optionC_S == true && twoSpriteC == true)
        {
            img.GetComponent<Image>().sprite = nextSprite1C;
            goNext = true;
        }
        else if (optionC_S == true && twoSpriteC == false && secondDecision == false && nextScene == false)
        {
            nextManager.SetActive(true);
            Destroy(me);
        }
        else if (optionC_S == true && twoSpriteC == false && secondDecision == false && nextScene == true)
        {
            Next_Scene();
        }
        else if (optionC_S == true && twoSpriteC == false && secondDecision == true)
        {
            Next_Decision();
        }
    }
    public void Next_Decision()
    {
        Second_Decision.SetActive(true);
        Destroy(me);
    }
    public void Next_Scene()
    {
        if(optionA_S == true && nextScene)
        {
            GameManager.instance.sceneNumber = A;
        }
        if (optionB_S == true && nextScene)
        {
            GameManager.instance.sceneNumber = B;
        }
        if (optionC_S == true && nextScene)
        {
            GameManager.instance.sceneNumber = C;
        }
        GameManager.instance.ChangeScene();

    }
}
