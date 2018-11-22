﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Monofoxe.Engine.ECS;


namespace Monofoxe.Engine.Utils.Tilemaps
{
	/// <summary>
	/// System for Tiled image layers. Just draws all images from components.
	/// </summary>
	public class ImageLayerSystem : BaseSystem
	{
		public override string Tag => "imageLayer";
		
		public override void Draw(List<Component> images)
		{
			foreach(ImageLayerComponent image in images)
			{
				DrawMgr.DrawFrame(image.Frame, image.Offset, Vector2.Zero);
			}
		}

	}
}
