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
                new SwitchModel { Id = 1, Name = "오무 저소음 피치", Category = "Silent", Type = "Linear", Pressure = 35, SoundFilePath = "silent_peach.wav" },
                new SwitchModel { Id = 2, Name = "Haimu 저소음 하트", Category = "Silent", Type = "Linear", Pressure = 40, SoundFilePath = "silent_heart.wav" },
                new SwitchModel { Id = 3, Name = "Gateron 저소음 갈축", Category = "Silent", Type = "Linear", Pressure = 45, SoundFilePath = "silent_brown.wav" },

                // [저소음 - 택타일]
                new SwitchModel { Id = 4, Name = "오무 저소음 라임", Category = "Silent", Type = "Tactile", Pressure = 35, SoundFilePath = "silent_lime.wav" },
                new SwitchModel { Id = 5, Name = "TTC 저소음 자스민", Category = "Silent", Type = "Tactile", Pressure = 42, SoundFilePath = "silent_jasmine.wav" },
                new SwitchModel { Id = 6, Name = "Boba U4 저소음", Category = "Silent", Type = "Tactile", Pressure = 46, SoundFilePath = "boba_u4.wav" },

                // [반저소음 - 리니어]
                new SwitchModel { Id = 7, Name = "Haimu 어쩌구 1", Category = "SemiSilent", Type = "Linear", Pressure = 35, SoundFilePath = "semi_35g.wav" },
                new SwitchModel { Id = 8, Name = "Haimu 어쩌구 2", Category = "SemiSilent", Type = "Linear", Pressure = 42, SoundFilePath = "semi_42g.wav" },
                new SwitchModel { Id = 9, Name = "Haimu 어쩌구 3", Category = "SemiSilent", Type = "Linear", Pressure = 50, SoundFilePath = "semi_50g.wav" },

                // [반저소음 - 택타일]
                new SwitchModel { Id = 10, Name = "SPM 새벽축", Category = "SemiSilent", Type = "Tactile", Pressure = 38, SoundFilePath = "spm_dawn_38.wav" },
                new SwitchModel { Id = 11, Name = "SPM 새벽축", Category = "SemiSilent", Type = "Tactile", Pressure = 40, SoundFilePath = "spm_dawn_40.wav" },
                new SwitchModel { Id = 12, Name = "SPM 새벽축", Category = "SemiSilent", Type = "Tactile", Pressure = 48, SoundFilePath = "spm_dawn_48.wav" },

                // [일반 - 리니어]
                new SwitchModel { Id = 13, Name = "KTT Kang White", Category = "Normal", Type = "Linear", Pressure = 38, SoundFilePath = "ktt_white.wav" },
                new SwitchModel { Id = 14, Name = "Gateron Yellow Pro", Category = "Normal", Type = "Linear", Pressure = 42, SoundFilePath = "gat_yellow.wav" },
                new SwitchModel { Id = 15, Name = "Cherry MX Black", Category = "Normal", Type = "Linear", Pressure = 47, SoundFilePath = "cherry_black.wav" },

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

