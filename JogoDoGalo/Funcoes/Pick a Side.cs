using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static Button PickASide()
		{
			// TAKE 2
			if (StaticButtonsList[2].Text == "")
			{
				return StaticButtonsList[2];
			}
			// TAKE 4
			else if (StaticButtonsList[4].Text == "")
			{
				return StaticButtonsList[4];
			}
			// TAKE 6
			else if (StaticButtonsList[6].Text == "")
			{
				return StaticButtonsList[6];
			}
			// TAKE 8
			else if (StaticButtonsList[8].Text == "")
			{
				return StaticButtonsList[8];
			}
			// EVERYTHING IS TAKEN
			else
			{
				return null;
			}
		}
	}
}