﻿using System;

namespace AutoDiff.Compiled
{
    internal class UnaryFunc : TapeElement
    {
        public int Arg;
        public readonly Func<double, double> Eval;
        public readonly Func<double, double> Diff;

        public UnaryFunc(Func<double, double> eval, Func<double, double> diff)
        {
            Eval = eval;
            Diff = diff;
        }

        public override void Accept(ITapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}