using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using TestCore;

namespace TestFrontend {
	class Program {
		static void Main(string[] args) {
			foreach (var assemblyPath in new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.GetFiles("*.dll")) {
				var assembly = Assembly.LoadFile(assemblyPath.FullName);
				foreach (var type in assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(ITestInterface)))) {
					var t = Activator.CreateInstance(type) as ITestInterface;
					Console.WriteLine($"Type {type.Name}, value {t.MagicValue}");
				}
			}
			while (true) {
				Console.WriteLine($"The current time is {DateTime.Now}");
				Thread.Sleep(3000);
			}
		}
	}
}
