using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    // UI screen

    public GameObject TitleScreen;
    public GameObject MainMenuScreen;
    public GameObject CreditsScreen;
    public GameObject GameOverScreen;
    public GameObject GamePlayScreen;
    public GameObject OptionsScrren;

   
    

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScreenChager.instance.setTitleScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
