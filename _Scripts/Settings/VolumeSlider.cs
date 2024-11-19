using UnityEngine;
using UnityEngine.Audio;

namespace _Scripts.Settings
{
    public class VolumeSlider : MonoBehaviour
    {
        [SerializeField] private AudioMixer audioMixer;
        [SerializeField] private string volumeparameter = "masterVolume";
    
        public void AudioVolume(float sliderValue)
        {
            audioMixer.SetFloat(volumeparameter, sliderValue);
        }
    }
}
