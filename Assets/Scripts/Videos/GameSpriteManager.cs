using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSpriteManager : MonoBehaviour
{
    [Header("Next Behaviour")]
    public bool nextScene;
    public bool decisionTime;
    public bool changeManager;

    public GameObject myDecision;
    public GameObject decisionButtons;
    public GameObject myself;
    public GameObject myManager;

    private Queue<Sprite> spritesGame;
    public Image gameSprites;
    public GameSprites sprites;

    void Start()
    {
            spritesGame = new Queue<Sprite>();
            myself.SetActive(true);
            StartGame(sprites);
            myself.GetComponent<Button>();
    }
    public void Update()
    {
        if(nextScene == true)
        {
            ChangeScene();
        }
        if(decisionTime == true)
        {
            Decision();
        }
    }
    public void StartGame(GameSprites anim)
    {
        spritesGame.Clear();
        foreach (Sprite spriteGame in anim.sprites)
        {
            spritesGame.Enqueue(spriteGame);
        }
        DisplayNextSprite();
    }
    public void ChangeScene()
    {
        if (spritesGame.Count <= 0)
        {
            GameManager.instance.ChangeScene();
            myself.GetComponent<Button>().interactable =false;
        }
    }
    public void Decision()
    {
        if (spritesGame.Count <= 0)
        {
            myDecision.SetActive(true);
            decisionButtons.SetActive(true);
            Destroy(myself);
            decisionTime = false;
            Destroy(myManager);
            myself.GetComponent<Button>().interactable = false;
        }
    }
    public void DisplayNextSprite()
    {
        gameSprites.sprite = spritesGame.Dequeue();

    }
}
