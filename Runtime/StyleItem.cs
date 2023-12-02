using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BlockadeLabsSDK
{
    public class StyleItem : MonoBehaviour
    {
        [SerializeField]
        private GameObject _newSticker;

        [SerializeField]
        private GameObject _premiumSticker;

        [SerializeField]
        private GameObject _experimentalSticker;

        [SerializeField]
        private TMP_Text _nameText;

        [SerializeField]
        private Button _button;
        public Button Button => _button;

        [SerializeField]
        private Hoverable _hoverable;
        public Hoverable Hoverable => _hoverable;

        [SerializeField]
        private GameObject _nextChevron;

        [SerializeField]
        private GameObject _selectedIndicator;

        public void SetStyle(SkyboxStyle style)
        {
            _nameText.text = style.name;
            _newSticker.SetActive(style.isNew);
            _premiumSticker.SetActive(style.premium);
            _experimentalSticker.SetActive(style.experimental);
            _nextChevron.SetActive(false);
        }

        public void SetStyleFamily(SkyboxStyleFamily styleFamily)
        {
            _nameText.text = styleFamily.name;
            _newSticker.SetActive(styleFamily.isNew);
            _premiumSticker.SetActive(styleFamily.premium);
            _experimentalSticker.SetActive(styleFamily.experimental);
            _nextChevron.SetActive(styleFamily.items.Count > 1);
        }

        public void SetSelected(bool selected)
        {
            _selectedIndicator.SetActive(selected);
        }
    }
}