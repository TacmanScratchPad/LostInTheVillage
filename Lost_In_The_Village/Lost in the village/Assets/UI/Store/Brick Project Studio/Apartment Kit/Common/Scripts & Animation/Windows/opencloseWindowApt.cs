﻿using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using System.Collections;
using UnityEngine;

namespace SojaExiles
{
    public class opencloseWindowApt : AbstractInteractableObject
    {
        public string promptMessageTemp;

        public Animator openandclosewindow;
        public bool open;

        void Start()
        {
            open = false;
        }
        protected override void Interact()
        {
            promptMessageTemp = LanguagesTranslation.SetTextOpenClose();
        }
        protected override void Interact2()
        {
            if (open == false)
            {
                StartCoroutine(opening());
            }
            else
            {
                StartCoroutine(closing());
            }
        }
        IEnumerator opening()
        {
            print("you are opening the Window");
            openandclosewindow.Play("Openingwindow");
            open = true;
            yield return new WaitForSeconds(.5f);
        }
        IEnumerator closing()
        {
            print("you are closing the Window");
            openandclosewindow.Play("Closingwindow");
            open = false;
            yield return new WaitForSeconds(.5f);
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}