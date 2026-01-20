using UnityEngine;

public class SpinManager : MonoBehaviour
{
    private Animator AnimatorPopAppGoTGFirstSpin;
    [SerializeField] private GameObject PopAppGoTGFirstSpin;

    private void Start()
    {
        AnimatorPopAppGoTGFirstSpin = PopAppGoTGFirstSpin.GetComponent<Animator>();
    }

    public void GoTGFirstSpin()
    {
        AnimatorPopAppGoTGFirstSpin.SetTrigger("GoTG");
    }

    public void ClickSB()
    {
        Application.OpenURL("https://www.google.com/?hl=ru");
    }
}
