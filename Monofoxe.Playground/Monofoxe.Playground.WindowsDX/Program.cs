﻿using System;
using Monofoxe.Engine.WindowsDX;

namespace Monofoxe.Playground.WindowsDX
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			MonofoxePlatform.Init();

			using (var game = new Game1())
			{
				game.Run();
			}
		}
	}
}
