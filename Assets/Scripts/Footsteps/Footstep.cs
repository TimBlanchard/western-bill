using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering.HighDefinition;


public class Footstep : MonoBehaviour
{
    public static Footstep instance;

    public float Threshold = 10.0f;
    private bool overidden = false;

    private Material[] _mats;
    private Transform _player;

    private Coroutine AlphaAnimation;

    void Start()
    {
        Footstep.instance = this;
        GameObject player = GameObject.Find("CHARACTER");
        _player = player.transform;

        DecalProjector[] projectors = GetComponentsInChildren<DecalProjector>();
        _mats = new Material[projectors.Length] ;

        for (int i = 0; i < projectors.Length; i++)
        {
            Material mat = Instantiate<Material>(projectors[i].material);
            projectors[i].material = mat;
            _mats[i] = mat;
        }
        SetAlpha(0.0f);
        


    }
    void Update()
    {
        if(overidden) return;

        float dist = Vector3.Distance(transform.position, _player.position);
        float progress = (Threshold - dist) / Threshold;
        progress = Mathf.Max(0, progress);
        SetAlpha(progress);
    }

    private void SetAlpha(float progress)
    {
        for (int i = 0; i < _mats.Length; i++)
        {
        Color color = _mats[i].GetColor("_BaseColor");
        color.a = progress;
        _mats[i].SetColor("_BaseColor", color);

        }
    }
    public void AlphaTo(float alpha, float duration) {

        overidden = true;
        if(AlphaAnimation != null) {
            StopCoroutine(AlphaAnimation);
            AlphaAnimation = null;
        }
        AlphaAnimation = StartCoroutine(AnimateAlpha(alpha, duration));
        
    }


    public IEnumerator AnimateAlpha(float alpha, float duration) {
        float time = 0f;
        float progress = 0f;
        float[] initAlphas = new float[_mats.Length];

        for (int i = 0; i < _mats.Length; i++)
        {
            initAlphas[i] = _mats[i].GetColor("_BaseColor").a;

        }

        while (time <= duration) {
            time += Time.deltaTime;
            progress = time / duration;

            for (int j = 0; j < _mats.Length; j++)
            {
                // SetFloat(MathF.Lerp(initAlphas[j], alpha, progress));
                Color color = _mats[j].GetColor("_BaseColor");
                color.a = Mathf.Lerp(initAlphas[j], alpha, progress);
                _mats[j].SetColor("_BaseColor", color);
            }

            yield return null;
        }
        overidden = alpha == 0 ? true : false;

    }
}
