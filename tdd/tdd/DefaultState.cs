﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class DefaultState : ICompanionState
    {
        public string getWords(Companion companion, string words)
        {
            string replySymbols = ">>> ";
            if (words == "Что ты умеешь делать?")
                return replySymbols + "Пока ничего";
            else if (words == "Пока")
                return replySymbols + "Пока!";
            else if (words == "Покажи погоду")
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(1510853);
            }
            else if (words == "Покажи погоду в Новосибирске")
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(1496747);
            }
            else if (words == "Покажи погоду по ID города")
            {
                companion.State = new WeatherIDState();
                return replySymbols + "Скажешь ID города?";
            }
            else if(words == "Покажи курс доллара")
            {
                ExchRateMaker erm = new ExchRateMaker();
                return replySymbols + "Курс доллара: " + erm.getCurExchRate();
            }
            return replySymbols + "Привет!";
        }
    }
}
