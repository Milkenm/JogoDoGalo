using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void PlayHandler(Button button, string player)
		{
			if (button.Text == "")
			{
				button.Text = player;

				RemoveButton(button);
				PlayCount++;

				if (!CheckVictory(player) && player == "X")
				{
					TriggerAI();
				}
			}
		}
	}
}