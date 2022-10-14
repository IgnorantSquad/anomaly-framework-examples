namespace EX00
{
    using UnityEngine;

    public class TestCustomBehaviour : Anomaly.CustomBehaviour
    {
        private void OnUpdate()
        {
            transform.position = Vector3.zero;
        }
    }
}