#pragma checksum "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\ReturnDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3547ab20cfeb1b5f6cf53f9312c566e18ddbfd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DichVu_ReturnDetail), @"mvc.1.0.view", @"/Views/DichVu/ReturnDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\_ViewImports.cshtml"
using Library_managements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\_ViewImports.cshtml"
using Library_managements.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3547ab20cfeb1b5f6cf53f9312c566e18ddbfd2", @"/Views/DichVu/ReturnDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e07fb3a4083369c879e2f4e40a124d9857544", @"/Views/_ViewImports.cshtml")]
    public class Views_DichVu_ReturnDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\ReturnDetail.cshtml"
  
    ViewData["Title"] = "Return Book";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">

            <h1>Return History</h1>
            <table id=""example2"" class=""table table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Reader ID</th>
                        <th>Book</th>
                        <th>Reader Name</th>
                        <th>Return Date</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>


    <link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
    <script>


        $(document).ready(function ()
        {



            $(""#example2"").DataTable({
                ""processing"": true, // for show progress bar
                ""serverSide"": true, // for process server side
                ""filter"": true, // this is for disable filter (search box)
                ""orderMulti"": false, // for disable multiple column at once

                ""ajax"": {
                    ""url"": ""/DichVu/LoadReturnDetail"",
                    ""type"": ""POST");
                WriteLiteral(@""",
                    ""datatype"": ""json""
                },
                ""columnDefs"":
                    [{
                        ""targets"": [0],
                        ""visible"": true,
                        ""searchable"": true
                    },],
                ""columns"": [
                    { ""data"": ""maDocGia"", ""name"": ""maDocGia"", ""autoWidth"": true },
                    { ""data"": ""tenSach"", ""name"": ""tenSach"", ""autoWidth"": true },
                    { ""data"": ""tenDocGia"", ""name"": ""tenDocGia"", ""autoWidth"": true },
                    { ""data"": ""ngayMuon"", ""name"": ""ngayMuon"", ""autoWidth"": true },

                ]

            });
        });


       

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
