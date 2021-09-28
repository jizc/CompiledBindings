﻿using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompiledBindings.Tests.WPF
{
	[TestClass]
	public class WPFTests
	{
		[TestMethod]
		public void Page1()
		{
			TestPage("Page1");
		}

		[TestMethod]
		public void Page2()
		{
			TestPage("Page2");
		}

		private void TestPage(string pageName)
		{
			int substr = "file:///".Length;
			TypeInfoUtils.LoadReferences(new string[]
			{
				typeof(object).Assembly.CodeBase.Substring(substr),
				typeof(INotifyPropertyChanged).Assembly.CodeBase.Substring(substr),
				typeof(System.Windows.Controls.Control).Assembly.CodeBase.Substring(substr),
				typeof(System.Windows.UIElement).Assembly.CodeBase.Substring(substr),
				typeof(System.Windows.DependencyObject).Assembly.CodeBase.Substring(substr),
				Assembly.GetExecutingAssembly().CodeBase.Substring(substr)
			});

			var xamlFile = Path.Combine(Environment.CurrentDirectory, "WPF", "Views", $"{pageName}.xml");
			var xdoc = XDocument.Load(xamlFile);

			var xamlDomParser = new WpfXamlDomParser();
			var parseResult = xamlDomParser.Parse(xamlFile, xdoc);
			parseResult.SetDependecyPropertyChangedEventHandlers("System.Windows.DependencyProperty");

			var codeGenerator = new WpfCodeGenerator();
			var code = codeGenerator.GenerateCode(parseResult);

			var csharpFile = Path.Combine(Environment.CurrentDirectory, "WPF", "Views", $"{pageName}.xml.g.m.cs");
			var expectedCode = File.ReadAllText(csharpFile);

			Assert.AreEqual(code, expectedCode);
		}
	}
}