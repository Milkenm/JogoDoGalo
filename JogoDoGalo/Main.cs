using System.Windows.Forms;

using static JogoDoGalo.Functions;
using static JogoDoGalo.Static;

namespace JogoDoGalo
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			MainForm = this;

			RestartGame();
		}
	}
}