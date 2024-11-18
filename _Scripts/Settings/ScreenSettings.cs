using UnityEngine;

namespace _Scripts.Settings
{
    public class ScreenSettings : MonoBehaviour
    {
        public void FullScreenToggle(bool toggleValue)
        {
            Screen.fullScreen = toggleValue;
        }
    }
}
