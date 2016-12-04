using System;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Deployments;
using StructureMap;
using System.Reflection;
using System.IO;

namespace Runtime.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(config => {
                config.Scan(_ => {
                    _.AssembliesFromApplicationBaseDirectory();
                    _.RegisterConcreteTypesAgainstTheFirstInterface();
                    _.WithDefaultConventions(); 
                });
            });

            
            

            var services = new ServiceCollection();
            
            var serviceProvider = services.BuildServiceProvider();
            var options = new NodeServicesOptions(serviceProvider);

            var assembly = typeof(Program).GetTypeInfo().Assembly;
            var directory = Path.GetDirectoryName(assembly.Location).Replace("/bin/Debug/netcoreapp1.1",string.Empty);
            options.ProjectPath = directory;
            var nodeServices = NodeServicesFactory.CreateNodeServices(options);

            System.Console.WriteLine("Invoking");
            nodeServices.InvokeExportAsync<int>("./test", "addNumbers", 1, 2).ContinueWith(r => {
                System.Console.WriteLine($"Result is {r.Result}");

            });

            var orchestrator = container.GetInstance<DeploymentOrchestrator>();
        }
    }
}
