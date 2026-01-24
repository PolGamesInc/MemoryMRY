using UnityEngine;
using UnityEngine.UI;

public class SpinManager : MonoBehaviour
{
    private Animator AnimatorPopAppGoTGFirstSpin;
    [SerializeField] private GameObject PopAppGoTGFirstSpin;
    [SerializeField] private Button ButtonSpin;

    private void Start()
    {
        AnimatorPopAppGoTGFirstSpin = PopAppGoTGFirstSpin.GetComponent<Animator>();
        ButtonSpin.onClick.AddListener(GoTGFirstSpin); //Добавляем событие на кнопку крутить, чтобы появился поп-апп
    }

    public void GoTGFirstSpin()
    {
        AnimatorPopAppGoTGFirstSpin.SetTrigger("GoTG");
    }

    public void ClickSB()
    {
        Application.OpenURL("https://www.google.com/?hl=ru");
        PopAppGoTGFirstSpin.SetActive(false);
        ButtonSpin.onClick.RemoveListener(GoTGFirstSpin); //Убираем событие с появлением пап-аппа, чтобы была возможность использовать другие меоды
    }
}
