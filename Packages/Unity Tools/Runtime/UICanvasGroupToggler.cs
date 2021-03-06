﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Edwon.Tools 
{
    [RequireComponent(typeof(CanvasGroup))]
    public class UICanvasGroupToggler : MonoBehaviour
    {
        CanvasGroup canvasGroup;
        public bool setActive = true;

        void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        [InspectorButton("Show")]
        public bool show;
        public void Show()
        {
            if(canvasGroup == null)
                canvasGroup = GetComponent<CanvasGroup>();
            Utils.ShowCanvasGroup(canvasGroup, true, setActive);
        }

        public void ShowAfter(float delay)
        {
            if(canvasGroup == null)
                canvasGroup = GetComponent<CanvasGroup>();

            StaticCoroutine.DoAfter(delay, ()=> Utils.ShowCanvasGroup(canvasGroup, true, setActive));
        }

        [InspectorButton("Hide")]
        public bool hide;
        public void Hide()
        {
            if(canvasGroup == null)
                canvasGroup = GetComponent<CanvasGroup>();
            Utils.ShowCanvasGroup(canvasGroup, false, setActive);
        }

        public void HideAfter(float delay)
        {
            if(canvasGroup == null)
                canvasGroup = GetComponent<CanvasGroup>();

            StaticCoroutine.DoAfter(delay, ()=> Utils.ShowCanvasGroup(canvasGroup, false, setActive));
        }

        public void Toggle(bool toggle)
        {
            if (toggle)
                Show();
            else
                Hide();
        }
    }
}