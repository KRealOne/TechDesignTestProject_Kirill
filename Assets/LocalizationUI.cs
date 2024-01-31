using System.Linq;
using Knot.Localization;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown languageDropdown = GetComponent<Dropdown>();

        languageDropdown.AddOptions(KnotLocalization.Manager.Languages.Select(d => d.NativeName).ToList());
        languageDropdown.onValueChanged.AddListener(OnLanguageChanged);

    }

    private void OnLanguageChanged(int arg0)
    {
        KnotLocalization.Manager.LoadLanguage(KnotLocalization.Manager.Languages[arg0]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}