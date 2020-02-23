using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void UpdateScores(string scoreType)
		{
			if (scoreType == "X")
			{
				XWins++;
				MainForm.statusStrip_xWins.Text = "X : " + XWins;
			}
			else if (scoreType == "O")
			{
				OWins++;
				MainForm.statusStrip_oWins.Text = "O : " + OWins;
			}
			else if (scoreType == "Draw")
			{
				Draws++;
				MainForm.statusStrip_draws.Text = "Draws : " + Draws;
			}
		}
	}
}