using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void TriggerAI()
		{
			// FIRST TURN FOR THE AI (TRY TO AVOID TRAPS BY PLAYING ON MID, ELSE PLAYING ON A CORNER)
			if (IsFirstTurn)
			{
				IsFirstTurn = false;
				// CHECK IF THE PLAYER WAS FIRST
				if (WasPlayerFirstTurn)
				{
					// IF THE BUTTON 5 IS EMPTY, TAKE IT!
					if (StaticButtonsList[5].Text == "")
					{
						AIPlay(StaticButtonsList[5]);
					}
					// ELSE TAKE A RANDOM CORNER
					else
					{
						AIPlay(PickACorner());
					}
				}
				// IF THE AI IS FIRST
				else
				{
					AIPlay(StaticButtonsList[5]);
				}
			}
			// SECOND TURN FOR THE AI (CHECK FOR THE [7/6] COMBO)
			else if (IsSecondTurn && CheckTraps() != 0)
			{
				IsSecondTurn = false;
				int trap = CheckTraps();

				if (trap == 756)
				{
					AIPlay(StaticButtonsList[9]);
				}
				else if (trap == 159 || trap == 753)
				{
					AIPlay(StaticButtonsList[2]);
				}
				else if (trap == 856)
				{
					AIPlay(StaticButtonsList[9]);
				}
			}
			else
			{
				IsSecondTurn = false;

				int playStyle = 0;
				// FIRST THE AI CHECKS IF IT CAN WIN, ELSE DEFEND
				string[] playStyles = { "O", "X" };

				while (playStyle <= 1)
				{
					// DEFEND BUTTON 1 (HORIZONTAL || VERTICAL || DIAGONAL)
					if (CheckCombo(CombosList[0], playStyles[playStyle]) || CheckCombo(CombosList[1], playStyles[playStyle]) || CheckCombo(CombosList[2], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[1]);
						return;
					}
					// DEFEND BUTTON 2 (HORIZONTAL || VERTICAL)
					else if (CheckCombo(CombosList[3], playStyles[playStyle]) || CheckCombo(CombosList[4], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[2]);
						return;
					}
					// DEFEND BUTTON 3 (HORIZONTAL || VERTICAL || DIAGONAL)
					else if (CheckCombo(CombosList[5], playStyles[playStyle]) || CheckCombo(CombosList[6], playStyles[playStyle]) || CheckCombo(CombosList[7], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[3]);
						return;
					}
					// DEFEND BUTTON 4 (HORIZONTAL || VERTICAL)
					else if (CheckCombo(CombosList[8], playStyles[playStyle]) || CheckCombo(CombosList[9], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[4]);
						return;
					}
					// DEFEND BUTTON 5 (HORIZONTAL || VERTICAL || DIAGONAL[1/5/9] || DIAGONAL[3/5/7])
					else if (CheckCombo(CombosList[10], playStyles[playStyle]) || CheckCombo(CombosList[11], playStyles[playStyle]) || CheckCombo(CombosList[12], playStyles[playStyle]) || CheckCombo(CombosList[13], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[5]);
						return;
					}
					// DEFEND BUTTON 6 (HORIZONTAL || VERTICAL)
					else if (CheckCombo(CombosList[14], playStyles[playStyle]) || CheckCombo(CombosList[15], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[6]);
						return;
					}
					// DEFEND BUTTON 7 (HORIZONTAL || VERTICAL || DIAGONAL)
					else if (CheckCombo(CombosList[16], playStyles[playStyle]) || CheckCombo(CombosList[17], playStyles[playStyle]) || CheckCombo(CombosList[18], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[7]);
						return;
					}
					// DEFEND BUTTON 8 (HORIZONTAL || VERTICAL)
					else if (CheckCombo(CombosList[19], playStyles[playStyle]) || CheckCombo(CombosList[20], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[8]);
						return;
					}
					// DEFEND BUTTON 9 (HORIZONTAL || VERTICAL || DIAGONAL)
					else if (CheckCombo(CombosList[21], playStyles[playStyle]) || CheckCombo(CombosList[22], playStyles[playStyle]) || CheckCombo(CombosList[23], playStyles[playStyle]))
					{
						AIPlay(StaticButtonsList[9]);
						return;
					}

					playStyle++;
				}

				// IF THE AI COULDN'T FIND A COMBO, PICK A CORNER
				Button cornerButton = PickACorner();
				if (cornerButton != null)
				{
					AIPlay(cornerButton);
				}
				// ELSE IF THE AI DOESN'T HAVE A FREE CORNER BUTTON
				else
				{
					Button sideButton = PickASide();

					if (sideButton != null)
					{
						AIPlay(sideButton);
					}
				}
			}
		}
	}
}