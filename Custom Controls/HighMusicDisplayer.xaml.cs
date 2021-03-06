﻿using System;
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
    /// Logique d'interaction pour HighMusicDisplayer.xaml
    /// </summary>
    public partial class HighMusicDisplayer : UserControl
    {
        public HighMusicDisplayer()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource
        {
            get
            {
                return this.AlbumsCover.Source;
            }

            set
            {
                this.AlbumsCover.Source = value;
            }

        }

        public string AlbumName
        {
            get
            {
                return this.Album.Text;
            }

            set
            {
                this.Album.Text = value;
            }

        }

        public string SongsNumber
        {
            get
            {
                return this.Songs.Text;
            }

            set
            {
                this.Songs.Text = value;
            }

        }

    }

}
