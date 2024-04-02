﻿namespace Prototype
{
    public abstract class Prototype
    {
        public abstract Prototype ShallowCopy();
        public abstract Prototype DeepCopy();
        public abstract void Debug();
    }
}
