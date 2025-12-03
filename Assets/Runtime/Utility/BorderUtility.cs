/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  BorderUtility.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  12/02/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Extension
{
    public sealed class BorderUtility
    {
        public static Vector2 Adapt(Vector2 rect, Vector2 border)
        {
            var w = border.x;
            var h = border.y;
            var wr = rect.x / border.x;
            var hr = rect.y / border.y;
            if (wr > hr)
            {
                h = w * (rect.y / rect.x);
            }
            else
            {
                w = h * (rect.x / rect.y);
            }
            return new Vector2(w, h);
        }
    }
}