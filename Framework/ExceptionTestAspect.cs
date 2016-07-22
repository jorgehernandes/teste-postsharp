using PostSharp.Aspects;
using System;
using System.Linq;
using System.Reflection;

namespace Framework
{
    [Serializable]
    public class ExceptionTestAspect : OnExceptionAspect
    {
        private string[] parameterNames;

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            parameterNames = method.GetParameters().Select(p => p.Name).ToArray();
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("**ERROR**");
            Console.WriteLine($"Metodo: {args.Method.Name} - Parametros:");
            object[] parameterValues =  args.Arguments.ToArray();
            
            for (int i = 0; i < parameterNames.Length; i++)
            {
                Console.Write($"| {parameterNames[i]} : {args.Arguments[i]} |");
            }

            Console.WriteLine("");

            Console.WriteLine($"Erro: {args.Exception.Message}");
            Console.WriteLine($"StackTrace: {args.Exception.StackTrace}");

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
