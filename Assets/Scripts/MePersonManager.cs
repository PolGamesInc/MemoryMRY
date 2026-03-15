using UnityEngine;
using UnityEngine.UI;

public class MePersonManager : MonoBehaviour
{
    [SerializeField] private Button UpgradeButton;

    private Animator AnarUpgradeAnimator;

    [SerializeField] private GameObject Anar;

    private AudioSource UpgradeRareAndEpicSound;
    [SerializeField] private AudioClip legendarySound;

    private void Start()
    {
        UpgradeButton.onClick.AddListener(UpgradePerson);
    }

    private void UpgradePerson()
    {
        AnarUpgradeAnimator = Anar.GetComponent<Animator>();
        AnarUpgradeAnimator.SetTrigger("UpgradeClick");
        UpgradeRareAndEpicSound = Anar.GetComponent<AudioSource>();
        UpgradeRareAndEpicSound.Play();
        UpgradeButton.onClick.AddListener(UpgradePersonEpic);
        UpgradeButton.onClick.RemoveListener(UpgradePerson);
    }

    private void UpgradePersonEpic()
    {
        AnarUpgradeAnimator = Anar.GetComponent<Animator>();
        AnarUpgradeAnimator.SetTrigger("EpicUpgrade");
        UpgradeRareAndEpicSound = Anar.GetComponent<AudioSource>();
        UpgradeRareAndEpicSound.Play();
        UpgradeButton.onClick.AddListener(UpgradePersonLegendar);
        UpgradeButton.onClick.RemoveListener(UpgradePersonEpic);
    }

    private void UpgradePersonLegendar()
    {
        AnarUpgradeAnimator = Anar.GetComponent<Animator>();
        AnarUpgradeAnimator.SetTrigger("LegendarUpgrade");
        UpgradeRareAndEpicSound = Anar.GetComponent<AudioSource>();
        UpgradeRareAndEpicSound.clip = legendarySound;
        UpgradeRareAndEpicSound.Play();
    }
}
