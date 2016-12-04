using Runtime.Deployments;
using StructureMap;


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

            var orchestrator = container.GetInstance<DeploymentOrchestrator>();
        }
    }
}
