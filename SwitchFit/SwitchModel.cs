using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchFit
{
    internal class SwitchModel
    {
        public int Id { get; set; }             //번호
        public string Name { get; set; }        //스위치 이름
        public string Category { get; set; }    //소음 (Silent, SemiSilent, Normal)
        public string Type { get; set; }        //키감 (Linear, Tactile)
        public int Pressure { get; set; }          //키압 (g 단위, 예: 40)
        public string SoundFilePath { get; set; } //소리 파일 경로

        public string CategoryKr
        {
            get
            {
                if(Category == "Silent") return "저소음";
                else if(Category == "SemiSilent") return "반저소음";
                else if(Category == "Normal") return "일반";
                else return Category;
            }
        }

        public string TypeKr
        {
            get
            {
                if(Type == "Linear") return "리니어";
                else if(Type == "Tactile") return "택타일";
                else return Type;
            }
        }


    }
}
