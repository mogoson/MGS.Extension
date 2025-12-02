/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  RawImageExtension.cs
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
    public static class RawImageExtension
    {
        public static void AdaptBorder(this RawImage image, Vector2 border)
        {
            var rect = border;
            if (image.texture != null)
            {
                var texRect = new Vector2(image.texture.width, image.texture.height);
                rect = BorderUtility.Adapt(texRect, border);
            }
            image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rect.x);
            image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rect.y);
        }
    }
}