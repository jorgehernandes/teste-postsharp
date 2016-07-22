using PostSharp.Aspects;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Framework
{
    [Serializable]
    public class LogTestAspect : OnMethodBoundaryAspect
    {
        private string[] parameterNames;

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            parameterNames = method.GetParameters().Select(p => p.Name).ToArray();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            Debug.WriteLine("**INFO**");
            Debug.WriteLine($"Metodo: {args.Method.Name} - Parametros:");
            object[] parameterValues = args.Arguments.ToArray();

            for (int i = 0; i < parameterNames.Length; i++)
            {
                Debug.Write($"| {parameterNames[i]} : {args.Arguments[i]} |");
            }

            Debug.WriteLine("");
            Debug.WriteLine("");
        }
    }
}
