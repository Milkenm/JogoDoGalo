using System.Linq;
using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void RestartGame()
		{
			LoadButtonsList();

			foreach (Button b in ButtonsList.Skip(1))
			{
				b.Text = "";
				b.Enabled = true;
			}

			PlayCount = 0;

			IsFirstTurn = true;
			IsSecondTurn = true;
			WasPlayerFirstTurn = true;
		}
	}
}