using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SwitchFit
{
    internal class SwitchAudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder returnString, int returnLength, IntPtr hwndCallback);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, uint cchBuffer);

        private const int CHANNEL_COUNT = 5; // 연타용 5개 채널
        private static int _currentChannel = 0;
        private static string _loadedFile = "";

        // 선택한 스위치 소리 파일 미리 열어두기 (프리로드)
        public static void LoadSound(string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName)) return;

                // 이미 로드된 파일이면 재로드 방지
                if (_loadedFile == fileName) return;

                string soundPath = Path.Combine(Application.StartupPath, "sounds", fileName);

                if (!File.Exists(soundPath)) return;

                // 한글/공백 경로 변환
                StringBuilder sb = new StringBuilder(255);
                GetShortPathName(soundPath, sb, (uint)sb.Capacity);
                string shortPath = sb.ToString();

                // 기존 채널들 정리 후 새로 5개 채널 오픈
                for (int i = 0; i < CHANNEL_COUNT; i++)
                {
                    string alias = $"sw_snd_{i}";
                    mciSendString($"close {alias}", null, 0, IntPtr.Zero);
                    mciSendString($"open \"{shortPath}\" type mpegvideo alias {alias}", null, 0, IntPtr.Zero);
                }

                _loadedFile = fileName;
            }
            catch
            {
                // 예외 처리
            }
        }

        // ⌨️ 타자 칠 때 소리 재생 (5개 채널 번갈아 가며 즉시 재생)
        public static void PlayCurrentSound()
        {
            if (string.IsNullOrEmpty(_loadedFile)) return;

            try
            {
                // 채널 순환 (0 -> 1 -> 2 -> 3 -> 4 -> 0 ...)
                string alias = $"sw_snd_{_currentChannel}";
                _currentChannel = (_currentChannel + 1) % CHANNEL_COUNT;

                // 재생 위치를 맨 앞으로 돌리고 즉시 재생
                mciSendString($"seek {alias} to start", null, 0, IntPtr.Zero);
                mciSendString($"play {alias}", null, 0, IntPtr.Zero);
            }
            catch
            {
                // 예외 처리
            }
        }
    }
}