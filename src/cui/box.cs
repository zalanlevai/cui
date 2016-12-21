using System;
using System.Collections.Generic;
using CUIInternal;

namespace CUI
{
	public class Box : Element
	{
		ConsoleColor color;

		/// Constructors
		public Box(string name, Rect boundary, ConsoleColor color)
		{
			Name = name;
			children = new List<Element>();

			LocalBoundary = boundary;

			this.color = color;
		}

		/// Methods
		public override void Draw()
		{
			for (int i = 0; i < GlobalBoundary.Height; i++)
				for (int j = 0; j < GlobalBoundary.Width; j++)
					Drawing.WriteChar(
							' ',
							GlobalBoundary.TopLeft + new Vector(j, i),
							Drawing.ForegroundColor, color);
		}
	}
}
