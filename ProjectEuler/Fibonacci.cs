﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Fibonacci
    {
        private List<int> Sequence { get; set; }
        private int FirstTerm { get; set; }
        private int SecondTerm { get; set; }
        public int LastTerm
            {
                get
                {
                    if (this.Sequence.Count>=1)
                    {
                    return this.Sequence[this.Sequence.Count-1];
                    }
                    else
                    {
                    return -1;
                    }
                   
                }
            }
        public int NextToLastTerm
        {
            get
            {
                if (this.Sequence.Count >= 2)
                {
                    return this.Sequence[this.Sequence.Count - 2];
                }
                else
                {
                    return -1;
                }

            }
        }
        public int Last { get; set; }

        public Fibonacci(int firstTerm, int secondTerm)
        {
            this.Sequence = new List<int>();
            this.FirstTerm = firstTerm;
            this.SecondTerm = secondTerm;
        }

        public List<int> Generate(int limit)
        {
            
            if (this.FirstTerm <= limit)
            {
                this.Sequence.Add(this.FirstTerm);
            }
            if (this.SecondTerm <= limit)
            {
                this.Sequence.Add(this.SecondTerm);
            }
            if (this.Sequence.Count == 2)
            {
                int sum = this.LastTerm + this.NextToLastTerm;
                while (sum <= limit)
                {
                    this.Sequence.Add(sum);
                    sum = this.LastTerm + this.NextToLastTerm;

                }
            }

            return this.Sequence;
        }
    }

 
}
