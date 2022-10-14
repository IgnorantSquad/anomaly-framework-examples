namespace EX02
{
    using System.Collections;
    using System.Collections.Generic;
    using Anomaly;
    using UnityEngine;

    public class BPopup : Anomaly.Popup
    {
        public override IEnumerator OnEnter(UIEventParam param)
        {
            Debug.Log("Enter >> BPopup");
            yield break;
        }

        public override IEnumerator OnExit()
        {
            Debug.Log("Exit << BPopup");
            yield break;
        }
    }
}