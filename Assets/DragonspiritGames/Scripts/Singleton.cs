using UnityEngine;

namespace DragonspiritGames_ParallelParadox
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = (T)FindObjectOfType(typeof(T));
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        _instance = obj.AddComponent<T>();
                        obj.name = typeof(T).ToString();
                    }
                }
                return _instance;
            }
        }
    }
}

