using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static bool CheckVictory(string player)
		{
			foreach (int combo in CombosList)
			{
				if (CheckCombo(combo, player, true))
				{
					if (player == "X")
					{
						/*
						 * THIS WILL NEVER HAPPEN
						 * 
						UpdateScores("X");
						MessageBox.Show("Player wins!", "Jogo do Galo", MessageBoxButtons.OK, MessageBoxIcon.Information));
						*/
					}
					else if (player == "O")
					{
						UpdateScores("O");
						MessageBox.Show("AI wins!", "Jogo do Galo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

					RestartGame();

					return true;
				}
			}

			if (PlayCount == 9)
			{
				UpdateScores("Draw");
				MessageBox.Show($"Draw.", "Jogo do Galo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RestartGame();

				return true;
			}

			return false;
		}
	}
}