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
    /// Logique d'interaction pour MediumMusicDisplayer.xaml
    /// </summary>
    public partial class MediumMusicDisplayer : UserControl
    {
        public MediumMusicDisplayer()
        {
            InitializeComponent();
        }

        //We define the property as usual as first
        public ImageSource ImageSource
        {
            get
            {
                return MainImage.Source;    //Then we call the x:Name of the widget
            }

            set
            {
                MainImage.Source = value;
            }

        }

        public string FirstBlockText
        {
            get
            {
                return this.FirstTextBlock.Text;
            }

            set
            {
                this.FirstTextBlock.Text = value;
            }

        }

        public string SecondBlockText
        {
            get
            {
                return this.SecondTextBlock.Text;
            }

            set
            {
                this.SecondTextBlock.Text = value;
            }

        }

    }

}
