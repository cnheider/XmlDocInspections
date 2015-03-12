﻿using JetBrains.Application.Settings;
using NUnit.Framework;
using XmlDocInspections.Plugin.Settings;

namespace XmlDocInspections.Plugin.Tests.IntegrationTests
{
    [TestFixture]
    public class ProjectExclusionTests : MissingXmlDocHighlightingTestsBase
    {
        protected override void MutateSettings(IContextBoundSettingsStore settingsStore)
        {
            settingsStore.SetValue((XmlDocInspectionsSettings s) => s.ProjectExclusionRegex, "^Excl.*ject$");
        }

        protected override string ProjectName
        {
            get { return "ExcludedProject"; }
        }

        [Test]
        public void TestStructWithoutDocs()
        {
            DoNamedTest2();
        }
    }
}