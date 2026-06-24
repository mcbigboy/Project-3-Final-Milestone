using UnityEngine;

public class ScreenChager : MonoBehaviour
{
    public static ScreenChager instance;
    private GameManager gm;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DeactiatedAllScreen()
    {
        gm.TitleScreen.SetActive(false);
        gm.MainMenuScreen.SetActive(false);
        gm.CreditsScreen.SetActive(false);
        gm.GameOverScreen.SetActive(false);
        gm.GamePlayScreen.SetActive(false);
        gm.OptionsScrren.SetActive(false);  
    }

    public void setTitleScreen()
    {
        DeactiatedAllScreen();
        gm.TitleScreen.SetActive(true);
    }

    public void setMainMenuScreen()
    {
        DeactiatedAllScreen();
        gm.MainMenuScreen.SetActive(true);
    }

    public void setCreditsScreen()
    {
        DeactiatedAllScreen();
        gm.CreditsScreen.SetActive(true);
    }

    public void setGameOverScreen()
    {
        DeactiatedAllScreen();
        gm.GameOverScreen.SetActive(true);
    }

    public void setGamePlayScreen()
    {
        DeactiatedAllScreen();
        gm.GamePlayScreen.SetActive(true);
    }

    public void setOptionsScreen()
    {
        DeactiatedAllScreen();
        gm.OptionsScrren.SetActive(true);
    }
        
}
