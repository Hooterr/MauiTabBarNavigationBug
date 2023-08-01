namespace ShellTabbarBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("r", typeof(NewPage1));
	}
}

