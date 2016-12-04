using System;
using Core.Deployments;
using StructureMap;


namespace ConsoleApplication
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

            var orchestrator = container.GetInstance<DeploymentOrchestrator>();
        }
    }
}
