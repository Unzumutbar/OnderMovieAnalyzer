using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnderMovieAnalyzer.Objects
{
    public enum ExportType
    {
        Text,
        CopyScripts,
        DeletScripts
    }

    public class ExportOptions
    {
        public string FileSource { get; set; }
        public ExportType ExportType { get; set; }
    }
}
