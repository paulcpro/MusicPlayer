using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicPlayer.Custom_Controls
{
    /// <summary>
    /// Logique d'interaction pour HighCircularArtist.xaml
    /// </summary>
    public partial class HighCircularArtist : UserControl
    {
        public HighCircularArtist()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource
        {
            get
            {
                return this.ArtistImage.Source;
            }

            set
            {
                this.ArtistImage.Source = value;
            }

        }

        public string ArtistName
        {
            get
            {
                return this.Artist.Text;
            }

            set
            {
                this.Artist.Text = value;
            }

        }

    }

}
