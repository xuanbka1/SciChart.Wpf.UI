﻿using System;

namespace SciChart.Wpf.UI.Bootstrap
{
    public enum CreateAs
    {
        /// <summary>
        /// Creates a new instance each time this class is injected
        /// </summary>
        Default,

        /// <summary>
        /// Creates and stores the class as a singleton in the container
        /// </summary>
        Singleton
    }

    public enum DataMode
    {
        Any,
        Local,
        Remote
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]    
    public class ExportTypeAttribute : Attribute
    {
        private readonly Type _from;
        private CreateAs _createAs;
        private DataMode _dataMode;

        public ExportTypeAttribute(Type @from, CreateAs createAs = CreateAs.Default, DataMode datamode = Bootstrap.DataMode.Any)
        {
            _from = @from;
            _createAs = createAs;
            _dataMode = datamode;
        }

        public Type TFrom
        {
            get { return _from; }
        }

        public CreateAs CreateAs
        {
            get { return _createAs; }
        }

        public DataMode DataMode
        {
            get { return _dataMode; }
        }
    }
}
