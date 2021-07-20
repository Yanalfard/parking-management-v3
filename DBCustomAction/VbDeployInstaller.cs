using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace DBCustomAction
{
    [RunInstaller(true)]
    public partial class VbDeployInstaller : System.Configuration.Install.Installer
    {
        public VbDeployInstaller()
        {
            InitializeComponent();
        }
    }
}
