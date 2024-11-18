using UnityEngine;

namespace _Scripts
{
    public class DontDestroy : MonoBehaviour
    {
        public static DontDestroy instance;

        private void Start()
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
