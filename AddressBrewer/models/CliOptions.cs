﻿namespace AddressBrewer.models
{
    public class CliOptions
    {
        public string SgidServer { get; set; }
        public string SgidDatabase { get; set; }
        public string SgidId { get; set; }
        public string SdeConnectionPath { get; set; }
        public string OutputFile { get; set; }
        public OutputType OutputType { get; set; }
        public bool Verbose { get; set; }
        public string DatabaseName { get; set; }
        public string Server { get; set; }
    }
}
