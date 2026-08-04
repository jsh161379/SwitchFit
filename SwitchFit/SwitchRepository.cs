using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchFit
{
    internal class SwitchRepository
    {

        // 18개 스위치 전체 목록 가져오기
        public static List<SwitchModel> GetAllSwitches()
        {
            return new List<SwitchModel>
            {
                // [저소음 - 리니어]
                new SwitchModel { Id = 1, Name = "KTT 저소음 블루축", Category = "Silent", Type = "Linear", Pressure = 39, SoundFilePath = "111_silent_blue.mp3" },
                new SwitchModel { Id = 2, Name = "KTT 저소음 바다축", Category = "Silent", Type = "Linear", Pressure = 43, SoundFilePath = "112_silent_ocean.mp3" },
                new SwitchModel { Id = 3, Name = "체리 MX 저소음 흑축", Category = "Silent", Type = "Linear", Pressure = 62, SoundFilePath = "113_cherry_mx_silent.mp3" },

                // [저소음 - 택타일]
                new SwitchModel { Id = 4, Name = "LEOBOG 저소음 눈송이축", Category = "Silent", Type = "Tactile", Pressure = 36, SoundFilePath = "121_silent_snow.mp3" },
                new SwitchModel { Id = 5, Name = "SPM 새벽축 택타일", Category = "Silent", Type = "Tactile", Pressure = 40, SoundFilePath = "122_silent_dawn_tactile.mp3" },
                new SwitchModel { Id = 6, Name = "키크론 저소음 바나나축", Category = "Silent", Type = "Tactile", Pressure = 55, SoundFilePath = "123_silent_banana.mp3" },

                // [반저소음 - 리니어]
                new SwitchModel { Id = 7, Name = "HMX 목새축 라이트 리니어", Category = "SemiSilent", Type = "Linear", Pressure = 37, SoundFilePath = "211_moksae_light_linear.mp3" },
                new SwitchModel { Id = 8, Name = "HMX 저소음 디딤돌축", Category = "SemiSilent", Type = "Linear", Pressure = 43, SoundFilePath = "212_silent_didimdol.mp3" },
                new SwitchModel { Id = 9, Name = "HMX 저소음 선셋축", Category = "SemiSilent", Type = "Linear", Pressure = 45, SoundFilePath = "213_silent_sunset.mp3" },

                // [반저소음 - 택타일]
                new SwitchModel { Id = 10, Name = "HMX 목새 라이트 택타일", Category = "SemiSilent", Type = "Tactile", Pressure = 37, SoundFilePath = "221_moksae_light_tactile.mp3" },
                new SwitchModel { Id = 11, Name = "SPM 새벽축", Category = "SemiSilent", Type = "Tactile", Pressure = 40, SoundFilePath = "spm_dawn_40.wav" },
                new SwitchModel { Id = 12, Name = "SPM 새벽축", Category = "SemiSilent", Type = "Tactile", Pressure = 48, SoundFilePath = "spm_dawn_48.wav" },

                // [일반 - 리니어]
                new SwitchModel { Id = 13, Name = "KTT Kang White", Category = "Normal", Type = "Linear", Pressure = 38, SoundFilePath = "ktt_white.wav" },
                new SwitchModel { Id = 14, Name = "Gateron Yellow Pro", Category = "Normal", Type = "Linear", Pressure = 42, SoundFilePath = "gat_yellow.wav" },
                new SwitchModel { Id = 15, Name = "체리 MX2A 흑축", Category = "Normal", Type = "Linear", Pressure = 60, SoundFilePath = "313_cherry_mx2a.mp3" },

                // [일반 - 택타일]
                new SwitchModel { Id = 16, Name = "Akko Lavender Purple", Category = "Normal", Type = "Tactile", Pressure = 36, SoundFilePath = "akko_purple.wav" },
                new SwitchModel { Id = 17, Name = "Holy Panda", Category = "Normal", Type = "Tactile", Pressure = 42, SoundFilePath = "holy_panda.wav" },
                new SwitchModel { Id = 18, Name = "Gateron Baby Kangaroo", Category = "Normal", Type = "Tactile", Pressure = 59, SoundFilePath = "baby_kangaroo.wav" }
            };
        }

        // 설문 답변(소음, 키감, 키압 선택값)에 맞추어 스위치 1개를 추천해주는 함수
        public static SwitchModel GetRecommendation(string noise, string type, string pressure)
        {
            List<SwitchModel> allSwitches = GetAllSwitches(); // 전체 스위치 목록

            // 18개(또는 27개) 스위치 중 조건 3개가 정확히 일치하는 딱 1개 스위치 찾기
            foreach (SwitchModel sw in allSwitches)
            {
                if (sw.Category == noise && sw.Type == type)
                {
                    // 키압 조건 체크 (Low: 가벼움, Mid: 표준, High: 묵직함)
                    if (pressure == "Low" && sw.Pressure <= 39) return sw;
                    if (pressure == "Mid" && sw.Pressure >= 40 && sw.Pressure <= 44) return sw;
                    if (pressure == "High" && sw.Pressure >= 45) return sw;
                }
            }

            // 혹시라도 안 맞으면 목록의 첫 번째 스위치 반환 (예외 처리)
            return allSwitches[0];
        }
    }
}

