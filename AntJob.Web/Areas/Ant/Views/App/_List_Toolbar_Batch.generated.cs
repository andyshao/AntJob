﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    
    #line 2 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using AntJob.Web;
    using NewLife;
    
    #line 1 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Ant/Views/App/_List_Toolbar_Batch.cshtml")]
    public partial class _Areas_Ant_Views_App__List_Toolbar_Batch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Ant_Views_App__List_Toolbar_Batch_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityOperate;
    var enableSelect = this.EnableSelect();


            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
 if (enableSelect)
{

            
            #line default
            #line hidden
WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-warning btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 11 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("ResetApp"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        <span");

WriteLiteral(" title=\"清空作业、作业项、统计、错误，开始时间设为本月一号\"");

WriteLiteral(">重置</span>\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 14 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("Set"));

            
            #line default
            #line hidden
WriteLiteral("?enable=true\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量启用\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-error btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 17 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
                                                                                 Write(Url.Action("Set"));

            
            #line default
            #line hidden
WriteLiteral("?enable=false\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量禁用\r\n    </button>\r\n");

            
            #line 20 "..\..\Areas\Ant\Views\App\_List_Toolbar_Batch.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
