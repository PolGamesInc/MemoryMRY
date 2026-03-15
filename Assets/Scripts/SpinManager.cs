using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpinManager : MonoBehaviour
{
    [Header("FirstClickToGetFreeFiveSpins")]
    private Animator AnimatorPopAppGoTGFirstSpin;
    [SerializeField] private GameObject PopAppGoTGFirstSpin;
    [SerializeField] private Button ButtonSpin;

    [Header("FreeFiveSpins")]
    [SerializeField] private int SpinIndex = 0;

    [Header("Other")]
    [SerializeField] private GameObject BlurObject;
    [SerializeField] private GameObject Anar;
    [SerializeField] private GameObject Ravshan;

    [Header("Animations")]
    private Animator BlurAnimator;
    private Animator AnimatorPersonVesible;

    [SerializeField] private Transform WheelPosition;
    private float CurrentAngle = 0f;
    private float CurrentAngularVelocity = 0f;
    [SerializeField] private Button ButtonMyPerson;

    #region StandartUnityVoids
    private void Start()
    {
        AnimatorPopAppGoTGFirstSpin = PopAppGoTGFirstSpin.GetComponent<Animator>();
        ButtonSpin.onClick.AddListener(GoTGFirstSpin); //Добавляем событие на кнопку крутить, чтобы появился поп-апп

        BlurObject.SetActive(false);

        SpinIndex = 0;
    }

    private void Update()
    {
        #region SwitchCasePositionWheel
        switch (SpinIndex)
        {
            case 1:
                if (Mathf.Abs(740 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 740, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 740f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                StartCoroutine(WaitAnarSpeenWheel());
                    break;
            case 2:
                if (Mathf.Abs(785 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 785, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 785f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                StartCoroutine(WaitRavhanSpeenWheel());
                break;
            case 3:
                if (Mathf.Abs(830 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 830, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 830f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
            case 4:
                if (Mathf.Abs(865 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 865, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 865f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
            case 5:
                if (Mathf.Abs(910 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 910, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 910f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
            case 6:
                if (Mathf.Abs(955 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 955, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 955f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
            case 7:
                if (Mathf.Abs(1000 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 1000, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 1000f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
            case 8:
                if (Mathf.Abs(1045 - CurrentAngle) > 0.1f)
                {
                    CurrentAngle = Mathf.SmoothDamp(CurrentAngle, 1045, ref CurrentAngularVelocity, smoothTime: 0.5f, maxSpeed: 360f);
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                else
                {
                    CurrentAngle = 1045f;
                    WheelPosition.localRotation = Quaternion.Euler(0, 0, CurrentAngle);
                }
                //StartCoroutine(WaitAnarSpeenWheel());
                break;
        }
        #endregion
    }
    #endregion

    #region FirstClickToGetFreeFiveSpins
    public void GoTGFirstSpin()
    {
        AnimatorPopAppGoTGFirstSpin.SetTrigger("GoTG");

        BlurObject.SetActive(true);
        BlurAnimator = BlurObject.GetComponent<Animator>();
        BlurAnimator.SetTrigger("VisibleBlur");
    }

    public void ClickSB()
    {
        Application.OpenURL("https://www.google.com/?hl=ru");
        PopAppGoTGFirstSpin.SetActive(false);
        ButtonSpin.onClick.RemoveListener(GoTGFirstSpin); //Убираем событие с появлением пап-аппа, чтобы была возможность использовать другие меоды
        ButtonSpin.onClick.AddListener(ClickFreeSpin);
        BlurObject.SetActive(false);
    }
    #endregion

    #region FreeFiveSpins
    public void ClickFreeSpin()
    {
        SpinIndex = Random.Range(1, 9);
    }
    #endregion

    public void OpenMyPerson()
    {
        SceneManager.LoadScene(1);
    }

    private IEnumerator WaitAnarSpeenWheel()
    {
        yield return new WaitForSeconds(3.2f);
        AnimatorPersonVesible = Anar.GetComponent<Animator>();
        AnimatorPersonVesible.SetTrigger("Visible");
        BlurAnimator = BlurObject.GetComponent<Animator>();
        BlurObject.SetActive(true);
        BlurAnimator.SetTrigger("VisibleBlur");
    }

    private IEnumerator WaitRavhanSpeenWheel()
    {
        yield return new WaitForSeconds(3.2f);
        AnimatorPersonVesible = Ravshan.GetComponent<Animator>();
        AnimatorPersonVesible.SetTrigger("Visible");
        BlurAnimator = BlurObject.GetComponent<Animator>();
        BlurObject.SetActive(true);
        BlurAnimator.SetTrigger("VisibleBlur");
    }
}
