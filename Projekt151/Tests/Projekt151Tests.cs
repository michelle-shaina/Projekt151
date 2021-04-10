using AngleSharp.Dom;
using Bunit;
using Bunit.Extensions;
using Microsoft.Data.SqlClient.DataClassification;
using Projekt151.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Xunit;

namespace Projekt151.Tests
{
    public class Projekt151Tests
    {
        [Fact]
        public void ShouldComeHintWhenLoggedInWrong()
        {
            using var ctx = new TestContext();
            var component = ctx.RenderComponent<Login>();

            var btn = component.Find("button");
            btn.Click();
            var label = component.Find("label");
            label.LocateNamespaceFor("Name").IsNullOrEmpty();
            label.LocateNamespaceFor("Password").IsNullOrEmpty();

            component.MarkupMatches(@"<p>There is no combination of the user and password found, please check the spelling an try again!<p>");
        }
        [Fact]
        public void AdminLogin()
        {
            using var ctx = new TestContext();
            var component = ctx.RenderComponent<Login>();

            var btn = component.Find("button");
            component.Find("input[aria-label=Name]").Change("Michelle");
            component.Find("input[aria-label=Password]").Change("1234");
            component.Find("form").Submit();
        }
    }
}