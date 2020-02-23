using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static Button PickACorner()
		{
			// TAKE 1
			if (StaticButtonsList[1].Text == "")
			{
				return StaticButtonsList[1];
			}
			// TAKE 3
			else if (StaticButtonsList[3].Text == "")
			{
				return StaticButtonsList[3];
			}
			// TAKE 7
			else if (StaticButtonsList[7].Text == "")
			{
				return StaticButtonsList[7];
			}
			// TAKE 9
			else if (StaticButtonsList[9].Text == "")
			{
				return StaticButtonsList[9];
			}
			// ELSE IF EVERYTHING IS TAKEN
			else
			{
				return null;
			}
		}
	}
}