using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineController : MonoBehaviour
{
    public GameAction gameActionObj;
    private CinemachineVirtualCamera virtualCamera;
    
    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    
    private void TransformHander(Transform transformObj)
    {
        virtualCamera.Follow = transformObj;
    }
}
