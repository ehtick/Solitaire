namespace SolitaireAvalonia.ViewModels;

public class SettingsViewModel : ViewModelBase
{
    private readonly CasinoViewModel _casinoViewModel;

    public SettingsViewModel(CasinoViewModel casinoViewModel)
    {
        _casinoViewModel = casinoViewModel;
    }
}