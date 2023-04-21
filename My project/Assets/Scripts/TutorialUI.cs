using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{
    public Button storyContinue;
    public Button tutorialContinue1;
    public Button tutorialContinue2;
    public GameObject storyPanel;
    public GameObject tutorialPanel1;
    public GameObject tutorialPanel2;
    public Scene mainScene;

    // Start is called before the first frame update
    void Start()
    {
        tutorialPanel1.SetActive(false);
        tutorialPanel2.SetActive(false);
        storyPanel.SetActive(true);
    }

    public void ContinueFromStory()
    {
        tutorialPanel1.SetActive(true);
        storyPanel.SetActive(false);
    }

    public void ContinueFromTutorial1()
    {
        tutorialPanel2.SetActive(true);
        tutorialPanel1.SetActive(false);
        storyPanel.SetActive(false);
    }

    public void ContinueFromTutorial2()
    {
        SceneManager.LoadScene("Main Scene");
    }


}
