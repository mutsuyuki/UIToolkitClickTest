using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClickTest : MonoBehaviour
{
    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var button = root.Q<Button>();
        button.clicked += () => Debug.Log("Button clicked");

        var label = root.Q<Label>();
        label.RegisterCallback<PointerDownEvent>(e =>
            {
                Debug.Log("---------");
                Debug.Log("Label clicked");
                Debug.Log(e.bubbles);
                Debug.Log(e.tricklesDown);
                Debug.Log(e.propagationPhase);
            }
        );

        label.RegisterCallback<MouseOutEvent>(e =>
            {
                Debug.Log("---------");
                Debug.Log("Mouse out from Label");
            }
        );
    }
}