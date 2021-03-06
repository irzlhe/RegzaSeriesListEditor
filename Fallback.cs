﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegzaSeriesListEditor
{
    static class AribCharacterMapper
    {
        public static Dictionary<int, string> table = new Dictionary<int, string>();

        static AribCharacterMapper()
        {
            var list = new[]
            {
                new
                {
                    Start = 0x7A4D,
                    Strings = new string[]
                    {
                        "10.", "11.", "12.",
                        "[HV]", "[SD]", "[Ｐ]", "[Ｗ]", "[MV]", "[手]", "[字]", "[双]", "[デ]", "[Ｓ]", "[二]", "[多]", "[解]", "[SS]", "[Ｂ]", "[Ｎ]",
                        "■", "●", "[天]", "[交]", "[映]", "[無]", "[料]", "[年齢制限]", "[前]", "[後]", "[再]", "[新]", "[初]", "[終]", "[生]", "[販]",
                        "[声]", "[吹]", "[PPV]", "(秘)", "ほか",
                    },
                },
                new
                {
                    Start = 0x7C21,
                    Strings = new string[]
                    {
                        "→", "←", "↑", "↓", "○", "●", "年", "月", "日", "円", "㎡", "立方ｍ", "㎝", "平方㎝", "立方㎝",
                        "０.", "１.", "２.", "３.", "４.", "５.", "６.", "７.", "８.", "９.", "氏", "副", "元", "故", "前", "新",
                        "０,", "１,", "２,", "３,", "４,", "５,", "６,", "７,", "８,", "９,", "(社)", "(財)", "(有)", "(株)", "(代)", "(問)",
                        "＞", "＜", "【", "】", "◇", "^2", "^3", "(CD)", "(vn)", "(ob)", "(cb)", "(ce", "mb)", "(hp)", "(br)", "(p)",
                        "(s)", "(ms)", "(t)", "(bs)", "(b)", "(tb)", "(tp)", "(ds)", "(ag)", "(eg)", "(vo)", "(fl)", "(ke", "y)", "(sa", "x)",
                        "(sy", "n)", "(or", "g)", "(pe", "r)", "(R)", "(C)", "(箏)", "DJ", "[演]", "Fax",
                    },
                },
                new
                {
                    Start = 0x7D21,
                    Strings = new string[]
                    {
                        "(月)", "(火)", "(水)", "(木)", "(金)", "(土)", "(日)", "(祝)", "㍾", "㍽", "㍼", "㍻", "№", "℡", "(〒)",
                        "○", "〔本〕", "〔三〕", "〔二〕", "〔安〕", "〔点〕", "〔打〕", "〔盗〕", "〔勝〕", "〔敗〕", "〔Ｓ〕", "［投］", "［捕］", "［一］", "［二］", "［三］",
                        "［遊］", "［左］", "［中］", "［右］", "［指］", "［走］", "［打］", "㍑", "㎏", "Hz", "ha", "km", "平方km", "hPa", "・", "・",
                        "1/2", "0/3", "1/3", "2/3", "1/4", "3/4", "1/5", "2/5", "3/5", "4/5", "1/6", "5/6", "1/7", "1/8", "1/9", "1/10",
                        "晴れ", "曇り", "雨", "雪", "△", "▲", "▽", "▼", "◆", "・", "・", "・", "◇", "◎", "!!", "!?",
                        "曇/晴", "雨", "雨", "雪", "大雪", "雷", "雷雨", "　", "・", "・", "♪", "℡",
                    },
                },
                new
                {
                    Start = 0x7E21,
                    Strings = new string[]
                    {
                        "Ⅰ", "Ⅱ", "Ⅲ", "Ⅳ", "Ⅴ", "Ⅵ", "Ⅶ", "Ⅷ", "Ⅸ", "Ⅹ", "XI", "XⅡ", "⑰", "⑱", "⑲",
                        "⑳", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)", "(8)", "(9)", "(10)", "(11)", "(12)", "(21)", "(22)", "(23)",
                        "(24)", "(A)", "(B)", "(C)", "(D)", "(E)", "(F)", "(G)", "(H)", "(I)", "(J)", "(K)", "(L)", "(M)", "(N)", "(O)",
                        "(P)", "(Q)", "(R)", "(S)", "(T)", "(U)", "(V)", "(W)", "(X)", "(Y)", "(Z)", "(25)", "(26)", "(27)", "(28)", "(29)",
                        "(30)", "①", "②", "③", "④", "⑤", "⑥", "⑦", "⑧", "⑨", "⑩", "⑪", "⑫", "⑬", "⑭", "⑮",
                        "⑯", "①", "②", "③", "④", "⑤", "⑥", "⑦", "⑧", "⑨", "⑩", "⑪", "⑫", "(31)",
                    },
                },
            };

            foreach (var data in list)
            {
                int jis_code = data.Start;
                foreach (var s in data.Strings)
                {
                    int euc_code = jis_code | 0x8080;
                    table.Add(euc_code, s);
                    jis_code++;
                }
            }
        }
    }
}
