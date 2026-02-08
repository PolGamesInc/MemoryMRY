using UnityEngine;
using UnityEngine.UI;

public class MePersonManager : MonoBehaviour
{
    [SerializeField] private Button UpgradeButton;

    private Animator AnarUpgradeAnimator;

    [SerializeField] private GameObject Anar;

    private void Start()
    {
        UpgradeButton.onClick.AddListener(UpgradePerson);
    }

    private void UpgradePerson()
    {
        AnarUpgradeAnimator = Anar.GetComponent<Animator>();
        AnarUpgradeAnimator.SetTrigger("UpgradeClick");
    }
}
