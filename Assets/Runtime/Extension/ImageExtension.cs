/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ImageExtension.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  12/02/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.Extension
{
    public static class ImageExtension
    {
        public static void AdaptBorder(this Image image, Vector2 border)
        {
            var rect = border;
            if (image.sprite != null)
            {
                rect = BorderUtility.Adapt(image.sprite.rect.size, border);
            }
            image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rect.x);
            image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.y);
        }
    }
}