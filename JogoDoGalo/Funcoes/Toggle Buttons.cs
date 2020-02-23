using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void ToggleButtons()
		{
			AreButtonsEnabled = !AreButtonsEnabled;

			foreach (Button b in ButtonsList)
			{
				b.Enabled = AreButtonsEnabled;
			}
		}
	}
}