namespace EX02
{
    using System.Collections;
    using System.Collections.Generic;
    using Anomaly;
    using UnityEngine;

    public class MainScene : Anomaly.Scene
    {
        public class Param : UIEventParam
        {
            public string msg;
        }

        public override IEnumerator OnEnter(UIEventParam param)
        {
            Debug.Log("Enter >> MainScene");

            Debug.Log($"MainScene message: {(param as MainScene.Param).msg}");

            yield break;
        }

        public override IEnumerator OnExit()
        {
            Debug.Log("Exit << MainScene");
            yield break;
        }
    }
}