using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance { get; private set; }

    [Header("Camera Switch")]
    [SerializeField] private CinemachineVirtualCamera[] switchableCameras;
    [SerializeField] private int currentCameraIndex = 0;

    [Header("Camera Shake")]
    [SerializeField] private bool isCameraShakeEnabled = true;
    private CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin;

    private CinemachineVirtualCamera ActiveCamera => switchableCameras[currentCameraIndex];

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //SetDefaultCamera();
        ActivateCurrentCamera();
    }

    private void ActivateCurrentCamera()
    {
        switchableCameras[currentCameraIndex].MoveToTopOfPrioritySubqueue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
            SwitchCamera();
    }

    private void SetDefaultCamera()
    {
        for (int i = 0; i < switchableCameras.Length; i++)
        {
            if (i == currentCameraIndex)
                switchableCameras[i].gameObject.SetActive(true);
            else
                switchableCameras[i].gameObject.SetActive(false);
        }
    }

    private void SwitchCamera()
    {
        if (switchableCameras.Length == 0) return;

        //switchableCameras[currentCameraIndex].gameObject.SetActive(false);
        //switchableCameras[currentCameraIndex].Priority = 0;

        if (++currentCameraIndex > switchableCameras.Length - 1)
            currentCameraIndex = 0;

        //switchableCameras[currentCameraIndex].gameObject.SetActive(true);
        ActivateCurrentCamera();
    }

    public void ShakeCamera(float amplitude, float frequency, float durationInSeconds)
    {
        cinemachineBasicMultiChannelPerlin = ActiveCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        if (isCameraShakeEnabled && cinemachineBasicMultiChannelPerlin != null)
            StartCoroutine(ShakeCameraCoroutine(amplitude, frequency, durationInSeconds));
    }

    private IEnumerator ShakeCameraCoroutine(float amplitude, float frequency, float durationInSeconds)
    {
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = amplitude;
        cinemachineBasicMultiChannelPerlin.m_FrequencyGain = frequency;
        yield return new WaitForSeconds(durationInSeconds);
        ResetCameraNoiseValues();
    }

    public void ShakeCameraSmoothly(float amplitude, float frequency, float durationInSeconds)
    {
        cinemachineBasicMultiChannelPerlin = ActiveCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        if (isCameraShakeEnabled && cinemachineBasicMultiChannelPerlin != null)
            StartCoroutine(ShakeCameraSmoothlyCoroutine(amplitude, frequency, durationInSeconds));
    }

    private IEnumerator ShakeCameraSmoothlyCoroutine(float amplitude, float frequency, float durationInSeconds)
    {
        float elapsedTime = 0f;

        cinemachineBasicMultiChannelPerlin.m_FrequencyGain = frequency;

        while (elapsedTime < durationInSeconds)
        {
            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(amplitude, 0f, elapsedTime/durationInSeconds);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        ResetCameraNoiseValues();
    }

    private void ResetCameraNoiseValues()
    {
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
        cinemachineBasicMultiChannelPerlin.m_FrequencyGain = 0f;
    }
}
