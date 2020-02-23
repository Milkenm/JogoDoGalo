using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoDoGalo
{
	internal static class Static
	{
		internal static Main MainForm;

		// Current play number
		internal static int PlayCount = 0;

		internal static bool WasPlayerFirstTurn, IsFirstTurn = true, IsSecondTurn, AreButtonsEnabled = true;

		// List of every possible combination
		internal static readonly int[] CombosList =
		{
			123, 147, 159, // 1
			213, 258, // 2
			312, 369, 357, // 3
			417, 456, // 4
			546, 528, 537, 519, // 5
			645, 639, // 6
			789, 714, 735, // 7
			879, 825, // 8
			978, 936, 915 // 9
		};

		internal static int XWins = 0, OWins = 0, Draws = 0; // Draws

		internal static List<Button> StaticButtonsList = new List<Button>() { null, };
		internal static List<Button> ButtonsList = new List<Button>() { null, };
	}
}