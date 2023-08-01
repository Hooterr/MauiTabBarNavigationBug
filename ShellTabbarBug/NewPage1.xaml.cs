namespace ShellTabbarBug;

public partial class NewPage1 : ContentPage, IQueryAttributable
{
	public NewPage1()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Shell.SetTabBarIsVisible(this, false);
    }



}
