#pragma checksum "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23337b882349f03d4618693b4178aae7e6d1eae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection_EditCollection), @"mvc.1.0.view", @"/Views/Collection/EditCollection.cshtml")]
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
#nullable restore
#line 6 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
using KursCollection.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23337b882349f03d4618693b4178aae7e6d1eae8", @"/Views/Collection/EditCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9c03fc02a89e6e9ba26fb24cf1d7b75e8d5ab3", @"/Views/_ViewImports.cshtml")]
    public class Views_Collection_EditCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollectionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Collection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowAuthorizedUserCollections", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Edit collection</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23337b882349f03d4618693b4178aae7e6d1eae85801", async() => {
                WriteLiteral("\r\n    <table id=\"mytable\" class=\"table; modal-body\">\r\n        <tr>\r\n            <th><label>Collection Name:</label></th>\r\n            <th><input name=\"collectionName\"");
                BeginWriteAttribute("value", " value=\"", 511, "\"", 540, 1);
#nullable restore
#line 14 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
WriteAttributeValue("", 519, Model.CollectionName, 519, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/></th>\r\n        </tr>\r\n        <tr>\r\n            <th><label>Description:</label></th>\r\n            <th><input id=\"description\" name=\"collectionDescription\"");
                BeginWriteAttribute("value", " value=\"", 697, "\"", 733, 1);
#nullable restore
#line 18 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
WriteAttributeValue("", 705, Model.CollectionDescription, 705, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/></th>\r\n        </tr>\r\n        <tr>\r\n            <th><label>Theme:</label></th>\r\n            <th>");
                WriteLiteral("</th>\r\n\r\n        </tr>\r\n    </table>\r\n");
                WriteLiteral("\r\n<select id=\"themes\" name=\"themeId\">\r\n");
#nullable restore
#line 29 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
     foreach (var theme in @ViewBag.Themes)
    {
        if (@theme.ThemeId == @Model.ThemeId)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23337b882349f03d4618693b4178aae7e6d1eae87890", async() => {
#nullable restore
#line 33 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
                                               Write(theme.ThemeId);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
               WriteLiteral(theme.ThemeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23337b882349f03d4618693b4178aae7e6d1eae810450", async() => {
#nullable restore
#line 37 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
                                      Write(theme.ThemeId);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
               WriteLiteral(theme.ThemeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</select>\r\n    <div class=\"modal-body\">\r\n        <label>Collection Image (optional)</label>\r\n        <input type=\"hidden\" name=\"collectionId\"");
                BeginWriteAttribute("value", " value=\"", 1456, "\"", 1483, 1);
#nullable restore
#line 44 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
WriteAttributeValue("", 1464, Model.CollectionId, 1464, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1552, 1);
#nullable restore
#line 45 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
WriteAttributeValue("", 1539, Model.UserId, 1539, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input id=\"imagelink\" type=\"hidden\" name=\"collectionImageLink\"");
                BeginWriteAttribute("value", " value=\"", 1628, "\"", 1662, 1);
#nullable restore
#line 46 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
WriteAttributeValue("", 1636, Model.CollectionImageLink, 1636, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <div id=""drop-area"">
            <p>Upload file with the file dialog or by dragging and dropping images onto the dashed region</p>
            <input type=""file"" id=""fileElem"" multiple accept=""image/*"" onchange=""handleFiles(this.files)"">
            <label class=""button"" for=""fileElem"">Select some files</label>
            <div id=""gallery""></div>
        </div>

        <div class=""createMenuInput"">
            Add Optional Fields Here!!!!:
            <input />
        </div>
    </div>

    <div class=""modal-footer"">

        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23337b882349f03d4618693b4178aae7e6d1eae814806", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\vlll\Desktop\Finding Job\Itransition\Kursach\KursCollection\KursCollection\Views\Collection\EditCollection.cshtml"
                                                      WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    var simplemde = new SimpleMDE({ element: $(""#description"")[0] });
</script>

<script>
    let dropArea = document.getElementById('drop-area')

    ;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, preventDefaults, false)
    })

    function preventDefaults(e) {
        e.preventDefault()
        e.stopPropagation()
    }

    ;['dragenter', 'dragover'].forEach(eventName => {
        dropArea.addEventListener(eventName, highlight, false)
    })

    ;['dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, unhighlight, false)
    })

    function highlight(e) {
        dropArea.classList.add('highlight')
    }

    function unhighlight(e) {
        dropArea.classList.remove('highlight')
    }

    dropArea.addEventListener('drop', handleDrop, false)

    function handleDrop(e) {
        let dt = e.dataTransfer
        let files = dt.files

        handleFile");
            WriteLiteral(@"s(files)
    }

    function handleFiles(files) {
        files = [...files]
        files.forEach(uploadFile)
        files.forEach(previewFile)
    }

    function uploadFile(file) {

        var fd = new FormData();
        fd.append('file', file);


        var pathname = window.location.pathname;
        var id = pathname.split('/')[2];
        console.log(pathname);
        console.log(id);


        $.ajax({
            url: 'uploadimage',
            data: fd,
            processData: false,
            contentType: false,
            type: 'POST',
            success: function (data) {
                console.log(data.url);
                $('#imagelink').val(data.url)
            }
        });
    }

    function previewFile(file) {
        let reader = new FileReader()
        reader.readAsDataURL(file)
        reader.onloadend = function () {
            let img = document.createElement('img')
            img.src = reader.result
            document.getEleme");
            WriteLiteral("ntById(\'gallery\').appendChild(img)\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
