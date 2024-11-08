using UnityEngine;
using UnityEngine.UI;

public class SettingsSceneView : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _soundSlider;

    private void Awake()
    {
        _musicSlider.onValueChanged.AddListener(MusicVolumeChange);
        _soundSlider.onValueChanged.AddListener(SoundVolumeChange);
    }

    private void OnEnable()
    {
        _musicSlider.value = ResourceBank.Instance.MusicVolume;
        _soundSlider.value = ResourceBank.Instance.SoundVolume;
    }

    private void SoundVolumeChange(float value)
    {
        ResourceBank.Instance.SoundVolume = value;
    }

    private void MusicVolumeChange(float value)
    {
        ResourceBank.Instance.MusicVolume = value;
    }
}
