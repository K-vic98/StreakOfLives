using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] float _numberOfDamagePoints;
    [SerializeField] float _numberOfHealingPoints;

    private Slider _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }

    public void Heal()
    {
        _healthBar.DOValue(_healthBar.value + _numberOfHealingPoints, 1);
    }

    public void Hit()
    {
        _healthBar.DOValue(_healthBar.value - _numberOfDamagePoints, 1);
    }
}