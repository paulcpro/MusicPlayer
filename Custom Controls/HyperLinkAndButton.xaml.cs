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
    /// Logique d'interaction pour HyperLinkAndButton.xaml
    /// </summary>
    public partial class HyperLinkAndButton : UserControl
    {
        public HyperLinkAndButton()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource
        {
            get
            {
                return Category.Source;
            }

            set
            {
                Category.Source = value;
            }

        }

        public string CategoryText
        {
            get
            {
                return HyperLink.Text;
            }

            set
            {
                HyperLink.Text = value;
            }

        }

    }

}
