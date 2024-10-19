using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeBehavior : MonoBehaviour
{
    public Image Fade;
    public float time;
    public float delay;

     void Start()
    {
        FadeOut(time, delay);
    }

    public void FadeOut(float timeTrasition,  float delay)
    {
        StartCoroutine(Coroutine_FadeOut(time, delay));
    }

    private IEnumerator Coroutine_FadeOut(float timeTrasition, float delay)
    {
        yield return new WaitForSeconds(delay);
        float ElipsedTime = 0;
        while (ElipsedTime <= 1)
        {
            ElipsedTime += Time.deltaTime;
            Fade.color = Color.Lerp(new Color(1, 1, 1,0), new Color(1, 1, 1, 1), ElipsedTime);
            yield return null;
        }

        


        yield break;
    }


}
