#pragma checksum "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46611ea8f9a6e59f8e7c3ce3619e43c675cef8d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppUser_AdminTab), @"mvc.1.0.view", @"/Views/AppUser/AdminTab.cshtml")]
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
#line 1 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\_ViewImports.cshtml"
using KursCollection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\_ViewImports.cshtml"
using KursCollection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46611ea8f9a6e59f8e7c3ce3619e43c675cef8d0", @"/Views/AppUser/AdminTab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9c03fc02a89e6e9ba26fb24cf1d7b75e8d5ab3", @"/Views/_ViewImports.cshtml")]
    public class Views_AppUser_AdminTab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KursCollection.Models.AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("        /*KursCollection.ViewModel.AppUserViewModel*/\r\n\r\n");
            WriteLiteral("<h2>All Users</h2>\r\n\r\n");
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<button class=""btn"" id=""block""><i class=""fa fa-close""> Block</i></button>
<button class=""btn"" id=""unblock""><i class=""fa fa-arrow-circle-up""> Unblock</i></button>
<button class=""btn"" id=""delete""><i class=""fa fa-trash""> Delete</i></button>
<button class=""btn"" id=""promote""><i class=""fa fa-trash""> Make Admin</i></button>
<button class=""btn"" id=""disrank""><i class=""fa fa-trash""> Disrank</i></button>
<div class=""container"">

    <table class=""table"">
        <thead>
            <tr>
                <th><input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 899, "\"", 907, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""checkbox""> check all</th>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Registrtion Date</th>
                <th>Last Login</th>
                <th>Status</th>
                <th>Admin</th>
                <th>Dark Theme</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 34 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td align=\"center\"><input class=\"form-check-input child\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1433, "\"", 1441, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=", 1442, "", 1458, 1);
#nullable restore
#line 37 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
WriteAttributeValue("", 1446, user.UserId, 1446, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.LastActiveDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.UserStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.IsAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
               Write(user.DarkTheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1827, "\"", 1909, 1);
#nullable restore
#line 46 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
WriteAttributeValue("", 1834, Url.Action("ShowUserCollectionsUWC","Collection", new {id = @user.UserId}), 1834, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Go to user collections</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<!--\r\n    Комментарий, располагающийся между\r\n  заголовком и текстом\r\n-->\r\n\r\n<script>\r\n    var currentUserId = \"");
#nullable restore
#line 59 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                    Write(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""

    function refreshPage() {
        location.reload(true);
    }

    $(document).ready(function() {
        $('#checkbox').change(function () {
            if (this.checked) {
                $('body input:checkbox').prop('checked', true);
            } else {
                $('body input:checkbox').prop('checked', false);
            }
        })

        $('input[type=""checkbox""]').on('change', function () {
            var all = $(':checkbox').not(document.getElementById(""checkbox"")).length;
            var actives = $(':checkbox:checked').not(document.getElementById(""checkbox"")).length;

            if (actives == all) {
                $('#checkbox').prop('checked', true)
            }
            else {
                $('#checkbox').prop('checked', false)
            }
        })

        //function sleep(ms) {
        //    return new Promise(resolve => setTimeout(resolve, ms));
        //}

        $('#unblock').on('click', function (e) {
            var checkedA");
            WriteLiteral("rray = [];\r\n            $(\'input:checkbox:checked\').each(function () {\r\n                checkedArray.push(parseInt($(this).attr(\"id\")));\r\n            })\r\n            console.log(checkedArray);\r\n\r\n            $.ajax({\r\n\r\n                url: \"");
#nullable restore
#line 99 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                 Write(Url.Action("Unblock"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                dataType: ""json"",
                contextType: ""application/json"",
                data: { selectedIds: checkedArray },
                traditional: true,
                success: function (data) {
                    console.log('Данные отправлены');
                    location.reload(true);
                }
            });

            $('body input:checkbox').prop('checked', false);
        });




        $('#delete').on('click', function (e) {
            var checkedArray = [];
            $('input:checkbox:checked').each(function () {
                checkedArray.push(parseInt($(this).attr(""id"")));
            })
            console.log(checkedArray);

            $.ajax({
                url: """);
#nullable restore
#line 125 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                 Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                dataType: ""json"",
                contextType: ""application/json"",
                data: { selectedIds: checkedArray },
                traditional: true,
                success: function (data) {
                    console.log('Данные отправлены');
                    location.reload(true);
                }
            });
            $('body input:checkbox').prop('checked', false);
        });

        $('#block').on('click', function (e) {
            var checkedArray = [];
            $('input:checkbox:checked').each(function () {
                checkedArray.push(parseInt($(this).attr(""id"")));
            })
            console.log(checkedArray);

            $.ajax({
                url: """);
#nullable restore
#line 147 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                 Write(Url.Action("Block"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                dataType: ""json"",
                contextType: ""application/json"",
                data: { selectedIds: checkedArray },
                traditional: true,
                success: function (data) {
                    console.log('Данные отправлены');
                    refreshPage();
                }
            });
            //sleep(1000).then(() => { clocation.reload(true); });

            $('body input:checkbox').prop('checked', false);
        });

        $('#promote').on('click', function (e) {
            var checkedArray = [];
            $('input:checkbox:checked').each(function () {
                checkedArray.push(parseInt($(this).attr(""id"")));
            })
            console.log(checkedArray);

            $.ajax({
                url: """);
#nullable restore
#line 171 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                 Write(Url.Action("Promote"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                dataType: ""json"",
                contextType: ""application/json"",
                data: { selectedIds: checkedArray },
                traditional: true,
                success: function (data) {
                    console.log('Данные отправлены');
                    refreshPage();
                }
            });
            //sleep(1000).then(() => { clocation.reload(true); });

            $('body input:checkbox').prop('checked', false);
        });

        $('#disrank').on('click', function (e) {
            var checkedArray = [];
            $('input:checkbox:checked').each(function () {
                checkedArray.push(parseInt($(this).attr(""id"")));
            })
            console.log(checkedArray);

            $.ajax({
                url: """);
#nullable restore
#line 195 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\AppUser\AdminTab.cshtml"
                 Write(Url.Action("Disrank"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""post"",
                dataType: ""json"",
                contextType: ""application/json"",
                data: { selectedIds: checkedArray },
                traditional: true,
                success: function (data) {
                    console.log('Данные отправлены');
                    console.log(checkedArray.indexOf(currentUserId) == -1);
                    if (checkedArray.indexOf(currentUserId) == -1) {
                        console.log('1');
                        window.location.replace('/');
                        location.href = '/';
                    }
                    else {
                        console.log('2');
                        refreshPage();
                    }
                }
            });
            //sleep(1000).then(() => { clocation.reload(true); });

            $('body input:checkbox').prop('checked', false);
        });

    })
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KursCollection.Models.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591