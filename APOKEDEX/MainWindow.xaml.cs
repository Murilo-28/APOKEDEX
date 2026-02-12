using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APOKEDEX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pokemon> pokedex;
        public MainWindow()
        {
            InitializeComponent();
            CarregarPokedex();
            PokemonList.ItemsSource = pokedex;
        }

        private void CarregarPokedex()
        {
            var bulbasaur = new Pokemon
            {
                Nome = "Bulbasaur",
                Tipo = "Grama / Veneno",
                Descricao = "Durante algum tempo após o seu nascimento, utilizou os nutrientes contidos na semente em suas costas para crescer.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png"
            };

            var ivysaur = new Pokemon
            {
                Nome = "Ivysaur",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png"
            };

            var venusaur = new Pokemon
            {
                Nome = "Venusaur",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png"
            };

            bulbasaur.Evolucoes = new List<Pokemon>
            {
                bulbasaur,
                ivysaur,
                venusaur
            };

            pokedex = new List<Pokemon>
            {
                bulbasaur
            };
        }

        private void PokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PokemonList.SelectedItem is Pokemon pokemon)
            {
                NomeText.Text = pokemon.Nome;
                TipoText.Text = pokemon.Tipo;
                DescricaoText.Text = pokemon.Descricao;
                PokemonImage.Source = new BitmapImage(new System.Uri(pokemon.Imagem));

                EvolucaoList.ItemsSource = pokemon.Evolucoes;
            }
        }
    }
}