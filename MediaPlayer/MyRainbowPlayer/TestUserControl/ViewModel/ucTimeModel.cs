﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows;
using System.IO;
using System.Reflection;
using System.Collections.ObjectModel;

namespace TestUserControl
{
    public class ucTimeModel : ViewModelBase
    {
        private String _path;
        public String path
        {
            get { return _path; }
            set { _path = value; OnPropertyChanged("path"); }
        }

        private MediaElement _myMedElem;
        public MediaElement myMedElem
        {
            get { return _myMedElem; }
            set { _myMedElem = value; }
        }
        public bool mediaLoaded;
        public bool pause;
        private bool fullScreen = false;
        public bool isPlay;
        DatabasePlaylist db;

        string _TextPlay;
        MediaElement MyMediaElement;

        public string TextPlay
        {
            get { return _TextPlay; }
            set
            {
                _TextPlay = value;
                OnPropertyChanged("TextPlay");
            }
        }

        public ucTimeModel()
        {
            db = null;
        }
        public ucTimeModel(DatabasePlaylist _db)
        {
            db = _db;
            mediaLoaded = false;
            pause = false;
            isPlay = false;
            TextPlay = "|>";
            PlayCommand = new DelegateCommand(doPlay, CanPlay);
            NextCommand = new DelegateCommand(doNext, CanNext);
            PrevCommand = new DelegateCommand(doPrev, CanPrev);
            ShuffleCommand = new DelegateCommand(doShuffle, CanShuffle);
            StopCommand = new DelegateCommand(doStop, CanStop);
            RepeatCommand = new DelegateCommand(doRepeat, CanRepeat);
        }

        public ICommand Fullscreen
        { get; set; }

        public bool CanFullscreen()
        {
            return true;
        }

        public void setTimer()
        {
            DTimer = new DispatcherTimer(DispatcherPriority.Background, myMedElem.Dispatcher);
            DTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            DTimer.Tick += new EventHandler(DTimer_Tick);
            DTimer.Start();
            this.myMedElem.MediaOpened += new RoutedEventHandler(myMedOpened);
            this.myMedElem.MediaEnded += new RoutedEventHandler(myMedNext);
        }
        public ICommand PlayCommand
        { get; set; }
        public ICommand StopCommand
        { get; set; }
        public ICommand RepeatCommand
        { get; set; }
        public ICommand ShuffleCommand
        { get; set; }
        public ICommand PrevCommand
        { get; set; }
        public ICommand NextCommand
        { get; set; }

        private Uri _SelectedVideoProperty;
        public Uri SelectedVideoProperty
        {
            get
            {
                return this._SelectedVideoProperty;
            }
            set
            {
                this._SelectedVideoProperty = value;
                OnPropertyChanged("SelectedVideoProperty");
            }
        }

        public ICommand MediaOpenedCommand { get; set; }
        public void MediaOpened(object param)
        {
            MediaElement parmMediaElement = (MediaElement)param;
            MyMediaElement = parmMediaElement;
        }

        private void myMedNext(object sender, RoutedEventArgs e)
        {
            doNext(null);
        }

        private void myMedOpened(object sender, RoutedEventArgs e)
        {
            if (mediatype != eMediaType.PICTURE && myMedElem.Source != null)
                MaxSlidValue = myMedElem.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
        private bool CanMediaOpened(object param)
        {
            return true;
        }


        private bool CanPlay()
        {
            return true;
        }

        private double _ValueTimer;
        public double ValueTimer
        {
            get { return _ValueTimer; }
            set { _ValueTimer = value; OnPropertyChanged("ValueTimer"); }
        }

        private DispatcherTimer DTimer;
        public bool _userUpdatingTime;

        private double _MaxSlidValue;
        public double MaxSlidValue
        {
            get { return _MaxSlidValue; }
            set { _MaxSlidValue = value; OnPropertyChanged("MaxSlidValue"); }
        }

        void DTimer_Tick(object sender, EventArgs e)
        {
            if (myMedElem != null && myMedElem.IsLoaded)
            {
                if (path != null && myMedElem.Source != null && path != myMedElem.Source.ToString())
                {

                    myMedElem.Source = new Uri(path);

                    myMedElem.Play();

                }
                if (!_userUpdatingTime)
                    ValueTimer = myMedElem.Position.TotalMilliseconds;
            }
        }

        public void sldTimeLine_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _userUpdatingTime = true;
        }

