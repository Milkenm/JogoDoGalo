using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static int CheckTraps()
		{
			if (StaticButtonsList[5].Text == "O" && StaticButtonsList[7].Text == "X" && StaticButtonsList[6].Text == "X")
			{
				return 756;
			}
			else if (StaticButtonsList[5].Text =="O" && StaticButtonsList[3].Text == "X" && StaticButtonsList[8].Text == "X")
			{
				return 358;
			}
			else if (StaticButtonsList[5].Text == "O" && StaticButtonsList[1].Text == "X" && StaticButtonsList[8].Text == "X")
			{
				return 158;
			}
			else if (StaticButtonsList[5].Text == "O" && StaticButtonsList[1].Text == "X" && StaticButtonsList[9].Text == "X")
			{
				return 159;
			}
			else if (StaticButtonsList[5].Text == "O" && StaticButtonsList[7].Text == "X" && StaticButtonsList[3].Text == "X")
			{
				return 753;
			}
			else if (StaticButtonsList[5].Text == "O" && StaticButtonsList[8].Text == "X" && StaticButtonsList[6].Text == "X")
			{
				return 856;
			}

			return 0;
		}
	}
}