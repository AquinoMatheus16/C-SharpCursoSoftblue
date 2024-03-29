﻿using System;

namespace Softblue
{
    /// <summary>
    /// Votos de uma opção.
    /// </summary>
    class OptionScore : IComparable<OptionScore>
    {
        /// <summary>
        /// Opção.
        /// </summary>
        public Option Option { get; private set; }

        /// <summary>
        /// Números de votos
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="option">Opção</param>
        /// <param name="score">Números de votos</param>
        public OptionScore(Option option, int score)
        {
            this.Option = option;
            this.Count = score;
        }

        /// <summary>
        /// Define a comparação como ordem descrescente de votos. Se duas opções tiverem o mesmo número de votos,
        /// usa o critério de ordem alfabética do texto da opção.
        /// </summary>
        /// <param name="other">IComparable&lt;T&gt;.CompareTo()</param>
        /// <returns></returns>
        public int CompareTo(OptionScore other)
        {
            int comp = -Count.CompareTo(other.Count);

            if (comp == 0)
            {
                return Option.Text.CompareTo(other.Option.Text);
            }

            return comp;
        }
    }
}