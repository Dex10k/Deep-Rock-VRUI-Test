using System.Collections;
using UnityEngine;

public class CustomController : MonoBehaviour
{
    public bool leftHandIsOpen, rightHandIsOpen;
    public GameObject leftHand, rightHand;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            leftHandIsOpen = !leftHandIsOpen;
            if (leftHandIsOpen)
            {
                rightHand.SetActive(false);
                rightHandIsOpen = false;
            }
            leftHand.SetActive(leftHandIsOpen);
        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            leftHandIsOpen = !leftHandIsOpen;
            leftHand.SetActive(leftHandIsOpen);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt)|| Input.GetKeyDown(KeyCode.RightAlt)|| Input.GetKeyDown(KeyCode.AltGr))
        {
            rightHandIsOpen = !rightHandIsOpen;
            if (rightHandIsOpen)
            {
                leftHand.SetActive(false);
                leftHandIsOpen = false;
            }
            rightHand.SetActive(rightHandIsOpen);
        }

        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt) || Input.GetKeyUp(KeyCode.AltGr))
        {
            rightHandIsOpen = !rightHandIsOpen;
            rightHand.SetActive(rightHandIsOpen);
        }
    }
}
