#pragma checksum "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63603491ccf76531576d88f5d65b93038cbfe438"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit_announcements")]
    public partial class EditAnnouncements : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Upload announcement slide</h1>\n\n");
            __builder.OpenElement(1, "p");
#nullable restore
#line 11 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
__builder.AddContent(2, status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.AddMarkupContent(4, "<p>Add image file:</p>\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(5);
            __builder.AddAttribute(6, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 13 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                     Handle_Selection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n<br>\n<br>\n");
            __builder.AddMarkupContent(8, "<strong>File selected:</strong>\n");
#nullable restore
#line 17 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
 if (ms != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
__builder.AddContent(9, filename);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
             
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\n<br>\n<br>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                  bar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.AddMarkupContent(15, "<p>Set expiration date:</p>\n    ");
                __Blazor.SQL_Connection.Pages.EditAnnouncements.TypeInference.CreateInputDate_0(__builder2, 16, 17, 
#nullable restore
#line 27 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                            bar.expires

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bar.expires = __value, bar.expires)), 19, () => bar.expires);
                __builder2.AddMarkupContent(20, "\n\n    <br><br>\n    ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                       SaveCurrentFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(23, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n<br>\n<br>\n");
            __builder.AddMarkupContent(26, "<h3>Current slides and expiration dates:</h3>\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                   removeOld

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Remove all expired");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.OpenElement(31, "ul");
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 37 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
     foreach (String filename in sortDictKeys(loadSlides()))
    {
        var a = count;
        count += 1;

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "        ");
            __builder.OpenElement(34, "li");
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "p");
#nullable restore
#line 42 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
__builder.AddContent(37, slides[filename].ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 43 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                       "AnnouncementSlides/"+filename

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "width", "300px");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n            ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "id", "pg-button-" + (
#nullable restore
#line 44 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                                   count

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
                                                                                                   () => removeSlide(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        <br>\n        <br>\n");
#nullable restore
#line 48 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
      count = 0;

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditAnnouncements.razor"
       
    private class Foo
    {
        public DateTime expires { get; set; } = DateTime.Now;
    }
    Foo bar = new Foo();
    MemoryStream ms;
    string filename;
    public string status = "";
    private static string expireJsonFile = "Data/announce_expire.json";
    private Dictionary<String, DateTime> slides;
    private int count = 0;

    async void Handle_Selection(IFileListEntry[] files)
    {
        try
        {
            var file = files.FirstOrDefault();
            ms = new MemoryStream();
            if (file != null)
            {
                filename = file.Name;
                await file.Data.CopyToAsync(ms);
            }
            else
            {
                await JSRuntime.InvokeVoidAsync("alert", "Error loading file!");
            }
        }
        catch (Exception e)
        {
            await JSRuntime.InvokeVoidAsync("alert", $"Error loading file!\n{e}");
        }
    }

    async void SaveCurrentFile()
    {
        try
        {
            using (FileStream fs = File.Create($"wwwroot/AnnouncementSlides/{filename}"))
            {
                ms.WriteTo(fs);
            }
            Dictionary<String, DateTime> items = loadSlides();

            items.Add(filename, bar.expires);
            using (StreamWriter file = File.CreateText(expireJsonFile))
            {
                String json = JsonConvert.SerializeObject(items);
                file.Write(json);
            }

            await JSRuntime.InvokeVoidAsync("alert", $"{filename} saved!");
        }
        catch (System.NullReferenceException)
        {
            await JSRuntime.InvokeVoidAsync("alert", "No file found to save!");
        }
        catch (System.IO.IOException e)
        {
            await JSRuntime.InvokeVoidAsync("alert", $"Error saving file!\n{e.Message}");
        }
    }

    private Dictionary<String, DateTime> loadSlides()
    {
        // read in the json file
        Dictionary<String, DateTime> items;
        using (StreamReader r = new StreamReader(expireJsonFile))
        {
            string json = r.ReadToEnd();
            items = JsonConvert.DeserializeObject<Dictionary<String, DateTime>>(json); // The json should be {"file_name":expiredate,}
        }
        slides = items;
        return items;
    }

    private List<String> sortDictKeys(Dictionary<String, DateTime> dict)
    {
        List<String> all_strs = dict.Keys.ToList();
        all_strs.Sort((a, b) => ((dict[a] - DateTime.Today).Days - (dict[b] - DateTime.Today).Days));
        return all_strs;
    }

    async void removeSlide(int index)
    {
        try
        {
            Dictionary<String, DateTime> current = loadSlides();
            string remove = sortDictKeys(current)[index];
            File.Delete("wwwroot/AnnouncementSlides/" + remove);
            current.Remove(remove);
            using (StreamWriter file = File.CreateText(expireJsonFile))
            {
                String json = JsonConvert.SerializeObject(current);
                file.Write(json);
            }
            await JSRuntime.InvokeVoidAsync("alert", "Announcement removed successfully!");
        }
        catch (Exception e)
        {
            await JSRuntime.InvokeVoidAsync("alert", $"Error saving file!\n{e.Message}");
        }
    }

    async void removeOld()
    {
        List<string> files = sortDictKeys(slides);
        for (int i = files.Count - 1; i >= 0; i--)
        {
            if (slides[files[i]] < DateTime.Now)
            {
                removeSlide(i);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.SQL_Connection.Pages.EditAnnouncements
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
