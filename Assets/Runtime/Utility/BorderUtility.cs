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
            var x = border.x;
            var y = border.y;
            var xr = rect.x / border.x;
            var yr = rect.y / border.y;
            if (xr > yr)
            {
                y = x * (rect.y / rect.x);
            }
            else
            {
                x = y * (rect.x / rect.y);
            }
            return new Vector2(x, y);
        }
    }
}