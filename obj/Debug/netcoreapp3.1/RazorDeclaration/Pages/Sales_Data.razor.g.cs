// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SQL_Connection.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using SQL_Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\_Imports.razor"
using SQL_Connection.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\Sales_Data.razor"
using SQL_Connection.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales")]
    public partial class Sales_Data : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\Sales_Data.razor"
       
    List<Sales> sales = new List<Sales>();
    Sales sale = new Sales();
    string Message = "";

    protected override async Task OnInitializedAsync()
    {
        GetSales();
    }

    private void GetSales()
    {
        sales = salesService.GetSales();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SQL_Connection.IServices.ISalesService salesService { get; set; }
    }
}
#pragma warning restore 1591
