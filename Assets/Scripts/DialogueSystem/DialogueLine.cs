using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;
        [Header ("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header("Time parameters")]
        [SerializeField] private float delay;

        [Header("Character Imager")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageHolder;
        
        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";

            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay));
            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true;
        }

        private IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, float delay)
        {
            throw new NotImplementedException();
        }
    }
}

