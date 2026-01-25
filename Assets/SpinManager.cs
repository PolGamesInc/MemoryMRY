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

    [Header("Animations")]
    private Animator BlurAnimator;

    #region StandartUnityVoids
    private void Start()
    {
        AnimatorPopAppGoTGFirstSpin = PopAppGoTGFirstSpin.GetComponent<Animator>();
        ButtonSpin.onClick.AddListener(GoTGFirstSpin); //Добавляем событие на кнопку крутить, чтобы появился поп-апп

        BlurObject.SetActive(false);
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
        SpinIndex = Random.Range(1, 8);
    }
    #endregion
}
