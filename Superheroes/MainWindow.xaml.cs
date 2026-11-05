using Superheroes.Services;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Superheroe> listaSuperheroes;

        public MainWindow()
        {
            InitializeComponent();

            listaSuperheroes = DataService.GetSamples(); // Obtiene la lista de superhéroes.

            // Indicamos que el origen de la información. En este caso utilizamos la propiedad "DataContext" de elemento "Window".
            this.DataContext = listaSuperheroes.FirstOrDefault();
            
            actualTextBlock.Text = "1"; // Inicializa el contador de superhéroes. Tomará valores de 1 a 3.
            
            totalTextBlock.Text = listaSuperheroes.Count.ToString(); // Número máximo de superhéroes en la lista.
        }

        private void leftImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Aquí estamos pulsando la flecha izquierda, por lo que debemos retroceder al superhéroe anterior.

            // Cálculamos el "indice" del superhéroe actual, que es el que se está mostrando en la vista.
            // Lo obtenemos del "TextBlock" que muestra el número de superhéroe actual, y vamos a tener
            // que restarle "1" ya que el índice de la lista va de 0 a 2, mientras que el número de superhéroe va de 1 a 3.
            int indice = (Int32.Parse(actualTextBlock.Text) - 1);
            

            if (indice > 0) 
            {
                // Retrocedemos al superhéroe anterior, por lo que decrementamos el índice en 1.
                indice--; 

                // Indicamos que el origen de la información. En este caso, utilizamos la propiedad "DataContext" de elemento "Window".
                this.DataContext = listaSuperheroes[indice];

                // Mostrar el número de superhéroe actual en la vista, de 1 a 3.
                actualTextBlock.Text = (indice+1).ToString();
            }
        }

        private void rightImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Aquí estamos pulsando la flecha derecha, por lo que debemos avanzar al siguiente superhéroe.

            // Cálculamos el "indice" del superhéroe actual, que es el que se está mostrando en la vista.
            // Lo obtenemos del "TextBlock" que muestra el número de superhéroe actual, y vamos a tener
            // que restarle "1" ya que el índice de la lista va de 0 a 2, mientras que el número de superhéroe va de 1 a 3.
            int indice = Int32.Parse(actualTextBlock.Text) - 1;
              
            if (indice < (listaSuperheroes.Count)-1)
            {
                // Avanzamos al siguiente superhéroe, por lo que incrementamos el índice en 1.
                indice++;

                // Indicamos que el origen de la información. En este caso utilizamos la propiedad "DataContext" de elemento "Window".
                this.DataContext = listaSuperheroes[indice];

                // Mostrar el número de superhéroe actual en la vista, de 1 a 3.
                actualTextBlock.Text = (indice+1).ToString();
            }
        }

    }
}