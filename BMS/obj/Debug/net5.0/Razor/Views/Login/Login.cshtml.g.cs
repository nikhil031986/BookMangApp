#pragma checksum "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa671aab499e3fd5b1e6377fcea5eff70219bbbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "D:\Projects\MVCTestProject\BMS\Views\_ViewImports.cshtml"
using BMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MVCTestProject\BMS\Views\_ViewImports.cshtml"
using BMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa671aab499e3fd5b1e6377fcea5eff70219bbbf", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c94e1cf3595ce537b0a1fe31beddb3fde19552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/singup/SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"container\">\r\n\t<div class=\"screen\">\r\n\t\t<div class=\"screen__content\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa671aab499e3fd5b1e6377fcea5eff70219bbbf4558", async() => {
                WriteLiteral(@"
				<div class=""login__field"">
					<i class=""login__icon fas fa-user""></i>
					<input type=""text"" class=""login__input"" id=""UserEmailId"" placeholder=""User name / Email"">
				</div>
				<div class=""login__field"">
					<i class=""login__icon fas fa-lock""></i>
					<input type=""password"" id=""UserPassword"" class=""login__input"" placeholder=""Password"">
				</div>
				<button type=""button"" class=""button login__submit"" onclick=""submitData();"">
					<span class=""button__text"">Log In Now</span>
					<i class=""button__icon fas fa-chevron-right""></i>
				</button>		
				<div class=""login__field"">
					");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa671aab499e3fd5b1e6377fcea5eff70219bbbf5461", async() => {
                    WriteLiteral("SingUp");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t</div>\t\t\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		</div>
		<div class=""screen__background"">
			<span class=""screen__background__shape screen__background__shape4""></span>
			<span class=""screen__background__shape screen__background__shape3""></span>		
			<span class=""screen__background__shape screen__background__shape2""></span>
			<span class=""screen__background__shape screen__background__shape1""></span>
		</div>		
	</div>
</div>

<script type=""text/javascript"">
function submitData(){
	var userEmailId = document.getElementById(""UserEmailId"").value;
	var userPassword = document.getElementById(""UserPassword"").value;
	if(typeof userEmailId=='undefined' || userEmailId==''){
		document.getElementById(""UserEmailId"").focus();
		alert('Enter User Email Id..');
		return;
	}
	if(typeof userPassword=='undefined' || userPassword==''){
		document.getElementById(""UserPassword"").focus();
		alert('Enter User password..');
		return;
	}
	$.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 54 "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml"
                 Write(Url.Action("GetPasswordSHAFormate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
				data: {password: userPassword},
                dataType: ""text"",
                success: function (result, status, xhr) {
					console.log(result);
                    LoginProcess(result,userEmailId);
                },
                error: function (xhr, status, error) {
                    alert(""Result: "" + status + "" "" + error + "" "" + xhr.status + "" "" + xhr.statusText)
                }
            });
}    
function LoginProcess(password,userEmailId){
$.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 69 "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml"
                 Write(Url.Action("LoginProcess"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n\t\t\t\tdata: {userEmailId: userEmailId,\r\n\t\t\t\t\tpassword: password},\r\n                dataType: \"text\",\r\n                success: function (result, status, xhr) {\r\n\t\t\t\t\tconsole.log(result);\r\n\t\t\t\t\tif(status=200){\r\n\t\t\t\t\t\twindow.location.replace(\"");
#nullable restore
#line 76 "D:\Projects\MVCTestProject\BMS\Views\Login\Login.cshtml"
                                            Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
					}
					else{
						alert(result);
					}
					//$('body').html(result);
					//window.location.replace(result);
                },
                error: function (xhr, status, error) {
                    alert(""Result: "" + status + "" "" + error + "" "" + xhr.status + "" "" + xhr.statusText)
                }
            });
}
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
