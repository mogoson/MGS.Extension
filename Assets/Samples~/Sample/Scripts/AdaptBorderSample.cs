/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AdaptBorderSample.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  12/02/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.Extension.Sample
{
    public class AdaptBorderSample : MonoBehaviour
    {
        public Image image;
        public RawImage rawImage;

        void Start()
        {
            var iBorder = (image.transform.parent as RectTransform).rect.size;
            image.AdaptBorder(iBorder);

            var riBorder = (rawImage.transform.parent as RectTransform).rect.size;
            rawImage.AdaptBorder(riBorder);
        }
    }
}