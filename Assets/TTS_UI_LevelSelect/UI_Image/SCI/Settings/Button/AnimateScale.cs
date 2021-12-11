using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateScale : MonoBehaviour
{
    [SerializeField] private RectTransform rect;
    [SerializeField] private AnimationCurve scaleCurveLoop = AnimationCurve.EaseInOut(0, 1, 1, 1);
    [SerializeField] private float animTime = 1;
    [SerializeField] private bool playOnEnable = false;
    [SerializeField] private bool loopOnEnable = false;
    private Vector3 startScale;
    private float timer;
    private bool stopped = true;
    private bool loop;

    private void Awake()
    {
        startScale = rect.localScale;
    }

    private void OnEnable()
    {
        loop = loopOnEnable;
        stopped = !playOnEnable;
    }

    public void Play(bool loop)
    {
        stopped = false;
        this.loop = loop;
        timer = 0;
    }

    public void Stop()
    {
        stopped = true;
        loop = false;
        rect.localScale = startScale;
    }

    // Update is called once per frame
    private void Update()
    {
        if (stopped) return;
        timer += Time.deltaTime;
        if (timer > animTime)
        {
            if (loop)
                timer = 0;
            else
            {
                timer = animTime;
                Stop();
            } 
        }
        float perc = timer / animTime;
        var scale = scaleCurveLoop.Evaluate(perc);
        rect.localScale = new Vector3(scale, scale, scale);
    }
}
