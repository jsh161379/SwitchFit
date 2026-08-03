using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SwitchFit
{
    internal class SwitchAudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder returnString, int returnLength, IntPtr hwndCallback);

        private static string _currentFilePath = "";

        // 선택한 스위치의 소리 파일(.mp3 또는 .wav)을 준비하는 함수
        public static void LoadSound(string fileName)
        {
            //try
            //{
            //    if (string.IsNullOrEmpty(fileName)) return;

            //    // 기존 열려있던 오디오 파일 닫기
            //    mciSendString("close switchSound", null, 0, IntPtr.Zero);

            //    string soundPath = Path.Combine(Application.StartupPath, "Sounds", fileName);

            //    if (File.Exists(soundPath))
            //    {
            //        _currentFilePath = soundPath;
            //        // mp3/wav 파일을 별칭(switchSound)으로 열기
            //        mciSendString($"open \"{soundPath}\" type mpegvideo alias switchSound", null, 0, IntPtr.Zero);
            //    }
            //    else
            //    {
            //        _currentFilePath = "";
            //    }
            //}
            //catch
            //{
            //    _currentFilePath = "";
            //}
        }

        // 키보드를 눌렀을 때 소리를 재생하는 함수
        public static void PlayCurrentSound()
        {
            // 💡 [임시 테스트] 윈도우 기본 알림음(삐-) 소리를 냅니다!
            SystemSounds.Beep.Play();

            if (!string.IsNullOrEmpty(_currentFilePath))
            {
                // 재생 위치를 처음(0)으로 돌리고 즉시 재생
                //mciSendString("seek switchSound to start", null, 0, IntPtr.Zero);
                //mciSendString("play switchSound", null, 0, IntPtr.Zero);
            }
        }
    }
}