        public void sldTimeLine_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Slider sldTimeLine = sender as Slider;

            if (myMedElem != null && myMedElem.NaturalDuration.HasTimeSpan && this._userUpdatingTime)
                myMedElem.Position = new TimeSpan(0, 0, 0, 0, (int)sldTimeLine.Value);
            _userUpdatingTime = false;
        }


        public void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider s = sender as Slider;
            myMedElem.Volume = s.Value;
        }

        private int nb;
        public eMediaType mediatype;
        private ObservableCollection<Media> listinCurr;
        public void loadPath(String path, int _nb, ObservableCollection<Media> _listinCurr)
        {
            if (File.Exists(path))
            {
                pause = true;
                TextPlay = "|>";
                listinCurr = _listinCurr;
                try
                {
                    TagLib.File tagfile = TagLib.File.Create(path);
                    String artist = tagfile.Tag.FirstArtist;
                    TagLib.Properties p = tagfile.Properties;
                    TagLib.MediaTypes mt = p.MediaTypes;
                    if (mt == TagLib.MediaTypes.Audio)
                    {
                        mediatype = eMediaType.SOUND;
                        db.addSound(path);
                        myMedElem.Source = new Uri(path);
                        nb = _nb;
                    }
                    else if (mt == TagLib.MediaTypes.Photo)
                    {
                        mediatype = eMediaType.PICTURE;
                        db.addPicture(path);

                        myMedElem.Source = new Uri(path);
                        pause = false;
                        TextPlay = "||";
                        myMedElem.Play();
                        nb = _nb;
                    }
                    else if ((p.MediaTypes & TagLib.MediaTypes.Video) != TagLib.MediaTypes.None)
                    {
                        mediatype = eMediaType.VIDEO;
                        db.addVideo(path);
                        myMedElem.Source = new Uri(path);
                        nb = _nb;
                    }
                }
                catch (TagLib.UnsupportedFormatException e)
                {

                }
            }
        }

        private void doPlay(object param)
        {
            if (myMedElem.IsLoaded == true && mediatype != eMediaType.PICTURE)
            {
                if (pause == true)
                {
                    myMedElem.Play();

                    pause = false;
                    TextPlay = "||";
                }
                else
                {
                    myMedElem.Pause();
                    TextPlay = "|>";
                    pause = true;
                }
            }
        }

        private bool CanStop()
        {
            return true;
        }

        private void doStop(object param)
        {
            if (myMedElem.IsLoaded == true && mediatype != eMediaType.PICTURE)
            {
                myMedElem.Stop();
                pause = true;
                TextPlay = "|>";
            }
        }

        private bool CanRepeat()
        {
            return true;
        }

        private void doRepeat(object param)
        {
            nb = nb - 1;
        }

        private bool CanShuffle()
        {
            return true;
        }

        private void doShuffle(object param)
        {
            if (listinCurr != null)
            {
                Random r = new Random();

                nb = r.Next() % listinCurr.Count;
            }
        }

        private bool CanPrev()
        {
            return true;
        }

        private void doPrev(object param)
        {
            if (listinCurr != null)
            {
                ObservableCollection<Media> lm = listinCurr;

                Media m = lm.ElementAtOrDefault<Media>(nb - 1);
                if (m != null)
                    loadPath(m.path, nb - 1, listinCurr);
            }
        }

        private bool CanNext()
        {
            return true;
        }

        private void doNext(object param)
        {
            if (listinCurr != null)
            {
                ObservableCollection<Media> lm = listinCurr;

                Media m = lm.ElementAtOrDefault<Media>(nb + 1);
                if (m != null)
                    loadPath(m.path, nb + 1, listinCurr);
            }
        }

    }


}
