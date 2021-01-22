using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Final : MonoBehaviour
{
    public Image img;
    public Image finalizar;
    public int finalEmpathy;
    public GameObject credits;

    public Sprite Good;
    public Sprite Good_B;
    public Sprite Bad;
    public Sprite Bad_B;
    public Sprite Medium;
    public Sprite Medium_B;

    public AudioSource Click;

    public void Start()
    {
        AudioSource Click = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();
        finalEmpathy = GameManager.instance.empathy;
    }
    public void Update()
    {
       finalEmpathy = GameManager.instance.empathy;
        CheckFinal();
    }
    public void CheckFinal()
    {
        if (finalEmpathy < 4)
        {
            img.GetComponent<Image>().sprite = Bad;
            finalizar.GetComponent<Image>().sprite = Bad_B;
        }
        else if (finalEmpathy >= 4 && finalEmpathy <= 8)
        {
            img.GetComponent<Image>().sprite = Medium;
            finalizar.GetComponent<Image>().sprite = Medium_B;
        }
        else if (finalEmpathy >=- 9 && finalEmpathy <= 12)
        {
            img.GetComponent<Image>().sprite = Good;
            finalizar.GetComponent<Image>().sprite = Good_B;
        }
    }
    public void Creditos()
    {
        credits.SetActive(true);
        Click.Play();
    }
    public void Reset()
    {
        GameManager.instance.ChangeScene();
        Click.Play();
        KeepSound.instance.Bye();
    }
}
