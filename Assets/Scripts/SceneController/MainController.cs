
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : Singleton<MainController>
{    // Start is called before the first frame update

private string currentScene;

public int toChange = 2;
    void Start()
    {
        // SceneController.Instance.OpenScene("Scene1");
        SceneController.Instance.OpenScene("Intro");
        SceneController.Instance.OpenScene("Transition");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space)){
            currentScene = "Scene1";
            Debug.Log("aaaaah");
            TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
            TransitionController.Instance.StartTransition(0);
            StartCoroutine(Waiter("Scene1"));
        }
        */
        /*
        if(Input.GetKeyDown(KeyCode.M)){
            currentScene = "Scene4";
            TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
            TransitionController.Instance.StartTransition(1);
            Debug.Log("hmmm");
            StartCoroutine(Waiter("Scene4"));
        }
        */
    }

    public void ChangeScene(int toScene) {
            if(toScene == 1){
                currentScene = "Scene1";
                Debug.Log("aaaaah1");
                TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
                TransitionController.Instance.StartTransition(0);
                StartCoroutine(Waiter("Scene1", 4));
            } else if(toScene == 2){
                currentScene = "Scene2";
                Debug.Log("aaaaah1");
                TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
                TransitionController.Instance.StartTransition(1);
                StartCoroutine(Waiter("Scene2", 5));
            } else if(toScene == 3){
                currentScene = "Scene3";
                Debug.Log("aaaaah2");
                TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
                TransitionController.Instance.StartTransition(2);
                StartCoroutine(Waiter("Scene3", 5));
            } else if(toScene == 4){
                currentScene = "Scene4";
                TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
                TransitionController.Instance.StartTransition(3);
                Debug.Log("hmmm3");
                StartCoroutine(Waiter("Scene4", 5));
            } else if(toScene == 5){
                currentScene = "Outro";
                TransitionController.Instance.OnTransitionEnds += onTransitionEnds;
                TransitionController.Instance.StartTransition(4);
                Debug.Log("hmmm4");
                StartCoroutine(Waiter("Outro", 5));
            }
    }

    public void onTransitionEnds () {
        TransitionController.Instance.OnTransitionEnds -= onTransitionEnds;
        /*
        if(currentScene.CompareTo("Scene2") == 0) {
            SceneController.Instance.CloseScene("Scene1");
        }
        if(currentScene.CompareTo("Scene3") == 0) {
            SceneController.Instance.CloseScene("Scene2");
        }
        */
        /*
        if(currentScene.CompareTo("Scene2") == 0) {
            SceneController.Instance.CloseScene("Scene4");
        }
        */

        if(currentScene.CompareTo("Scene1") == 0) {
            SceneController.Instance.CloseScene("Intro");
        }
        if(currentScene.CompareTo("Scene2") == 0) {
            SceneController.Instance.CloseScene("Scene1");
        }
        if(currentScene.CompareTo("Scene3") == 0) {
            SceneController.Instance.CloseScene("Scene2");
        }
        if(currentScene.CompareTo("Scene4") == 0) {
            SceneController.Instance.CloseScene("Scene3");
        }
        if(currentScene.CompareTo("Outro") == 0) {
            SceneController.Instance.CloseScene("Scene4");
        }
        /*
        if(currentScene.CompareTo("Scene3") == 0) {
            SceneController.Instance.CloseScene("Scene4");
        }
        */
        // Else if other scenes
    }

    public IEnumerator Waiter(string scene, int wait)
    {
        yield return new WaitForSeconds(wait);

            SceneController.Instance.OpenScene(scene);
    }


}


