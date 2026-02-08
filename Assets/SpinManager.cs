using System.Collections;
using System.Security.Cryptography;
using UnityEngine;
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

    [Header("Animations")]
    private Animator BlurAnimator;
    private Animator AnarAnimator;

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
                StartCoroutine(WaitSpeenWheel());
                    break;
        }
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

    private void OpenMyPerson()
    {
        print("OpenMyPerson");
    }

    private IEnumerator WaitSpeenWheel()
    {
        yield return new WaitForSeconds(3.2f);
        AnarAnimator = Anar.GetComponent<Animator>();
        AnarAnimator.SetTrigger("Visible");
        BlurAnimator = BlurObject.GetComponent<Animator>();
        BlurObject.SetActive(true);
        BlurAnimator.SetTrigger("VisibleBlur");
        ButtonMyPerson.onClick.AddListener(OpenMyPerson);
    }
}
