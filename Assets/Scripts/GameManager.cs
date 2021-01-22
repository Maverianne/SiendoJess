using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Animator transition;
    public static GameManager instance;
    public int empathy;
    public int sceneNumber;
    public AudioSource Click;


    void Awake()
    {
        instance = this;
        //Load Info
        LoadPlayer();
        //Debug.Log("Manager " + empathy);
    }
    private void Start()
    {
        AudioSource Click = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();
    }
    public void ChangeScene()
    {
        StartCoroutine(LoadLevel(sceneNumber));
        SavePlayer();
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0.7F);
        SceneManager.LoadScene(levelIndex);
    }
    public void Beginning()
    {
        Click.Play();
        SaveSystem.Reset(this);
        ChangeScene();
        Debug.Log("Reset");
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.loadPlayer();
        empathy = data.empathy;
    }
    //ResetInfo;
    public void Reset()
    {
        Click.Play();
        SaveSystem.Reset(this);
        //Debug.Log("Reset");
       // Debug.Log(empathy);
        ChangeScene();
    }
}
