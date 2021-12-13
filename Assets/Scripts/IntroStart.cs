using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class IntroStart : MonoBehaviour
{
    public bool firstScenePassed = false;

    public Image image1;
    // Start is called before the first frame update
    void Start()
    {
        // image1 = GetComponentInChildren<Image>();
        
        var tempColor = image1.color;
        tempColor.a = 0f;
        image1.color = tempColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            if(firstScenePassed) {
                PlayGame();
            } else {
                firstScenePassed = true;
                image1.DOFade(1f, 1f);
            }
        }
    }
    public void PlayGame() {
        MainController.Instance.ChangeScene(1);
    }
}
