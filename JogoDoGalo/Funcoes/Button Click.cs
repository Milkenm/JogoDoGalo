using System;
using System.Windows.Forms;

namespace JogoDoGalo
{
	internal static partial class Functions
	{
		internal static void ButtonClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;

			if (button.Text == "")
			{
				PlayHandler(button, "X");
			}
		}
	}
}