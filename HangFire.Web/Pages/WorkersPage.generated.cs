﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\WorkersPage.cshtml"
    using HangFire.Web.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class WorkersPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Pages\WorkersPage.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Workers"
        };


            
            #line default
            #line hidden
WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n  " +
"          <th>Type</th>\r\n            <th>Args</th>\r\n            <th>Started</th>" +
"\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");


            
            #line 22 "..\..\Pages\WorkersPage.cshtml"
         foreach (var worker in HangFireApi.Workers())
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");


            
            #line 25 "..\..\Pages\WorkersPage.cshtml"
               Write(worker.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 26 "..\..\Pages\WorkersPage.cshtml"
               Write(worker.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><code>");


            
            #line 27 "..\..\Pages\WorkersPage.cshtml"
                     Write(worker.Args);

            
            #line default
            #line hidden
WriteLiteral("</code></td>\r\n                <td>");


            
            #line 28 "..\..\Pages\WorkersPage.cshtml"
               Write(worker.StartedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");


            
            #line 30 "..\..\Pages\WorkersPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n");


        }
    }
}
#pragma warning restore 1591