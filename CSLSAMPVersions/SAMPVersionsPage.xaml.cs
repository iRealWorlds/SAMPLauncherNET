﻿using CSLPI;
using System;
using System.IO;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher San Andreas Multiplayer versions namespace
/// </summary>
namespace CSLSAMPVersions
{
    /// <summary>
    /// San Andreas Multiplayer versions page class
    /// </summary>
    public partial class SAMPVersionsPage : UserControl, ICSLModule, ICSLPage
    {
        /// <summary>
        /// Configuration path
        /// </summary>
        private static readonly string ConfigurationPath = Path.Combine(Path.Combine(Environment.CurrentDirectory, "config"), "samp_versions.json");

        /// <summary>
        /// Community San Andreas Multiplayer Launcher
        /// </summary>
        private ICSL csl;

        /// <summary>
        /// Configuration
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// Title
        /// </summary>
        public string Title => "SAMP_VERSIONS";

        /// <summary>
        /// Community San Andreas Multiplayer Launcher module configuration
        /// </summary>
        public ACSLConfiguration ModuleConfiguration
        {
            get
            {
                if (configuration == null)
                {
                    configuration = new Configuration();
                }
                return configuration;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public SAMPVersionsPage()
        {
            InitializeComponent();
            ModuleConfiguration.Load(ConfigurationPath);
        }

        /// <summary>
        /// Intialize Community San Andreas Multiplayer Launcher module
        /// </summary>
        /// <param name="csl"></param>
        public void Init(ICSL csl)
        {
            this.csl = csl;
        }

        /// <summary>
        /// Exit Community San Andreas Multiplayer Launcher module
        /// </summary>
        public void Exit()
        {
            ModuleConfiguration.Save(ConfigurationPath);
        }
    }
}