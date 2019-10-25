using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void OnClick()
    {
        Debug.Log("Running");
    }
}