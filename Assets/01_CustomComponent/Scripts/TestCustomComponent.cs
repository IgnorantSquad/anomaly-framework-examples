namespace EX01
{
    using UnityEngine;
    using Anomaly;

    [System.Serializable]
    public class TestCustomComponent : CustomComponent, IUpdater
    {
        [SerializeField] private Transform body;

        public void Update()
        {
            body.position = Vector3.up * Mathf.Sin(Time.time);
        }
    }
}