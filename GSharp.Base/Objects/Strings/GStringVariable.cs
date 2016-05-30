﻿using System;
using GSharp.Base.Cores;

namespace GSharp.Base.Objects.Strings
{
    [Serializable]
    public class GStringVariable : GString, IVariable
    {
        #region 속성
        public string Name { get; set; }

        public Type VariableType
        {
            get
            {
                return typeof(string);
            }
        }
        #endregion

        #region 생성자
        public GStringVariable(string valueName)
        {
            Name = valueName;
        }
        #endregion

        public override string ToSource()
        {
            return Name;
        }
    }
}