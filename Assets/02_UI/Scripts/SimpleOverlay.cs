namespace EX02
{
    using System.Collections;
    using System.Collections.Generic;
    using Anomaly;
    using UnityEngine;

    public class SimpleOverlay : Anomaly.Overlay
    {
        public override IEnumerator OnEnter(UIEventParam param)
        {
            Debug.Log("Enter >> SimpleOverlay");
            yield break;
        }

        public override IEnumerator OnExit()
        {
            Debug.Log("Exit << SimpleOverlay");
            yield break;
        }
    }
}