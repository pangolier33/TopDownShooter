using UnityEngine;

namespace _Scripts.Settings
{
    public class ChangeCursor : MonoBehaviour
    {
        [SerializeField] private Texture2D _cursor;

        private void Start()
        {
            Cursor.SetCursor(_cursor, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
}
