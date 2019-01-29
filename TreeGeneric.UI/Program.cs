using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Data;
using TreeGenericData;

namespace TreeGeneric.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>();
            /*
            builder.RegisterType<Repository<TreeGeneric.Model.Region>>().As<IRegionRepository<TreeGeneric.Model.Region>>();
            */
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            
            builder.RegisterType<RegionService>().As<IRegionService>();
            builder.RegisterType<PlantingService>().As<IPlantingService>();
            builder.RegisterType<DonationService>().As<IDonationService>();
            builder.RegisterType<PostService>().As<IPostService>();
            builder.RegisterType<TreeTypeService>().As<ITreeTypeService>();
            builder.RegisterType<UserService>().As<IUserService>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);                
                Application.Run(new Form1());
            }
        }
    }
}
