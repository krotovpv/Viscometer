using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Viscometer.TestObject.Test;

namespace Viscometer.TestObject
{
    public class Program
    {
        /// <summary>
        /// Тип испытания. Ex.: V - Viscosity, S - Scorch.
        /// </summary>
        public Test.EType TestType { get; }
        /// <summary>
        /// Размер ротора. Ex.: L - Large, S - Small.
        /// </summary>
        public RotorType RotorSize { get; }
        /// <summary>
        /// Заданная температура испытания. Ex.:000.0
        /// </summary>
        public float SetPoint { get; }
        /// <summary>
        /// Заданное время испытания. Ex.: mmm:ss.f
        /// </summary>
        public TimeSpan SetTime { get; }
        /// <summary>
        /// Прогрев. Осуществляется перед испытанием для лучшей стабилизации температуры. Ex.: 000.0
        /// </summary>
        public TimeSpan Preheat { get; }
        /// <summary>
        /// Время для релоксации. Ex.: mmm:ss.f
        /// </summary>
        public TimeSpan Decay { get; }
        /// <summary>
        /// Диапазон вязкости
        /// </summary>
        public float ViscRange { get; }

        /// <summary>
        /// Программа испытания
        /// </summary>
        /// <param name="testType">Тип испытания. Ex.: V - Viscosity, S - Scorch.</param>
        /// <param name="rotorSize">Размер ротора. Ex.: L - Large, S - Small.</param>
        /// <param name="setPoint">Заданная температура испытания. Ex.: 000.0</param>
        /// <param name="setTime">Заданное время испытания. Ex.: mmm:ss.f</param>
        /// <param name="preheat">Прогрев. Осуществляется перед испытанием для лучшей стабилизации температуры. Ex.: 000.0</param>
        /// <param name="decay">Время для релоксации. Ex.: mmm:ss.f</param>
        /// <param name="viscRange">Диапазон вязкости</param>
        public Program(Test.EType testType, RotorType rotorSize, float setPoint, TimeSpan setTime, TimeSpan preheat, 
            TimeSpan decay, float viscRange = 0) 
        {
            TestType = testType;
            RotorSize = rotorSize;
            SetPoint = setPoint;
            SetTime = setTime;
            Preheat = preheat;
            Decay = decay;
            ViscRange = viscRange;
        }

        public override string ToString()
        {
            string res = string.Empty;

            if (TestType == EType.Viscosity)
            {
                res = "M";
                if (RotorSize == RotorType.Large)
                    res += "L";
                else if (RotorSize == RotorType.Small)
                    res += "S";
                res += Preheat.Minutes.ToString();
                res += "+";
                res += SetTime.Minutes.ToString();
                res += $" ({SetPoint.ToString().Replace(",", ".")}°C)";
                if (Decay.Minutes > 0) res += $" {Decay.Minutes.ToString()}min SR";
            }
            else if (TestType == EType.Scorch)
            {
                res = "Scorch Δt = ";
                if (RotorSize == RotorType.Large)
                    res += "t35 - t5";
                else if (RotorSize == RotorType.Small)
                    res += "t18 - t3";
            }

            return res;
        }
    }
}
