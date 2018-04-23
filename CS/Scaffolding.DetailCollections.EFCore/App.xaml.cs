using DevExpress.Xpf.Core;
using Microsoft.EntityFrameworkCore;
using Scaffolding.DetailCollectionsEFCore.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Scaffolding.DetailCollections.EFCore {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ApplicationThemeHelper.UpdateApplicationThemeName();
            using(var context = new DepartmentContext()) {
                context.Database.Migrate();
                context.EnsureSeedData();
            }
        }

        protected override void OnExit(ExitEventArgs e) {
            ApplicationThemeHelper.SaveApplicationThemeName();
        }
    }
}
