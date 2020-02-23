using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void LoadButtonsList()
		{
			ButtonsList.Clear();
			ButtonsList.Add(null);

			StaticButtonsList.Clear();
			StaticButtonsList.Add(null);

			for (int i = 1; i <= 9; i++)
			{
				Button b = (Button)MainForm.Controls["button" + i];

				ButtonsList.Add(b);
				StaticButtonsList.Add(b);
			}
		}
	}
}