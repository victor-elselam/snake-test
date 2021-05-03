﻿using UnityEngine;
using UnityEngine.UI;

namespace _Tests
{
    public class AssertPrefab : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private Sprite _correctIcon;
        [SerializeField] private Sprite _incorrectIcon;
        [Space(10)]
        [SerializeField] private Text _text;
        [SerializeField] private Color _correctColor;
        [SerializeField] private Color _incorrectColor;

        public readonly AssertObject<object> Assert = new AssertObject<object>();

        public void Awake()
        {
            Assert.OnRun.AddListener(GetResult);
        }

        private void GetResult(string message)
        {
            _icon.sprite = Assert.EndResult ? _correctIcon : _incorrectIcon;
            _icon.color = Assert.EndResult ? _correctColor : _incorrectColor;
            _text.color = Assert.EndResult ? _correctColor : _incorrectColor;
            _text.text = message;
        }
    }
}