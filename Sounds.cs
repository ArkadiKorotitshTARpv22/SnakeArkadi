using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.ComponentModel;
using System.Numerics;
using NAudio;
using NAudio.Wave;

namespace Zmej
{
    public class Sounds
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private string pathToMedia;
        private Sounds sounds;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(pathToMedia + "/Snake Music.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void PlayFont()
        {
            waveOutDevice.Stop();
            audioFileReader = new AudioFileReader(pathToMedia + "/Snake Music.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void PlayEatSound()
        {
            waveOutDevice.Stop();
            audioFileReader = new AudioFileReader(pathToMedia + "/Eat.wav");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void PlayGameOver()
        {
            waveOutDevice.Stop();
            audioFileReader = new AudioFileReader(pathToMedia + "/gameover.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void PlayWin()
        {
            waveOutDevice.Stop();
            audioFileReader = new AudioFileReader(pathToMedia + "/Win.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void Stop()
        {
            waveOutDevice.Stop();
        }

        public void Dispose()
        {
            waveOutDevice.Dispose();
            audioFileReader.Dispose();
        }
    }
}