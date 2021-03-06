﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Crypton.Carbonator.Config
{
    /// <summary>
    /// Defines carbonator configuration section
    /// </summary>
    public class CarbonatorSection : ConfigurationSection
    {

        /// <summary>
        /// Gets current carbonator configuration
        /// </summary>
        public static CarbonatorSection Current
        {
            get
            {
                return ConfigurationManager.GetSection("carbonator") as CarbonatorSection;
            }
        }


        /// <summary>
        /// Gets Graphite server settings
        /// </summary>
        [ConfigurationProperty("graphite", IsRequired = true)]
        public GraphiteExportElement Graphite
        {
            get { return (GraphiteExportElement)base["graphite"]; }
            set { base["graphite"] = value; }
        }

        /// <summary>
        /// Gets the configured performance counters
        /// </summary>
        [ConfigurationProperty("counters", IsRequired = true)]
        public PerformanceCounterCollection Counters
        {
            get { return (PerformanceCounterCollection)base["counters"]; }
            set { base["counters"] = value; }
        }

        /// <summary>
        /// Gets the configured default thread culture
        /// </summary>
        [ConfigurationProperty("defaultCulture", IsRequired = false, DefaultValue = "en-US")]
        public string DefaultCulture
        {
            get { return (string)base["defaultCulture"]; }
            set { base["defaultCulture"] = value; }
        }

        /// <summary>
        /// <para>Specifies logging level to Windows Event Log</para>
        /// <para>0= disable logging</para>
        /// <para>1= log information-</para>
        /// <para>2= log warnings (and everything below)</para>
        /// <para>3= log errors (and everything below)</para>
        /// <para>4= log all</para>
        /// </summary>
        [ConfigurationProperty("logLevel", IsRequired = false, DefaultValue = 1)]
        public int LogLevel
        {
            get { return (int)base["logLevel"]; }
            set { base["logLevel"] = value; }
        }

        [ConfigurationProperty("collectionInterval", IsRequired = false, DefaultValue = 1000)]
        public int CollectionInterval
        {
            get { return (int)base["collectionInterval"]; }
            set { base["collectionInterval"] = value; }
        }

        [ConfigurationProperty("reportingInterval", IsRequired = false, DefaultValue = 5000)]
        public int ReportingInterval
        {
            get { return (int)base["reportingInterval"]; }
            set { base["reportingInterval"] = value; }
        }
        /// <summary>
        /// Specifies maximum number of metrics held in the buffer. No new metrics will be added to the buffer if it is full
        /// </summary>
        [ConfigurationProperty("maxMetricBufferSize", IsRequired = false, DefaultValue = 21600)]
        public int MaxMetricBufferSize
        {
            get { return (int)base["maxMetricBufferSize"]; }
            set { base["maxMetricBufferSize"] = value; }
        }

    }
}
