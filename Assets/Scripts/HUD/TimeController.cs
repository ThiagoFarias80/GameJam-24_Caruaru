using UnityEngine;

public class TimeController : MonoBehaviour
{
    private float _currentTime; 
    [SerializeField] private float _tentaclesStartTime;
    private GameplayUIController _gameUIController;
    [SerializeField] private float _totalTime;

    private void Awake()
    {
        _gameUIController = FindAnyObjectByType<GameplayUIController>();
    }
    private void Update()
    {
        UpdateTime();
    }
    private void UpdateTime()
    {
        _currentTime += Time.deltaTime;
        var percent = Mathf.Clamp(_currentTime/_totalTime, 0, 1);
        _gameUIController.UpdateProgressBar(percent);
        if(_currentTime > _tentaclesStartTime)
        {
            var tentaclePercent = _currentTime/ (_totalTime + _tentaclesStartTime);
            _gameUIController.UpdateTentacles(tentaclePercent);
        }
    }
}
