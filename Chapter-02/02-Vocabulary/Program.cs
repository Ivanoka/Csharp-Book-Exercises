//#error version

using System.Reflection;

System.Data.DataSet ds;
HttpClient client;

namespace Vocabulary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly? assembly = Assembly.GetEntryAssembly();
            if (assembly == null)
            {
                return;
            }

            foreach (var name in assembly.GetReferencedAssemblies())
            {
                Assembly a = Assembly.Load(name);

                int methodCount = 0;

                foreach (TypeInfo type in a.DefinedTypes)
                {
                    methodCount += type.GetMethods().Count();
                }

                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount, arg2: name.Name);
            }
        }
    }
}
