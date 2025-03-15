using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankietaPreferencji;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        
    }

    private void ShowSurvey_Click(object? sender, RoutedEventArgs e)
    {
        var pytanie1 = C1.IsChecked == true ? 1 : 0;
        var pytanie2 = C2.IsChecked == true ? 1 : 0;
        var pytanie3 = C3.IsChecked == true ? 1 : 0;
        
        var ileTak = pytanie1 + pytanie2 + pytanie3;

        if (ileTak == 1)
        {
            wyniki.Text = "Na 'tak' zagłosowano: "+ileTak.ToString()+" raz.";
        }
        else
        {
            wyniki.Text = "Na 'tak' zagłosowano: "+ileTak.ToString()+" razy.";
        }
        
        var comboBoxValue = (ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";

        var kat = $"{comboBoxValue}";
        if (kat == "Wybierz")
        {
            kategoria.Text = "Nic nie wybrano!";
        }
        else
        {
            kategoria.Text = "Wybrana kategoria to: "+kat;
        }
        
        var imie = name.Text;
        if (imie == null)
        {
            tname.Text = "Nie podano imienia!";
        }
        else
        {
            tname.Text = "Na imię masz: "+imie;
        }
    }
}