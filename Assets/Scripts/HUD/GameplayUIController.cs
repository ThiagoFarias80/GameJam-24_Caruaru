using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayUIController : MonoBehaviour
{
    private float _starValue;
    [SerializeField] private RectTransform _timeBar;
    [SerializeField] private RectTransform _tentacles;

    private void Awake()
    {
        _starValue = _timeBar.rect.width;
    }
    public void UpdateProgressBar(float percent)
    {
        percent = Mathf.Clamp(percent, 0.1f, 1);
        _timeBar.sizeDelta = new Vector2(_starValue * percent, _timeBar.rect.height);
    }
    public void UpdateTentacles(float percent)
    {
        if (percent >= 0 && !_tentacles.gameObject.activeInHierarchy)
        {
            _tentacles.gameObject.SetActive(true);
        }
        _tentacles.localPosition += new Vector3(percent * 1.75f, 0,0);
    }
}
