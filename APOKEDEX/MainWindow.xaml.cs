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
        //teste commit
        private void CarregarPokedex()
        {
            var bulbasaur = new Pokemon
            {
                Nome = "Bulbasaur",
                Tipo = "Grama / Veneno",
                NumeroPokedex = 001,
                Geracao = 1,
                Descricao = "Bulbasaur nasce com uma semente plantada em suas costas, que cresce junto com seu corpo e mantém uma relação simbiótica com ele. Essa estrutura permite armazenar energia solar e transformá-la em nutrientes, ajudando o Pokémon a sobreviver mesmo quando há pouca comida. É comum vê-lo descansando sob o sol para fortalecer o bulbo, que fica mais poderoso quando exposto à luz intensa.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png"
            };

            var ivysaur = new Pokemon
            {
                Nome = "Ivysaur",
                Tipo = "Grama / Veneno",
                NumeroPokedex = 002,
                Geracao = 1,
                Descricao = "Ivysaur é a forma evoluída de Bulbasaur. O botão em suas costas absorve nutrientes continuamente e começa a florescer, liberando um aroma adocicado. Esse crescimento indica que o Pokémon está se preparando para sua próxima evolução e que possui grande energia acumulada.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png"
            };

            var venusaur = new Pokemon
            {
                Nome = "Venusaur",
                Tipo = "Grama / Veneno",
                NumeroPokedex = 003,
                Geracao = 1,
                Descricao = "Venusaur possui uma grande flor totalmente aberta nas costas. Após períodos de chuva, ela exala um perfume forte capaz de atrair outros Pokémon, sugerindo um papel importante na natureza ao seu redor. O tamanho da planta demonstra sua maturidade e enorme reserva de energia.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png"
            };

            bulbasaur.Evolucoes = new List<Pokemon>
            {
                bulbasaur,
                ivysaur,
                venusaur
            };

            ivysaur.Evolucoes = new List<Pokemon>
            {
                bulbasaur,
                ivysaur,
                venusaur
            };

            venusaur.Evolucoes = new List<Pokemon>
            {
                bulbasaur,
                ivysaur,
                venusaur
            };

            var charmander = new Pokemon
            {
                Nome = "Charmander",
                Tipo = "Fogo",
                NumeroPokedex = 004,
                Geracao = 1,
                Descricao = "A chama na ponta de sua cauda funciona como um indicador de vitalidade — quanto mais intensa, mais saudável ele está. Se a chama se apagar, sua vida corre perigo, mostrando a ligação direta entre seu corpo e o fogo que produz",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png"
            };

            var charmaleon = new Pokemon
            {
                Nome = "Charmeleon",
                Tipo = "Fogo",
                NumeroPokedex = 005,
                Geracao = 1,
                Descricao = "Charmeleon é naturalmente agressivo e busca adversários fortes para provar seu poder. Em batalhas difíceis, sua chama fica ainda mais intensa, refletindo seu espírito competitivo e temperamento explosivo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png"
            };

            var charizard = new Pokemon
            {
                Nome = "Charizard",
                Tipo = "Fogo / Voador",
                NumeroPokedex = 006,
                Geracao = 1,
                Descricao = "Charizard voa pelos céus em busca de oponentes dignos. Seu fogo se torna mais quente após enfrentar batalhas desafiadoras, demonstrando que sua força cresce com a experiência.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png"
            };

            charmander.Evolucoes = new List<Pokemon>
            {
                charmander,
                charmaleon,
                charizard
            };

            charmaleon.Evolucoes = new List<Pokemon>
            {
                charmander,
                charmaleon,
                charizard
            };

            charizard.Evolucoes = new List<Pokemon>
            {
                charmander,
                charmaleon,
                charizard
            };

            var squirtle = new Pokemon
            {
                Nome = "Squirtle",
                Tipo = "Água",
                NumeroPokedex = 007,
                Geracao = 1,
                Descricao = "Squirtle se protege recolhendo-se dentro de sua concha resistente e contra-ataca disparando jatos de água com grande pressão. Essa estratégia combina defesa sólida com ataques rápidos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png"
            };

            var wartortle = new Pokemon
            {
                Nome = "Wartortle",
                Tipo = "Água",
                NumeroPokedex = 008,
                Geracao = 1,
                Descricao = "Conhecido por sua longa cauda peluda, símbolo de longevidade em algumas tradições, Wartortle é valorizado por treinadores pacientes. Ele representa crescimento e experiência dentro de sua linha evolutiva.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png"
            };

            var blastoise = new Pokemon
            {
                Nome = "Blastoise",
                Tipo = "Água",
                NumeroPokedex = 009,
                Geracao = 1,
                Descricao = "Blastoise possui poderosos canhões em sua concha capazes de lançar água com força suficiente para perfurar materiais resistentes. Essa combinação de peso e pressão o torna um dos Pokémon aquáticos mais perigosos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png"
            };

            squirtle.Evolucoes = new List<Pokemon>
            {
                squirtle,
                wartortle,
                blastoise
            };

            wartortle.Evolucoes = new List<Pokemon>
            {
                squirtle,
                wartortle,
                blastoise
            };

            blastoise.Evolucoes = new List<Pokemon>
            {
                squirtle,
                wartortle,
                blastoise
            };

            var caterpie = new Pokemon
            {
                Nome = "Caterpie",
                Tipo = "Inseto",
                NumeroPokedex = 010,
                Geracao = 1,
                Descricao = "Caterpie tem grande apetite e passa a maior parte do tempo se alimentando de folhas para crescer rapidamente. Seu corpo macio esconde um mecanismo de defesa: um odor forte usado para afastar predadores.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png"
            };

            var metapod = new Pokemon
            {
                Nome = "Metapod",
                Tipo = "Inseto",
                NumeroPokedex = 011,
                Geracao = 1,
                Descricao = "Durante essa fase, Metapod quase não se move. Ele endurece sua casca para se proteger enquanto ocorre uma transformação interna intensa que levará à sua próxima forma.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png"
            };

            var butterfree = new Pokemon
            {
                Nome = "Butterfree",
                Tipo = "Inseto / Voador",
                NumeroPokedex = 012,
                Geracao = 1,
                Descricao = "Butterfree possui asas capazes de espalhar pólen tóxico à distância. Ele pode localizar flores mesmo a quilômetros, demonstrando um olfato extremamente sensível.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png"
            };

            caterpie.Evolucoes = new List<Pokemon>
            {
                caterpie,
                metapod,
                butterfree
            };

            metapod.Evolucoes = new List<Pokemon>
            {
                caterpie,
                metapod,
                butterfree
            };

            butterfree.Evolucoes = new List<Pokemon>
            {
                caterpie,
                metapod,
                butterfree
            };

            var weedle = new Pokemon
            {
                Nome = "Weedle",
                Tipo = "Inseto / Veneno",
                NumeroPokedex = 013,
                Geracao = 1,
                Descricao = "Weedle vive principalmente em florestas e se alimenta de folhas. Apesar de pequeno, possui um ferrão venenoso na cabeça, usado como defesa contra ameaças.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png"
            };

            var kakuna = new Pokemon
            {
                Nome = "Kakuna",
                Tipo = "Inseto / Veneno",
                NumeroPokedex = 014,
                Geracao = 1,
                Descricao = "Kakuna permanece preso a árvores enquanto seu corpo passa por uma evolução silenciosa. Embora pareça indefeso, pode atacar com veneno caso seja perturbado.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png"
            };

            var beedrill = new Pokemon
            {
                Nome = "Beedrill",
                Tipo = "Inseto / Veneno",
                NumeroPokedex = 015,
                Geracao = 1,
                Descricao = "Extremamente territorial, Beedrill costuma atacar em enxames. Seus ferrões são armas rápidas e perigosas, capazes de afastar qualquer intruso.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png"
            };

            weedle.Evolucoes = new List<Pokemon>
            {
                weedle,
                kakuna,
                beedrill
            };

            kakuna.Evolucoes = new List<Pokemon>
            {
                weedle,
                kakuna,
                beedrill
            };

            beedrill.Evolucoes = new List<Pokemon>
            {
                weedle,
                kakuna,
                beedrill
            };

            var pidgey = new Pokemon
            {
                Nome = "Pidgey",
                Tipo = "Normal / Voador",
                NumeroPokedex = 016,
                Geracao = 1,
                Descricao = "Pidgey prefere evitar conflitos. Quando ameaçado, levanta areia com o bater das asas para escapar rapidamente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png"
            };

            var pidgeotto = new Pokemon
            {
                Nome = "Pidgeotto",
                Tipo = "Normal / Voador",
                NumeroPokedex = 017,
                Geracao = 1,
                Descricao = "Esse Pokémon patrulha grandes territórios em busca de presas. Sua visão aguçada permite localizar movimentos mínimos no solo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png"
            };

            var pidgeot = new Pokemon
            {
                Nome = "Pidgeot",
                Tipo = "Normal / Voador",
                NumeroPokedex = 018,
                Geracao = 1,
                Descricao = "Pidgeot pode voar a velocidades impressionantes e criar rajadas de vento fortes apenas com o bater de suas asas, mostrando domínio total do céu.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png"
            };

            pidgey.Evolucoes = new List<Pokemon>
            {
                pidgey,
                pidgeotto,
                pidgeot
            };

            pidgeotto.Evolucoes = new List<Pokemon>
            {
                pidgey,
                pidgeotto,
                pidgeot
            };

            pidgeot.Evolucoes = new List<Pokemon>
            {
                pidgey,
                pidgeotto,
                pidgeot
            };

            var ratata = new Pokemon
            {
                Nome = "Rattata",
                Tipo = "Normal",
                Descricao = "Famoso por seus dentes sempre em crescimento, Rattata precisa roer constantemente objetos para mantê-los afiados e sob controle.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png"
            };

            var raticate = new Pokemon
            {
                Nome = "Raticate",
                Tipo = "Normal",
                Descricao = "Raticate usa seus bigodes para manter o equilíbrio. Se eles forem danificados, sua mobilidade fica comprometida, tornando-o mais vulnerável.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png"
            };

            ratata.Evolucoes = new List<Pokemon>
            {
                ratata,
                raticate
            };

            raticate.Evolucoes = new List<Pokemon>
            {
                ratata,
                raticate
            };

            var spearow = new Pokemon
            {
                Nome = "Spearow",
                Tipo = "Normal / Voador",
                Descricao = "Spearow é um Pokémon pequeno, porém extremamente territorial e barulhento. Diferente de outros pássaros que voam longas distâncias, ele prefere voos curtos e rápidos, batendo as asas com grande frequência para se locomover entre arbustos e áreas gramadas. Vive em bandos e alerta os outros membros com gritos agudos ao perceber perigo. Apesar do tamanho, pode atacar ferozmente se provocado, usando seu bico afiado para intimidar adversários.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/21.png"
            };

            var fearow = new Pokemon
            {
                Nome = "Fearow",
                Tipo = "Normal / Voador",
                Descricao = "Fearow é a evolução de Spearow e possui asas longas e poderosas que permitem voar por grandes distâncias sem precisar pousar. Seu pescoço alongado e bico pontiagudo são ideais para capturar presas com precisão. Ele costuma sobrevoar vastos territórios à procura de alimento e defende sua área com agressividade. Sua resistência e velocidade o tornam um predador eficiente nos céus.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/22.png"
            };

            spearow.Evolucoes = new List<Pokemon>
            {
                spearow,
                fearow
            };

            fearow.Evolucoes = new List<Pokemon>
            {
                spearow,
                fearow
            };

            var ekans = new Pokemon
            {
                Nome = "Ekans",
                Tipo = "Veneno",
                Descricao = "Ekans se move silenciosamente pela grama alta, usando a língua bifurcada para detectar vibrações e odores no ambiente. Alimenta-se principalmente de ovos e pequenos Pokémon, engolindo suas presas inteiras. Durante a noite, torna-se mais ativo, aproveitando a escuridão para caçar sem ser percebido. Sua capacidade de enrolar o corpo permite ataques rápidos e eficientes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/23.png"
            };

            var arbok = new Pokemon
            {
                Nome = "Arbok",
                Tipo = "Veneno",
                Descricao = "Arbok é conhecido pelos padrões intimidadoras em seu “capuz”, que variam conforme a região. Essas marcas servem para assustar predadores e rivais. Seu veneno é extremamente potente, e ele pode esmagar adversários envolvendo-os com seu corpo musculoso antes de atacar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/24.png"
            };

            ekans.Evolucoes = new List<Pokemon>
            {
                ekans,
                arbok
            };

            arbok.Evolucoes = new List<Pokemon>
            {
                ekans,
                arbok
            };

            var pikachu = new Pokemon
            {
                Nome = "Pikachu",
                Tipo = "Elétrico",
                Descricao = "Pikachu armazena eletricidade em bolsas localizadas nas bochechas. Quando ameaçado ou animado, libera descargas elétricas que podem causar fortes choques. Vive geralmente em florestas, onde grupos podem gerar tempestades elétricas quando descarregam energia simultaneamente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png"
            };

            var raichu = new Pokemon
            {
                Nome = "Raichu",
                Tipo = "Elétrico",
                Descricao = "Raichu é capaz de liberar descargas elétricas ainda mais intensas que sua forma anterior. Para evitar sobrecarga, descarrega eletricidade no solo por meio de sua cauda. Seu corpo pode emitir faíscas quando acumula muita energia.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/26.png"
            };

            pikachu.Evolucoes = new List<Pokemon>
            {
                pikachu,
                raichu
            };

            raichu.Evolucoes = new List<Pokemon>
            {
                pikachu,
                raichu
            };

            var sandshrew = new Pokemon
            {
                Nome = "Sandshrew",
                Tipo = "Terra",
                Descricao = "Sandshrew prefere ambientes secos e arenosos. Ele se enterra profundamente no solo para evitar calor excessivo e predadores. Quando ameaçado, enrola-se em uma bola protegida por sua pele resistente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/27.png"
            };

            var sandslash = new Pokemon
            {
                Nome = "Sandslash",
                Tipo = "Terra",
                Descricao = "Sandslash possui grandes garras afiadas que usa tanto para cavar quanto para atacar. Pode se enrolar em uma esfera espinhosa e rolar em direção ao inimigo, tornando-se uma defesa e ataque ao mesmo tempo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/28.png"
            };

            sandshrew.Evolucoes = new List<Pokemon>
            {
                sandshrew,
                sandslash
            };

            sandslash.Evolucoes = new List<Pokemon>
            {
                sandshrew,
                sandslash
            };

            var nidoranFem = new Pokemon
            {
                Nome = "Nidoran♀",
                Tipo = "Veneno",
                Descricao = "Apesar do tamanho pequeno, Nidoran♀ possui ferrões venenosos. É cautelosa e utiliza suas grandes orelhas para detectar sons distantes, mantendo-se alerta contra possíveis ameaças.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/29.png"
            };

            var nidorina = new Pokemon
            {
                Nome = "Nidorina",
                Tipo = "Veneno",
                Descricao = "Nidorina é mais reservada e protetora. Seu chifre cresce lentamente e ela prefere ataques físicos como mordidas e arranhões, utilizando força corporal ao invés de apenas veneno.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/30.png"
            };

            var nidoqueen = new Pokemon
            {
                Nome = "Nidoqueen",
                Tipo = "Veneno / Terra",
                Descricao = "Nidoqueen possui um corpo robusto coberto por escamas duras. É extremamente protetora com seus filhotes e usa sua força impressionante para enfrentar qualquer ameaça.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/31.png"
            };

            nidoranFem.Evolucoes = new List<Pokemon>
            {
                nidoranFem,
                nidorina,
                nidoqueen
            };

            nidorina.Evolucoes = new List<Pokemon>
            {
                nidoranFem,
                nidorina,
                nidoqueen
            };

            nidoqueen.Evolucoes = new List<Pokemon>
            {
                nidoranFem,
                nidorina,
                nidoqueen
            };

            var nidoranMasc = new Pokemon
            {
                Nome = "Nidoran♂",
                Tipo = "Veneno",
                Descricao = "Nidoran♂ é conhecido por sua audição sensível. Seu chifre contém veneno potente, que se torna mais forte à medida que cresce.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/32.png"
            };

            var nidorino = new Pokemon
            {
                Nome = "Nidorino",
                Tipo = "Veneno",
                Descricao = "Nidorino é agressivo e rápido para atacar. Seu chifre pode liberar toxinas perigosas, e ele investe contra o adversário com grande velocidade.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/33.png"
            };

            var nidoking = new Pokemon
            {
                Nome = "Nidoking",
                Tipo = "Veneno / Terra",
                Descricao = "Nidoking combina força física e poder venenoso. Usa sua cauda poderosa para esmagar inimigos e possui resistência elevada em batalha.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/34.png"
            };

            nidoranMasc.Evolucoes = new List<Pokemon>
            {
                nidoranMasc,
                nidorino,
                nidoking
            };

            nidorino.Evolucoes = new List<Pokemon>
            {
                nidoranMasc,
                nidorino,
                nidoking
            };

            nidoking.Evolucoes = new List<Pokemon>
            {
                nidoranMasc,
                nidorino,
                nidoking
            };

            var cleafairy = new Pokemon
            {
                Nome = "Clefairy",
                Tipo = "Fada",
                Descricao = "Clefairy é tímido e raramente visto durante o dia. Diz-se que aparece em noites de lua cheia para dançar em grupo, criando uma atmosfera quase mágica.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png"
            };

            var clefable = new Pokemon
            {
                Nome = "Clefable",
                Tipo = "Fada",
                Descricao = "Clefable é ainda mais raro e está associado a lendas sobre a lua. Movimenta-se de forma leve e silenciosa, quase sem deixar pegadas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png"
            };

            cleafairy.Evolucoes = new List<Pokemon>
            {
                cleafairy,
                clefable
            };

            clefable.Evolucoes = new List<Pokemon>
            {
                cleafairy,
                clefable
            };

            var vulpix = new Pokemon
            {
                Nome = "Vulpix",
                Tipo = "Fogo",
                Descricao = "Vulpix nasce com uma única cauda clara que se divide conforme cresce. É capaz de controlar chamas com precisão e costuma ser encontrado em áreas quentes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/37.png"
            };

            var ninetales = new Pokemon
            {
                Nome = "Ninetales",
                Tipo = "Fogo",
                Descricao = "Ninetales é envolto em lendas antigas. Diz-se que vive por centenas de anos e possui poderes místicos, além de grande inteligência estratégica.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/38.png"
            };

            vulpix.Evolucoes = new List<Pokemon>
            {
                vulpix,
                ninetales
            };

            ninetales.Evolucoes = new List<Pokemon>
            {
                vulpix,
                ninetales
            };

            var jigglypuff = new Pokemon
            {
                Nome = "Jigglypuff",
                Tipo = "Normal / Fada",
                Descricao = "Jigglypuff usa sua voz melodiosa para cantar canções que fazem qualquer um adormecer. Inflando seu corpo, pode aumentar o alcance do som.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png"
            };

            var wigglypuff = new Pokemon
            {
                Nome = "Wigglypuff",
                Tipo = "Normal / Fada",
                Descricao = "Wigglytuff tem corpo macio e elástico. Ao inspirar profundamente, pode inflar-se várias vezes seu tamanho para intimidar adversários.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/40.png"
            };

            jigglypuff.Evolucoes = new List<Pokemon>
            {
                jigglypuff,
                wigglypuff
            };

            wigglypuff.Evolucoes = new List<Pokemon>
            {
                jigglypuff,
                wigglypuff
            };

            var zubat = new Pokemon
            {
                Nome = "Zubat",
                Tipo = "Veneno / Voador",
                Descricao = "Zubat vive em cavernas escuras e usa ecolocalização para se orientar, já que seus olhos não são adaptados à luz intensa.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png"
            };

            var golbat = new Pokemon
            {
                Nome = "Golbat",
                Tipo = "Veneno / Voador",
                Descricao = "Golbat possui presas afiadas que perfuram facilmente a pele de suas presas. Pode sugar tanto sangue que chega a ficar pesado demais para voar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/42.png"
            };

            zubat.Evolucoes = new List<Pokemon>
            {
                zubat,
                golbat
            };

            golbat.Evolucoes = new List<Pokemon>
            {
                zubat,
                golbat
            };

            var oddish = new Pokemon
            {
                Nome = "Oddish",
                Tipo = "Grama / Veneno",
                Descricao = "Oddish passa o dia enterrado no solo, deixando apenas as folhas para fora enquanto absorve nutrientes da terra. À noite, ele sai para caminhar e espalhar sementes. Diz-se que quanto mais fértil o solo, mais brilhantes ficam suas folhas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/43.png"
            };

            var gloom = new Pokemon
            {
                Nome = "Gloom",
                Tipo = "Grama / Veneno",
                Descricao = "Gloom libera um aroma forte que pode tanto atrair presas quanto afastar inimigos. O líquido que escorre de sua boca não é saliva comum, mas um néctar adocicado usado para capturar pequenos Pokémon e insetos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/44.png"
            };

            var vileplume = new Pokemon
            {
                Nome = "Vileplume",
                Tipo = "Grama / Veneno",
                Descricao = "Vileplume possui pétalas enormes e pesadas que espalham pólen tóxico ao serem agitadas. Quanto maiores as pétalas, mais venenoso é o pó liberado, tornando-o perigoso em ambientes fechados.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/45.png"
            };

            oddish.Evolucoes = new List<Pokemon>
            {
                oddish,
                gloom,
                vileplume
            };

            gloom.Evolucoes = new List<Pokemon>
            {
                oddish,
                gloom,
                vileplume
            };

            vileplume.Evolucoes = new List<Pokemon>
            {
                oddish,
                gloom,
                vileplume
            };

            var paras = new Pokemon
            {
                Nome = "Paras",
                Tipo = "Inseto / Grama",
                Descricao = "Paras tem cogumelos parasitas crescendo em suas costas, que absorvem nutrientes do inseto hospedeiro. Ele vive em locais úmidos e sombrios, onde os fungos podem se desenvolver com facilidade.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/46.png"
            };

            var parasect = new Pokemon
            {
                Nome = "Parasect",
                Tipo = "Inseto / Grama",
                Descricao = "Em Parasect, o cogumelo já tomou controle total do corpo do inseto. A criatura passa a agir conforme a vontade do fungo, espalhando esporos tóxicos pelo ambiente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/47.png"
            };

            paras.Evolucoes = new List<Pokemon>
            {
                paras,
                parasect
            };

            parasect.Evolucoes = new List<Pokemon>
            {
                paras,
                parasect
            };

            var venonat = new Pokemon
            {
                Nome = "Venonat",
                Tipo = "Inseto / Veneno",
                Descricao = "Venonat possui olhos grandes que funcionam como sensores noturnos, permitindo enxergar mesmo na escuridão total. Seu corpo é coberto por pelos que repelem ataques leves.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/48.png"
            };

            var venomoth = new Pokemon
            {
                Nome = "Venomoth",
                Tipo = "Inseto / Veneno",
                Descricao = "Venomoth libera escamas microscópicas de suas asas que podem causar paralisia ou envenenamento. Ele costuma voar silenciosamente à noite, atraído por luzes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/49.png"
            };

            venonat.Evolucoes = new List<Pokemon>
            {
                venonat,
                venomoth
            };

            venomoth.Evolucoes = new List<Pokemon>
            {
                venonat,
                venomoth
            };

            var digglet = new Pokemon
            {
                Nome = "Diglett",
                Tipo = "Terra",
                Descricao = "Diglett vive cerca de um metro abaixo da superfície. Seu corpo permanece quase sempre escondido, e poucos sabem qual é sua aparência completa. Ele cava túneis que deixam o solo fértil.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/50.png"
            };

            var dugtrio = new Pokemon
            {
                Nome = "Dugtrio",
                Tipo = "Terra",
                Descricao = "Dugtrio é formado por três Diglett que trabalham em perfeita harmonia. Ao cavar juntos, conseguem causar tremores leves no solo, confundindo adversários e facilitando ataques surpresa.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/51.png"
            };

            digglet.Evolucoes = new List<Pokemon>
            {
                digglet,
                dugtrio
            };

            dugtrio.Evolucoes = new List<Pokemon>
            {
                digglet,
                dugtrio
            };

            var meowth = new Pokemon
            {
                Nome = "Meowth",
                Tipo = "Normal",
                Descricao = "Meowth é conhecido por sua obsessão por objetos brilhantes, especialmente moedas. Costuma sair à noite para procurar itens reluzentes pelas ruas. É ágil, inteligente e usa suas garras afiadas tanto para escalar quanto para se defender.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/52.png"
            };

            var persian = new Pokemon
            {
                Nome = "Persian",
                Tipo = "Normal",
                Descricao = "Persian possui postura elegante e movimentos graciosos. Apesar da aparência refinada, pode tornar-se extremamente agressivo se provocado. Seu corpo ágil permite ataques rápidos e precisos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/53.png"
            };

            meowth.Evolucoes = new List<Pokemon>
            {
                meowth,
                persian
            };

            persian.Evolucoes = new List<Pokemon>
            {
                meowth,
                persian
            };

            var psyduck = new Pokemon
            {
                Nome = "Psyduck",
                Tipo = "Água",
                Descricao = "Psyduck sofre constantemente com dores de cabeça intensas. Quando a dor atinge o ápice, libera uma poderosa energia psíquica sem controle, muitas vezes surpreendendo adversários e até a si mesmo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png"
            };

            var golduck = new Pokemon
            {
                Nome = "Golduck",
                Tipo = "Água",
                Descricao = "Golduck é um nadador extremamente habilidoso, capaz de atravessar lagos e rios com facilidade. Diz-se que sua testa brilha quando usa habilidades psíquicas durante batalhas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png"
            };

            psyduck.Evolucoes = new List<Pokemon>
            {
                psyduck,
                golduck
            };

            golduck.Evolucoes = new List<Pokemon>
            {
                psyduck,
                golduck
            };

            var mankey = new Pokemon
            {
                Nome = "Mankey",
                Tipo = "Lutador",
                Descricao = "Mankey tem temperamento explosivo e fica irritado com facilidade. Sua energia constante o mantém sempre ativo, pulando entre árvores e iniciando brigas por qualquer motivo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png"
            };

            var primeape = new Pokemon
            {
                Nome = "Primeape",
                Tipo = "Lutador",
                Descricao = "Primeape é ainda mais agressivo que sua forma anterior. Quando entra em fúria, pode perseguir seu alvo incansavelmente, ignorando cansaço ou dor.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png"
            };

            mankey.Evolucoes = new List<Pokemon>
            {
                mankey,
                primeape
            };

            var growlithe = new Pokemon
            {
                Nome = "Growlithe",
                Tipo = "Fogo",
                Descricao = "Growlithe é leal e corajoso. Costuma proteger seu treinador ou território com bravura, mesmo diante de oponentes maiores. Seu olfato é extremamente apurado.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png"
            };

            var arcanine = new Pokemon
            {
                Nome = "Arcanine",
                Tipo = "Fogo",
                Descricao = "Arcanine é admirado por sua velocidade impressionante e porte majestoso. Lendas afirmam que ele corre milhares de quilômetros em apenas um dia.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png"
            };

            growlithe.Evolucoes = new List<Pokemon>
            {
                growlithe,
                arcanine
            };

            arcanine.Evolucoes = new List<Pokemon>
            {
                growlithe,
                arcanine
            };

            var poliwag = new Pokemon
            {
                Nome = "Poliwag",
                Tipo = "Água",
                Descricao = "Poliwag possui uma espiral visível em seu ventre, que na verdade são seus órgãos internos vistos através da pele fina. É excelente nadador, preferindo ambientes aquáticos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png"
            };

            var poliwhirl = new Pokemon
            {
                Nome = "Poliwhirl",
                Tipo = "Água",
                Descricao = "Poliwhirl pode viver tanto na água quanto em terra firme. Sua pele sempre úmida o ajuda a respirar fora d’água por períodos prolongados.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png"
            };

            var poliwrath = new Pokemon
            {
                Nome = "Poliwrath",
                Tipo = "Água / Lutador",
                Descricao = "Poliwrath possui músculos extremamente desenvolvidos. Mesmo em águas agitadas, consegue nadar com força e resistência notáveis.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png"
            };

            poliwag.Evolucoes = new List<Pokemon>
            {
                poliwag,
                poliwhirl,
                poliwrath
            };

            poliwhirl.Evolucoes = new List<Pokemon>
            {
                poliwag,
                poliwhirl,
                poliwrath
            };

            poliwrath.Evolucoes = new List<Pokemon>
            {
                poliwag,
                poliwhirl,
                poliwrath
            };

            var abra = new Pokemon
            {
                Nome = "Abra",
                Tipo = "Psíquico",
                Descricao = "Abra dorme cerca de 18 horas por dia. Mesmo enquanto dorme, mantém a habilidade de se teletransportar automaticamente ao sentir perigo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png"
            };

            var kadabra = new Pokemon
            {
                Nome = "Kadabra",
                Tipo = "Psíquico",
                Descricao = "Kadabra emite ondas cerebrais especiais que podem causar dores de cabeça em quem estiver por perto. Diz-se que seus poderes psíquicos aumentaram após sua evolução.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png"
            };

            var alakazam = new Pokemon
            {
                Nome = "Alakazam",
                Tipo = "Psíquico",
                Descricao = "Alakazam possui inteligência extraordinária e memória impecável. Seus poderes psíquicos são tão avançados que pode dobrar colheres apenas com a mente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png"
            };

            abra.Evolucoes = new List<Pokemon>
            {
                abra,
                kadabra,
                alakazam
            };

            kadabra.Evolucoes = new List<Pokemon>
            {
                abra,
                kadabra,
                alakazam
            };

            alakazam.Evolucoes = new List<Pokemon>
            {
                abra,
                kadabra,
                alakazam
            };

            var machop = new Pokemon
            {
                Nome = "Machop",
                Tipo = "Lutador",
                Descricao = "Machop treina constantemente para fortalecer seus músculos. Apesar do tamanho, é capaz de levantar objetos muito mais pesados que ele.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png"
            };

            var machoke = new Pokemon
            {
                Nome = "Machoke",
                Tipo = "Lutador",
                Descricao = "Machoke usa um cinto especial para controlar sua força. Sem ele, poderia destruir objetos ao redor acidentalmente devido ao excesso de poder.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png"
            };

            var machamp = new Pokemon
            {
                Nome = "Machamp",
                Tipo = "Lutador",
                Descricao = "Machamp possui quatro braços extremamente fortes. Pode lançar múltiplos golpes em alta velocidade, tornando-o formidável em combate corpo a corpo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png"
            };

            machop.Evolucoes = new List<Pokemon>
            {
                machop,
                machoke,
                machamp
            };

            machoke.Evolucoes = new List<Pokemon>
            {
                machop,
                machoke,
                machamp
            };

            machamp.Evolucoes = new List<Pokemon>
            {
                machop,
                machoke,
                machamp
            };

            var bellsprout = new Pokemon
            {
                Nome = "Bellsprout",
                Tipo = "Grama / Veneno",
                Descricao = "Bellsprout tem corpo flexível que se curva facilmente para evitar ataques. Usa suas vinhas finas para capturar presas rapidamente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png"
            };

            var weerpinbell = new Pokemon
            {
                Nome = "Weepinbell",
                Tipo = "Grama / Veneno",
                Descricao = "Weepinbell atrai presas com um aroma doce. Quando a vítima se aproxima, fecha suas mandíbulas semelhantes a folhas e inicia a digestão.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png"
            };

            var victreebel = new Pokemon
            {
                Nome = "Victreebel",
                Tipo = "Grama / Veneno",
                Descricao = "Victreebel é conhecido por viver em florestas densas, onde se esconde entre as plantas. Seu néctar tem cheiro agradável, mas serve para capturar presas desavisadas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png"
            };

            bellsprout.Evolucoes = new List<Pokemon>
            {
                bellsprout,
                weerpinbell,
                victreebel
            };

            weerpinbell.Evolucoes = new List<Pokemon>
            {
                bellsprout,
                weerpinbell,
                victreebel
            };

            victreebel.Evolucoes = new List<Pokemon>
            {
                bellsprout,
                weerpinbell,
                victreebel
            };

            var tentacool = new Pokemon
            {
                Nome = "Tentacool",
                Tipo = "Água / Veneno",
                Descricao = "",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png"
            };

            var tentacruel = new Pokemon
            {
                Nome = "Tentacruel",
                Tipo = "Água / Veneno",
                Descricao = "",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png"
            };

            tentacool.Evolucoes = new List<Pokemon>
            {
                tentacool,
                tentacruel
            };

            tentacruel.Evolucoes = new List<Pokemon>
            {
                tentacool,
                tentacruel
            };

            var geodude = new Pokemon
            {
                Nome = "Geodude",
                Tipo = "Pedra / Terra",
                Descricao = "Geodude é frequentemente encontrado em montanhas e cavernas. Apesar da aparência rochosa simples, possui braços fortes que usa para escalar e se defender.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png"
            };

            var graveler = new Pokemon
            {
                Nome = "Graveler",
                Tipo = "Pedra / Terra",
                Descricao = "Graveler se locomove rolando por encostas íngremes. Durante a descida, pode destruir tudo em seu caminho devido ao seu peso e resistência.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png"
            };

            var golem = new Pokemon
            {
                Nome = "Golem",
                Tipo = "Pedra / Terra",
                Descricao = "Golem tem corpo extremamente resistente, capaz de suportar explosões. Sua carapaça rochosa o protege de danos severos em batalhas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png"
            };

            geodude.Evolucoes = new List<Pokemon>
            {
                geodude,
                graveler,
                golem
            };

            graveler.Evolucoes = new List<Pokemon>
            {
                geodude,
                graveler,
                golem
            };

            golem.Evolucoes = new List<Pokemon>
            {
                geodude,
                graveler,
                golem
            };

            var ponyta = new Pokemon
            {
                Nome = "Ponyta",
                Tipo = "Fogo",
                Descricao = "Ponyta nasce com chamas fracas que se fortalecem com o tempo. Pode correr em alta velocidade, e seu fogo não machuca aqueles em quem confia.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png"
            };

            var rapidash = new Pokemon
            {
                Nome = "Rapidash",
                Tipo = "Fogo",
                Descricao = "Rapidash atinge velocidades impressionantes em poucos segundos. Suas crinas flamejantes ondulam enquanto corre, criando um espetáculo de fogo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png"
            };

            ponyta.Evolucoes = new List<Pokemon>
            {
                ponyta,
                rapidash
            };

            rapidash.Evolucoes = new List<Pokemon>
            {
                ponyta,
                rapidash
            };

            var slowpoke = new Pokemon
            {
                Nome = "Slowpoke",
                Tipo = "Água / Psíquico",
                Descricao = "Slowpoke é extremamente tranquilo e lento. Às vezes leva vários segundos para reagir a estímulos, mas sua cauda é considerada saborosa por outros Pokémon.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png"
            };

            var slowbro = new Pokemon
            {
                Nome = "Slowbro",
                Tipo = "Água / Psíquico",
                Descricao = "Slowbro surge quando um Shellder se prende à cauda de Slowpoke. Essa união desperta maior inteligência e habilidades defensivas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png"
            };

            slowpoke.Evolucoes = new List<Pokemon>
            {
                slowpoke,
                slowbro
            };

            slowbro.Evolucoes = new List<Pokemon>
            {
                slowpoke,
                slowbro
            };

            var magnemite = new Pokemon
            {
                Nome = "Magnemite",
                Tipo = "Elétrico / Aço",
                Descricao = "Magnemite flutua usando forças magnéticas e pode interferir em dispositivos elétricos próximos. Costuma aparecer em áreas industriais.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png"
            };

            var magneton = new Pokemon
            {
                Nome = "Magneton",
                Tipo = "Elétrico / Aço",
                Descricao = "Magneton é formado por três Magnemite unidos magneticamente. Sua energia combinada gera campos eletromagnéticos poderosos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png"
            };

            var farfetchd = new Pokemon
            {
                Nome = "Farfetch'd",
                Tipo = "Normal / Voador",
                Descricao = "Farfetch'd carrega sempre um talo de alho-poró, que usa como arma e também como alimento. É habilidoso em combates rápidos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/83.png"
            };

            farfetchd.Evolucoes = new List<Pokemon>
            {
                farfetchd
            };

            var duduo = new Pokemon
            {
                Nome = "Doduo",
                Tipo = "Normal / Voador",
                Descricao = "Doduo possui duas cabeças que raramente dormem ao mesmo tempo, garantindo vigilância constante contra ameaças.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png"
            };

            var dodrio = new Pokemon
            {
                Nome = "Dodrio",
                Tipo = "Normal / Voador",
                Descricao = "Dodrio evolui com três cabeças, representando diferentes emoções. Sua velocidade terrestre é extraordinária.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png"
            };

            duduo.Evolucoes = new List<Pokemon>
            {
                duduo,
                dodrio
            };

            dodrio.Evolucoes = new List<Pokemon>
            {
                duduo,
                dodrio
            };

            var seel = new Pokemon
            {
                Nome = "Seel",
                Tipo = "Água",
                Descricao = "Seel vive em águas frias e possui espessa camada de gordura que o protege de temperaturas baixas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png"
            };

            var dewgong = new Pokemon
            {
                Nome = "Dewgong",
                Tipo = "Água / Gelo",
                Descricao = "Dewgong nada elegantemente em mares gelados. Seu corpo branco o ajuda a se camuflar no ambiente ártico.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png"
            };

            seel.Evolucoes = new List<Pokemon>
            {
                seel,
                dewgong
            };

            dewgong.Evolucoes = new List<Pokemon>
            {
                seel,
                dewgong
            };

            var grimer = new Pokemon
            {
                Nome = "Grimer",
                Tipo = "Veneno",
                Descricao = "Grimer surge de resíduos tóxicos acumulados. Seu corpo viscoso pode poluir o ambiente por onde passa.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png"
            };

            var muk = new Pokemon
            {
                Nome = "Muk",
                Tipo = "Veneno",
                Descricao = "Muk exala odor extremamente forte e tóxico. Prefere viver em locais poluídos, onde encontra seu alimento.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png"
            };

            grimer.Evolucoes = new List<Pokemon>
            {
                grimer,
                muk
            };

            muk.Evolucoes = new List<Pokemon>
            {
                grimer,
                muk
            };

            var shelder = new Pokemon
            {
                Nome = "Shellder",
                Tipo = "Água",
                Descricao = "Shellder possui concha dura que se fecha rapidamente para proteção. Usa sua língua longa para agarrar presas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png"
            };

            var cloyster = new Pokemon
            {
                Nome = "Cloyster",
                Tipo = "Água / Gelo",
                Descricao = "Cloyster tem concha pontiaguda e extremamente resistente. Pode disparar jatos de água gelada com grande precisão.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png"
            };

            shelder.Evolucoes = new List<Pokemon>
            {
                shelder,
                cloyster
            };

            cloyster.Evolucoes = new List<Pokemon>
            {
                shelder,
                cloyster
            };

            var gastly = new Pokemon
            {
                Nome = "Gastly",
                Tipo = "Fantasma / Veneno",
                Descricao = "Gastly é composto quase totalmente por gás venenoso. Ele envolve suas presas com essa névoa tóxica para enfraquecê-las lentamente. Em ambientes escuros, pode aparecer de forma súbita, assustando quem estiver por perto.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png"
            };

            var haunter = new Pokemon
            {
                Nome = "Haunter",
                Tipo = "Fantasma / Veneno",
                Descricao = "Haunter gosta de pregar peças e assustar pessoas. Diz-se que ele pode atravessar paredes e tocar alguém apenas para provocar arrepios intensos e sensação de frio extremo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png"
            };

            var gengar = new Pokemon
            {
                Nome = "Gengar",
                Tipo = "Fantasma / Veneno",
                Descricao = "Gengar se esconde nas sombras e imita a silhueta das pessoas para assustá-las. Em noites escuras, pode surgir silenciosamente atrás de alguém, absorvendo calor corporal para diminuir a temperatura do ambiente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png"
            };

            gastly.Evolucoes = new List<Pokemon>
            {
                gastly,
                haunter,
                gengar
            };

            haunter.Evolucoes = new List<Pokemon>
            {
                gastly,
                haunter,
                gengar
            };

            gengar.Evolucoes = new List<Pokemon>
            {
                gastly,
                haunter,
                gengar
            };

            var onix = new Pokemon
            {
                Nome = "Onix",
                Tipo = "Pedra / Terra",
                Descricao = "Onix vive em túneis subterrâneos que ele mesmo escava. Seu corpo rochoso cresce à medida que cava, tornando-se cada vez mais duro e resistente com o tempo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png"
            };

            onix.Evolucoes = new List<Pokemon>
            {
                onix
            };

            var drowzee = new Pokemon
            {
                Nome = "Drowzee",
                Tipo = "Psíquico",
                Descricao = "Drowzee se alimenta de sonhos, especialmente os agradáveis. Ele é capaz de hipnotizar suas presas para induzi-las ao sono e então consumir suas experiências oníricas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png"
            };

            var hypno = new Pokemon
            {
                Nome = "Hypno",
                Tipo = "Psíquico",
                Descricao = "Hypno utiliza um pêndulo para controlar o ritmo de seus poderes hipnóticos. Há relatos de que ele pode manter alguém adormecido por longos períodos se desejar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png"
            };

            drowzee.Evolucoes = new List<Pokemon>
            {
                drowzee,
                hypno
            };

            hypno.Evolucoes = new List<Pokemon>
            {
                drowzee,
                hypno
            };

            var krabby = new Pokemon
            {
                Nome = "Krabby",
                Tipo = "Água",
                Descricao = "Krabby possui pinças poderosas que crescem novamente caso sejam perdidas. Ele se esconde na areia da praia, aguardando o momento certo para atacar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png"
            };

            var kingler = new Pokemon
            {
                Nome = "Kingler",
                Tipo = "Água",
                Descricao = "Kingler tem uma pinça extremamente grande e forte, capaz de esmagar conchas duras. No entanto, seu tamanho desigual pode dificultar o equilíbrio.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png"
            };

            krabby.Evolucoes = new List<Pokemon>
            {
                krabby,
                kingler
            };

            kingler.Evolucoes = new List<Pokemon>
            {
                krabby,
                kingler
            };

            var voltorb = new Pokemon
            {
                Nome = "Voltorb",
                Tipo = "Elétrico",
                Descricao = "Voltorb é frequentemente confundido com uma Poké Bola. Ele pode explodir subitamente ao sentir perigo ou irritação.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png"
            };

            var electrode = new Pokemon
            {
                Nome = "Electrode",
                Tipo = "Elétrico",
                Descricao = "Electrode armazena enorme quantidade de energia elétrica. Quando sobrecarregado, pode detonar com força impressionante.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png"
            };

            voltorb.Evolucoes = new List<Pokemon>
            {
                voltorb,
                electrode
            };

            electrode.Evolucoes = new List<Pokemon>
            {
                voltorb,
                electrode
            };

            var exeggcute = new Pokemon
            {
                Nome = "Exeggcute",
                Tipo = "Grama / Psíquico",
                Descricao = "Exeggcute consiste em seis “ovos” que compartilham consciência coletiva. Mesmo que alguns se quebrem, o grupo continua ativo enquanto houver membros suficientes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png"
            };

            var exeggutor = new Pokemon
            {
                Nome = "Exeggutor",
                Tipo = "Grama / Psíquico",
                Descricao = "Exeggutor possui múltiplas cabeças que parecem agir independentemente, mas compartilham a mesma mente. Ele prospera em regiões tropicais.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png"
            };

            exeggcute.Evolucoes = new List<Pokemon>
            {
                exeggcute,
                exeggutor
            };

            exeggutor.Evolucoes = new List<Pokemon>
            {
                exeggcute,
                exeggutor
            };

            var cubone = new Pokemon
            {
                Nome = "Cubone",
                Tipo = "Terra",
                Descricao = "Cubone usa o crânio de sua mãe falecida como capacete. Seu choro solitário ecoa sob a lua cheia, revelando sua natureza melancólica.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png"
            };

            var marowak = new Pokemon
            {
                Nome = "Marowak",
                Tipo = "Terra",
                Descricao = "Marowak tornou-se mais forte após superar sua tristeza. Ele utiliza ossos como armas, arremessando-os com grande precisão.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png"
            };

            cubone.Evolucoes = new List<Pokemon>
            {
                cubone,
                marowak
            };

            marowak.Evolucoes = new List<Pokemon>
            {
                cubone,
                marowak
            };

            var hitmonlee = new Pokemon
            {
                Nome = "Hitmonlee",
                Tipo = "Lutador",
                Descricao = "Hitmonlee possui pernas elásticas que se estendem para desferir chutes devastadores. Sua especialidade é o combate baseado em ataques rápidos com os pés.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png"
            };

            hitmonlee.Evolucoes = new List<Pokemon>
            {
                hitmonlee
            };

            var hitmonchan = new Pokemon
            {
                Nome = "Hitmonchan",
                Tipo = "Lutador",
                Descricao = "Hitmonchan luta utilizando técnicas de boxe. Seus socos são tão velozes que quase não podem ser vistos a olho nu.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png"
            };

            hitmonchan.Evolucoes = new List<Pokemon>
            {
                hitmonchan
            };

            var licktung = new Pokemon
            {
                Nome = "Lickitung",
                Tipo = "Normal",
                Descricao = "Lickitung possui língua extremamente longa e pegajosa, usada tanto para capturar alimento quanto para explorar o ambiente ao redor.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png"
            };

            licktung.Evolucoes = new List<Pokemon>
            {
                licktung
            };

            var koffing = new Pokemon
            {
                Nome = "Koffing",
                Tipo = "Veneno",
                Descricao = "Koffing flutua enquanto libera gases tóxicos. Ele se torna instável quando acumula excesso de veneno dentro do corpo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png"
            };

            var weezing = new Pokemon
            {
                Nome = "Weezing",
                Tipo = "Veneno",
                Descricao = "Weezing é formado por dois Koffing unidos. Cada cabeça pode liberar diferentes tipos de gases venenosos simultaneamente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png"
            };

            koffing.Evolucoes = new List<Pokemon>
            {
                koffing,
                weezing
            };

            weezing.Evolucoes = new List<Pokemon>
            {
                koffing,
                weezing
            };

            var rhyhorn = new Pokemon
            {
                Nome = "Rhyhorn",
                Tipo = "Terra / Pedra",
                Descricao = "Rhyhorn é conhecido por sua força bruta e investidas diretas. Mesmo que bata contra algo sólido, raramente sente dor significativa.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png"
            };

            var rhydon = new Pokemon
            {
                Nome = "Rhydon",
                Tipo = "Terra / Pedra",
                Descricao = "Sua pele espessa funciona como uma armadura natural capaz de suportar impactos intensos e até mesmo lava vulcânica. Ele utiliza seu chifre como uma broca poderosa para destruir rochas e abrir caminho em terrenos montanhosos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png"
            };

            rhyhorn.Evolucoes = new List<Pokemon>
            {
                rhyhorn,
                rhydon
            };

            rhydon.Evolucoes = new List<Pokemon>
            {
                rhyhorn,
                rhydon
            };

            var chansey = new Pokemon
            {
                Nome = "Chansey",
                Tipo = "Normal",
                Descricao = "Extremamente gentil e raro na natureza, carrega um ovo altamente nutritivo que compartilha com Pokémon ou pessoas feridas. Dizem que sua presença traz felicidade e cura para quem está ao seu redor.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png"
            };

            chansey.Evolucoes = new List<Pokemon>
            {
                chansey
            };

            var tangela = new Pokemon
            {
                Nome = "Tangela",
                Tipo = "Grama",
                Descricao = "Seu corpo é completamente envolvido por vinhas azuis que se movem constantemente. Se uma vinha é arrancada, outra cresce rapidamente. Seu verdadeiro corpo raramente é visto.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png"
            };

            tangela.Evolucoes = new List<Pokemon>
            {
                tangela
            };

            var kangaskhan = new Pokemon
            {
                Nome = "Kangaskhan",
                Tipo = "Normal",
                Descricao = "Protege seu filhote, que permanece em sua bolsa, com ferocidade impressionante. Se ameaçado, ataca com golpes rápidos e poderosos, demonstrando grande força e instinto maternal.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png"
            };

            kangaskhan.Evolucoes = new List<Pokemon>
            {
                kangaskhan
            };

            var horsea = new Pokemon
            {
                Nome = "Horsea",
                Tipo = "Água",
                Descricao = "Vive em mares calmos e dispara jatos de tinta ou água com precisão incrível para se defender. Alimenta-se de pequenos insetos e plânctons marinhos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png"
            };

            var seadra = new Pokemon
            {
                Nome = "Seadra",
                Tipo = "Água",
                Descricao = "Nada de costas para frente e usa sua cauda espinhosa como arma. Armazena veneno em seus espinhos e pode disparar projéteis aquáticos extremamente potentes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png"
            };

            horsea.Evolucoes = new List<Pokemon>
            {
                horsea,
                seadra
            };

            seadra.Evolucoes = new List<Pokemon>
            {
                horsea,
                seadra
            };

            var goldeen = new Pokemon
            {
                Nome = "Goldeen",
                Tipo = "Água",
                Descricao = "Conhecido como o “Pokémon Rainha da Água”, nada graciosamente como um peixe dourado ornamental. Seus chifres afiados servem tanto para defesa quanto para disputa territorial.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png"
            };

            var seaking = new Pokemon
            {
                Nome = "Seaking",
                Tipo = "Água",
                Descricao = "Nada contra correntes fortes durante a época de desova, demonstrando grande resistência. Seu chifre pode quebrar pedras e até perfurar estruturas sólidas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png"
            };

            goldeen.Evolucoes = new List<Pokemon>
            {
                goldeen,
                seaking
            };

            seaking.Evolucoes = new List<Pokemon>
            {
                goldeen,
                seaking
            };

            var staryu = new Pokemon
            {
                Nome = "Staryu",
                Tipo = "Água",
                Descricao = "Possui uma joia vermelha no centro do corpo que brilha intensamente quando está saudável. Pode regenerar partes do corpo se sofrer danos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png"
            };

            var starmie = new Pokemon
            {
                Nome = "Starmie",
                Tipo = "Água / Psíquico",
                Descricao = "Sua joia central emite sinais misteriosos e cintila nas cores do arco-íris. Movimenta-se girando rapidamente, criando ataques aquáticos devastadores.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png"
            };

            staryu.Evolucoes = new List<Pokemon>
            {
                staryu,
                starmie
            };

            starmie.Evolucoes = new List<Pokemon>
            {
                staryu,
                starmie
            };

            var mrMime = new Pokemon
            {
                Nome = "Mr. Mime",
                Tipo = "Psíquico / Fada",
                Descricao = "Especialista em criar barreiras invisíveis através de gestos e mímica. Seus movimentos confundem adversários e transformam batalhas em verdadeiros espetáculos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/122.png"
            };

            mrMime.Evolucoes = new List<Pokemon>
            {
                mrMime
            };

            var scyther = new Pokemon
            {
                Nome = "Scyther",
                Tipo = "Inseto / Voador",
                Descricao = "Extremamente veloz, move-se tão rápido que parece haver múltiplos ao mesmo tempo. Suas lâminas afiadas podem cortar árvores grossas com um único golpe.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png"
            };

            scyther.Evolucoes = new List<Pokemon>
            {
                scyther
            };

            var jynx = new Pokemon
            {
                Nome = "Jynx",
                Tipo = "Gelo / Psíquico",
                Descricao = "Utiliza movimentos semelhantes a uma dança para confundir o oponente. Sua voz melodiosa pode induzir o sono em quem a escuta por muito tempo.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png"
            };

            jynx.Evolucoes = new List<Pokemon>
            {
                jynx
            };

            var electabuzz = new Pokemon
            {
                Nome = "Electabuzz",
                Tipo = "Elétrico",
                Descricao = "Gera energia elétrica naturalmente e pode causar apagões inteiros se liberar todo seu poder. É frequentemente encontrado próximo a usinas de energia.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png"
            };

            electabuzz.Evolucoes = new List<Pokemon>
            {
                electabuzz
            };

            var magmar = new Pokemon
            {
                Nome = "Magmar",
                Tipo = "Fogo",
                Descricao = "Vive em crateras vulcânicas e possui corpo extremamente quente. Sua respiração libera ondas de calor capazes de derreter metal.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png"
            };

            magmar.Evolucoes = new List<Pokemon>
            {
                magmar
            };

            var pinsir = new Pokemon
            {
                Nome = "Pinsir",
                Tipo = "Inseto",
                Descricao = "Usa seus grandes chifres para agarrar e esmagar adversários. Se não consegue partir algo com a força, lança o inimigo ao chão repetidamente.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png"
            };

            pinsir.Evolucoes = new List<Pokemon>
            {
                pinsir
            };

            var tauros = new Pokemon
            {
                Nome = "Tauros",
                Tipo = "Normal",
                Descricao = "Conhecido por sua natureza agressiva, investe repetidamente contra oponentes. Chicoteia o próprio corpo com as caudas antes de atacar, aumentando sua determinação.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png"
            };

            tauros.Evolucoes = new List<Pokemon>
            {
                tauros
            };

            var magikarp = new Pokemon
                {
                    Nome = "Magikarp",
                    Tipo = "Água",
                    Descricao = "Apesar de parecer fraco e inútil, é incrivelmente resistente. Consegue sobreviver em águas extremamente poluídas e saltar grandes alturas.",
                    Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png"
                };

           var gyarados = new Pokemon
            {
                Nome = "Gyarados",
                Tipo = "Água / Voador",
                Descricao = "Quando enfurecido, destrói tudo em seu caminho. Sua força colossal é resultado de uma evolução dramática que transforma fraqueza em poder devastador.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png"
            };

            magikarp.Evolucoes = new List<Pokemon>
            {
                magikarp,
                gyarados
            };

            gyarados.Evolucoes = new List<Pokemon>
            {
                magikarp,
                gyarados
            };

            var lapras = new Pokemon
            {
                Nome = "Lapras",
                Tipo = "Água / Gelo",
                Descricao = "Gentil e inteligente, transporta pessoas sobre o mar. Seu canto melodioso ecoa pelas águas, especialmente nas noites tranquilas." +
                "",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png"
            };

            lapras.Evolucoes = new List<Pokemon>
            {
                lapras
            };

            var ditto = new Pokemon
            {
                Nome = "Ditto",
                Tipo = "Normal",
                Descricao = "Tem a habilidade única de transformar completamente seu corpo para assumir a forma de qualquer outro Pokémon que veja. No entanto, se tentar copiar algo de memória, pode acabar errando alguns detalhes.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png"
            };

            ditto.Evolucoes = new List<Pokemon>
            {
                ditto
            };

            var eevee = new Pokemon
            {
                Nome = "Eevee",
                Tipo = "Normal",
                Descricao = "Possui um código genético instável que lhe permite evoluir para diferentes formas dependendo das condições e estímulos que recebe. Essa adaptabilidade faz dele um dos Pokémon mais versáteis que existem.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png"
            };

            var vaporeon = new Pokemon
            {
                Nome = "Vaporeon",
                Tipo = "Água",
                Descricao = "Seu corpo celular se assemelha à composição da água, permitindo que se dissolva em ambientes aquáticos para se esconder. Nada com extrema elegância e precisão.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png"
            };

            var joteon = new Pokemon
            {
                Nome = "Jolteon",
                Tipo = "Elétrico",
                Descricao = "Acumula eletricidade estática em seu pelo, que se enrijece como agulhas quando ameaçado. Pode descarregar milhares de volts em um único ataque.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png"
            };

            var flareon = new Pokemon
            {
                Nome = "Flareon",
                Tipo = "Fogo",
                Descricao = "Armazena calor em seu corpo e pode atingir temperaturas altíssimas. Seu pelo macio libera calor intenso quando se prepara para atacar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png"
            };

            eevee.Evolucoes = new List<Pokemon>
            {
                eevee,
                vaporeon,
                joteon,
                flareon
            };

            vaporeon.Evolucoes = new List<Pokemon>
            {
                eevee,
                vaporeon,
                joteon,
                flareon
            };
    
            joteon.Evolucoes = new List<Pokemon>
            {
                eevee,
                vaporeon,
                joteon,
                flareon
            };
    
            flareon.Evolucoes = new List<Pokemon>
            {
                eevee,
                vaporeon,
                joteon,
                flareon
            };

            var porygon = new Pokemon
            {
                Nome = "Porygon",
                Tipo = "Normal",
                Descricao = "Criado inteiramente por programação, é composto de dados digitais. Pode se mover livremente no ciberespaço, sendo um Pokémon artificial único.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png"
            };

            porygon.Evolucoes = new List<Pokemon>
            {
                porygon
            };

            var omanyte = new Pokemon
            {
                Nome = "Omanyte",
                Tipo = "Pedra / Água",
                Descricao = "Revitalizado a partir de um fóssil antigo, viveu nos mares pré-históricos. Usa seus tentáculos para capturar presas enquanto se desloca pelo fundo do oceano.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png"
            };

            var omastar = new Pokemon
            {
                Nome = "Omastar",
                Tipo = "Pedra / Água",
                Descricao = "Evolução de Omanyte, possui concha pesada e resistente. Acredita-se que foi extinto por não conseguir se mover rápido o suficiente para escapar de predadores.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png"
            };

            omanyte.Evolucoes = new List<Pokemon>
            {
                omanyte,
                omastar
            };

            omastar.Evolucoes = new List<Pokemon>
            {
                omanyte,
                omastar
            };

            var kabuto = new Pokemon
            {
                Nome = "Kabuto",
                Tipo = "Pedra / Água",
                Descricao = "Um Pokémon ancestral que viveu há milhões de anos. Sua carapaça rígida protege seu corpo enquanto ele se desloca discretamente pelo fundo marinho.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png"
            };

            var kabutops = new Pokemon
            {
                Nome = "Kabutops",
                Tipo = "Pedra / Água",
                Descricao = "Adaptado tanto à terra quanto à água, possui lâminas afiadas nos braços para cortar presas rapidamente. Seus olhos indicam natureza predatória.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png"
            };

            var aerodactyl = new Pokemon
            {
                Nome = "Aerodactyl",
                Tipo = "Pedra / Voador",
                Descricao = "Revivedo de material genético antigo, é extremamente feroz. Voava pelos céus pré-históricos e atacava com suas presas afiadas.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png"
            };

            aerodactyl.Evolucoes = new List<Pokemon>
            {
                aerodactyl
            };

            var snorlax = new Pokemon
            {
                Nome = "Snorlax",
                Tipo = "Normal",
                Descricao = "Passa a maior parte do tempo dormindo e só acorda para comer. Quando bloqueia estradas ou caminhos, é quase impossível movê-lo devido ao seu peso enorme.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png"
            };

            snorlax.Evolucoes = new List<Pokemon>
            {
                snorlax
            };

            var articuno = new Pokemon
            {
                Nome = "Articuno",
                Tipo = "Gelo / Voador",
                Descricao = "Pokémon lendário que controla o gelo. Seu bater de asas pode congelar o ar ao redor, criando tempestades de neve.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png"
            };

            articuno.Evolucoes = new List<Pokemon>
            {
                articuno
            };

            var zapdos = new Pokemon
            {
                Nome = "Zapdos",
                Tipo = "Elétrico / Voador",
                Descricao = "Um lendário pássaro elétrico que surge durante tempestades. Diz-se que ganha energia ao ser atingido por raios.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png"
            };

            zapdos.Evolucoes = new List<Pokemon>
            {
                zapdos
            };

            var moltres = new Pokemon
            {
                Nome = "Moltres",
                Tipo = "Fogo / Voador",
                Descricao = "Envolto em chamas intensas, espalha calor com o bater de suas asas. Sua aparição costuma estar associada a fenômenos vulcânicos.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png"
            };

            moltres.Evolucoes = new List<Pokemon>
            {
                moltres
            };

            var dratini = new Pokemon
            {
                Nome = "Dratini",
                Tipo = "Dragão",
                Descricao = "Vive escondido em lagos e rios. Apesar de pequeno, possui grande potencial e cresce rapidamente conforme ganha experiência.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png"
            };

            var dragonair = new Pokemon
            {
                Nome = "Dragonair",
                Tipo = "Dragão",
                Descricao = "Emite uma aura mística que altera o clima ao seu redor. Seu corpo elegante flutua suavemente no ar.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png"
            };

            var dragonite = new Pokemon
            {
                Nome = "Dragonite",
                Tipo = "Dragão / Voador",
                Descricao = "Apesar de seu tamanho e poder impressionantes, é conhecido por sua natureza gentil. Pode voar ao redor do mundo em alta velocidade.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png"
            };

            dratini.Evolucoes = new List<Pokemon>
            {
                dratini,
                dragonair,
                dragonite
            };

            dragonair.Evolucoes = new List<Pokemon>
            {
                dratini,
                dragonair,
                dragonite
            };

            dragonite.Evolucoes = new List<Pokemon>
            {
                dratini,
                dragonair,
                dragonite
            };

            var mewtwo = new Pokemon
            {
                Nome = "Mewtwo",
                Tipo = "Psíquico",
                Descricao = "Criado por manipulação genética, possui habilidades psíquicas extraordinárias. Sua força mental supera a de quase qualquer outro Pokémon.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png"
            };

            var mew = new Pokemon
            {
                Nome = "Mew",
                Tipo = "Psíquico",
                Descricao = "Considerado o ancestral de todos os Pokémon, contém o código genético de cada espécie. É extremamente raro e aparece apenas para aqueles de coração puro.",
                Imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png"
            };

            mewtwo.Evolucoes = new List<Pokemon>
            {
                mewtwo
            };

            mew.Evolucoes = new List<Pokemon>
            {
                mew
            };

            pokedex = new List<Pokemon>
            {
                bulbasaur,
                ivysaur,
                venusaur,
                charmander,
                charmaleon,
                charizard,
                squirtle,
                wartortle,
                blastoise,
                caterpie,
                metapod,
                butterfree,
                weedle,
                kakuna,
                beedrill,
                pidgey,
                pidgeotto,
                pidgeot,
                ratata,
                raticate,
                spearow,
                fearow,
                ekans,
                arbok,
                pikachu,
                raichu,
                sandshrew,
                sandslash,
                nidoranFem,
                nidorina,
                nidoqueen,
                nidoranMasc,
                nidorino,
                nidoking,
                cleafairy,
                clefable,
                vulpix,
                ninetales,
                jigglypuff,
                wigglypuff,
                zubat,
                golbat,
                oddish,
                gloom,
                vileplume,
                paras,
                parasect,
                venonat,
                venomoth,
                digglet,
                dugtrio,
                meowth,
                persian,
                psyduck,
                golduck,
                mankey,
                primeape,
                growlithe,
                arcanine,
                poliwag,
                poliwhirl,
                poliwrath,
                abra,
                kadabra,
                alakazam,
                machop,
                machoke,
                machamp,
                bellsprout,
                weerpinbell,
                victreebel,
                tentacool,
                tentacruel,
                geodude,
                graveler,
                golem,
                ponyta,
                rapidash,
                slowpoke,
                slowbro,
                magnemite,
                magneton,
                farfetchd,
                duduo,
                dodrio,
                seel,
                dewgong,
                grimer,
                muk,
                shelder,
                cloyster,
                gastly,
                haunter,
                gengar,
                onix,
                drowzee,
                hypno,
                krabby,
                kingler,
                voltorb,
                electrode,
                exeggcute,
                exeggutor,
                cubone,
                marowak,
                hitmonlee,
                hitmonchan,
                licktung,
                koffing,
                weezing,
                rhyhorn,
                rhydon,
                chansey,
                tangela,
                kangaskhan,
                horsea,
                seadra,
                goldeen,
                seaking,
                staryu,
                starmie,
                mrMime,
                scyther,
                jynx,
                electabuzz,
                magmar,
                pinsir,
                tauros,
                magikarp,
                gyarados,
                lapras,
                ditto,
                eevee,
                vaporeon,
                joteon,
                flareon,
                porygon,
                omanyte,
                omastar,
                kabuto,
                kabutops,
                aerodactyl,
                snorlax,
                articuno,
                zapdos,
                moltres,
                dratini,
                dragonair,
                dragonite,
                mewtwo,
                mew
            };
        }

        private void PokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PokemonList.SelectedItem is Pokemon pokemon)
            {
                NomeText.Text = pokemon.Nome;
                NumeroText.Text = $"#{pokemon.NumeroPokedex:D3}";
                GeracaoText.Text = $"Geração: {pokemon.Geracao}";
                TipoText.Text = $"Tipo: {pokemon.Tipo}";
                DescricaoText.Text = pokemon.Descricao;

                PokemonImage.Source = new BitmapImage(
                    new System.Uri(pokemon.Imagem, UriKind.Absolute) );

                EvolucaoList.ItemsSource = pokemon.Evolucoes;
            }
        }
    }
}