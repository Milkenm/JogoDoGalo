using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static bool CheckCombo(int combo, string player, bool checkWin = false)
		{
			if (!checkWin)
			{
				switch (combo)
				{
					case 123: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[2], StaticButtonsList[3], player); // 1 HORIZONTAL
					case 147: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[4], StaticButtonsList[7], player); // 1 VERTICAL
					case 159: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[5], StaticButtonsList[9], player); // 1 DIAGONAL

					case 213: return CheckButtonLine(StaticButtonsList[2], StaticButtonsList[1], StaticButtonsList[3], player); // 2 HORIZONTAL
					case 258: return CheckButtonLine(StaticButtonsList[2], StaticButtonsList[5], StaticButtonsList[8], player); // 2 VERTICAL

					case 312: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[1], StaticButtonsList[2], player); // 3 HORIZONTAL
					case 369: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[6], StaticButtonsList[9], player); // 3 VERTICAL
					case 357: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[5], StaticButtonsList[7], player); // 3 DIAGONAL

					case 417: return CheckButtonLine(StaticButtonsList[4], StaticButtonsList[1], StaticButtonsList[7], player); // 4 HORIZONTAL
					case 456: return CheckButtonLine(StaticButtonsList[4], StaticButtonsList[5], StaticButtonsList[6], player); // 4 VERTICAL

					case 546: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[4], StaticButtonsList[6], player); // 5 HORIZONTAL
					case 528: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[2], StaticButtonsList[8], player); // 5 VERTICAL
					case 537: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[3], StaticButtonsList[7], player); // 5 DIAGONAL [3/5/7]
					case 519: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[1], StaticButtonsList[9], player); // 5 DIAGONAL [1/5/9]

					case 645: return CheckButtonLine(StaticButtonsList[6], StaticButtonsList[4], StaticButtonsList[5], player); // 6 HORIZONTAL
					case 639: return CheckButtonLine(StaticButtonsList[6], StaticButtonsList[3], StaticButtonsList[9], player); // 6 VERTICAL

					case 789: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[8], StaticButtonsList[9], player); // 7 HORIZONTAL
					case 714: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[1], StaticButtonsList[4], player); // 7 VERTICAL
					case 735: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[3], StaticButtonsList[5], player); // 7 DIAGONAL

					case 879: return CheckButtonLine(StaticButtonsList[8], StaticButtonsList[7], StaticButtonsList[9], player); // 8 HORIZONTAL
					case 825: return CheckButtonLine(StaticButtonsList[8], StaticButtonsList[2], StaticButtonsList[5], player); // 8 VERTICAL

					case 978: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[7], StaticButtonsList[8], player); // 9 HORIZONTAL
					case 936: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[3], StaticButtonsList[6], player); // 9 VERTICAL
					case 915: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[1], StaticButtonsList[5], player); // 9 DIAGONAL

					default:
						return false;
				}
			}
			else
			{
				switch (combo)
				{
					case 123: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[2], StaticButtonsList[3], player, checkWin); // 1 HORIZONTAL
					case 147: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[4], StaticButtonsList[7], player, checkWin); // 1 VERTICAL
					case 159: return CheckButtonLine(StaticButtonsList[1], StaticButtonsList[5], StaticButtonsList[9], player, checkWin); // 1 DIAGONAL

					case 213: return CheckButtonLine(StaticButtonsList[2], StaticButtonsList[1], StaticButtonsList[3], player, checkWin); // 2 HORIZONTAL
					case 258: return CheckButtonLine(StaticButtonsList[2], StaticButtonsList[5], StaticButtonsList[8], player, checkWin); // 2 VERTICAL

					case 312: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[1], StaticButtonsList[2], player, checkWin); // 3 HORIZONTAL
					case 369: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[6], StaticButtonsList[9], player, checkWin); // 3 VERTICAL
					case 357: return CheckButtonLine(StaticButtonsList[3], StaticButtonsList[5], StaticButtonsList[7], player, checkWin); // 3 DIAGONAL

					case 417: return CheckButtonLine(StaticButtonsList[4], StaticButtonsList[1], StaticButtonsList[7], player, checkWin); // 4 HORIZONTAL
					case 456: return CheckButtonLine(StaticButtonsList[4], StaticButtonsList[5], StaticButtonsList[6], player, checkWin); // 4 VERTICAL

					case 546: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[4], StaticButtonsList[6], player, checkWin); // 5 HORIZONTAL
					case 528: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[2], StaticButtonsList[8], player, checkWin); // 5 VERTICAL
					case 537: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[3], StaticButtonsList[7], player, checkWin); // 5 DIAGONAL [3/5/7]
					case 519: return CheckButtonLine(StaticButtonsList[5], StaticButtonsList[1], StaticButtonsList[9], player, checkWin); // 5 DIAGONAL [1/5/9]

					case 645: return CheckButtonLine(StaticButtonsList[6], StaticButtonsList[4], StaticButtonsList[5], player, checkWin); // 6 HORIZONTAL
					case 639: return CheckButtonLine(StaticButtonsList[6], StaticButtonsList[3], StaticButtonsList[9], player, checkWin); // 6 VERTICAL

					case 789: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[8], StaticButtonsList[9], player, checkWin); // 7 HORIZONTAL
					case 714: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[1], StaticButtonsList[4], player, checkWin); // 7 VERTICAL
					case 735: return CheckButtonLine(StaticButtonsList[7], StaticButtonsList[3], StaticButtonsList[5], player, checkWin); // 7 DIAGONAL

					case 879: return CheckButtonLine(StaticButtonsList[8], StaticButtonsList[7], StaticButtonsList[9], player, checkWin); // 8 HORIZONTAL
					case 825: return CheckButtonLine(StaticButtonsList[8], StaticButtonsList[2], StaticButtonsList[5], player, checkWin); // 8 VERTICAL

					case 978: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[7], StaticButtonsList[8], player, checkWin); // 9 HORIZONTAL
					case 936: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[3], StaticButtonsList[6], player, checkWin); // 9 VERTICAL
					case 915: return CheckButtonLine(StaticButtonsList[9], StaticButtonsList[1], StaticButtonsList[5], player, checkWin); // 9 DIAGONAL

					default:
						return false;
				}
			}
		}
	}
}