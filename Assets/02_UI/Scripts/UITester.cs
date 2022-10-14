namespace EX02
{
    using UnityEngine;
    using Anomaly;
    using Anomaly.Utils;

    public class UITester : CustomBehaviour
    {
        private void OnUpdate()
        {
            if (AInput.IsPressed(AKeyCode.Digit1))
            {
                SceneController.Change("MainScene", new MainScene.Param() { msg = "Hello, World!" });
            }
            else if (AInput.IsPressed(AKeyCode.Digit2))
            {
                SceneController.Change("SecondScene");
            }

            if (AInput.IsPressed(AKeyCode.Digit3))
            {
                PopupController.Show("APopup");
            }
            else if (AInput.IsPressed(AKeyCode.Digit4))
            {
                PopupController.Show("BPopup");
            }

            if (AInput.IsPressed(AKeyCode.Digit5))
            {
                PopupController.Hide();
            }
        }
    }
}