using System.Windows.Forms;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static bool CheckButtonLine(Button targetButton, Button buttonA, Button buttonB, string player, bool checkWin = false)
		{
			// NORMAL CHECK
			if (!checkWin)
			{
				return targetButton.Text == "" && buttonA.Text == player && buttonB.Text == player;
			}
			// CHECK VICTORY
			else
			{
				return targetButton.Text == player && buttonA.Text == player && buttonB.Text == player;
			}
		}
	}
}