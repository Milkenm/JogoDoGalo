using System.Windows.Forms;

using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void RemoveButton(Button button)
		{
			ButtonsList.Remove(button);
			button.Enabled = false;
		}
	}
}