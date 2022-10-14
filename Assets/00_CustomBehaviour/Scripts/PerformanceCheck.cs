namespace EX00
{
    using UnityEngine;

    public class PerformanceCheck : Anomaly.CustomBehaviour
    {
        [SerializeField] private int objectCount = 10000;
        [SerializeField] private bool useMono = false;

        private void Start()
        {
            for (int i = 0; i < objectCount; ++i)
            {
                if (useMono) new GameObject().AddComponent<TestMonoBehaviour>();
                else new GameObject().AddComponent<TestCustomBehaviour>();
            }
        }
    }
}