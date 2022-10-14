namespace EX02
{
    using System.Collections;
    using System.Collections.Generic;
    using Anomaly;
    using UnityEngine;

    public class SecondScene : Anomaly.Scene
    {
        public override IEnumerator OnEnter(UIEventParam param)
        {
            Debug.Log("Enter >> SecondScene");
            yield break;
        }

        public override IEnumerator OnExit()
        {
            Debug.Log("Exit << SecondScene");
            yield break;
        }
    }
}