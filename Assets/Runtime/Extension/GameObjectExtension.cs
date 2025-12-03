/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  GameObjectExtension.cs
 *  Description  :  Extension for UnityEngine.GameObject.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  09/03/2015
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Extension
{
    /// <summary>
	/// Extension for UnityEngine.GameObject.
	/// </summary>
	public static class GameObjectExtension
    {
        /// <summary>
        /// Set layer include it's children.
        /// </summary>
        public static void BroadcastLayer(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            foreach (Transform trans in gameObject.transform)
            {
                BroadcastLayer(trans.gameObject, layer);
            }
        }
    }
}