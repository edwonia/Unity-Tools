﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Edwon.UnityTools 
{
    public class UIImageSetter : MonoBehaviour
    {
        public Image image;

        public void SetImageSprite(Sprite sprite)
        {
            image.sprite = sprite;
        }
    }
}