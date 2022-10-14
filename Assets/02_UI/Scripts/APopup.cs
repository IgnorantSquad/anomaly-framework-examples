namespace EX02
{
    using System.Collections;
    using System.Collections.Generic;
    using Anomaly;
    using UnityEngine;

    public class APopup : Anomaly.Popup
    {
        public override IEnumerator OnEnter(UIEventParam param)
        {
            Debug.Log("Enter >> APopup");
            yield break;
        }

        public override IEnumerator OnExit()
        {
            Debug.Log("Exit << APopup");
            yield break;
        }
    }
}