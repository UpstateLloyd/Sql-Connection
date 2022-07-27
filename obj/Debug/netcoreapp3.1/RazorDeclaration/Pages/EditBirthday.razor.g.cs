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
#line 2 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditBirthday.razor"
using SQL_Connection.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditBirthday.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditBirthday.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditBirthday.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit_birthdays")]
    public partial class EditBirthday : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\lhotchkiss\source\repos\SQL-Connection\Sql-connection-master\Sql-connection-master\Pages\EditBirthday.razor"
       

    String name;
    String month;
    String day;
    String birthdayListFile = "Data/birthday_list.json";

    void SetName(String Val)
    {
        name = Val;
    }

    void SetMonth(String Val)
    {
        month = Val;
    }

    void SetDay(String Val)
    {
        day = Val;
    }

    async void AddBirthday()
    {
        try
        {
            // read in the file
            Dictionary<String, List<int>> items;
            using (StreamReader r = new StreamReader(birthdayListFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<Dictionary<String, List<int>>>(json); // The json should be {"Person name":[month, day],}
            }
            List<int> date = new List<int>();
            date.Add(Int32.Parse(month));
            date.Add(Int32.Parse(day));
            items.Add(name, date);
            using (StreamWriter file = File.CreateText(birthdayListFile))
            {
                String json = JsonConvert.SerializeObject(items);
                file.Write(json);
            }

            await JSRuntime.InvokeVoidAsync("alert", "Birthday added successfully!");
        }
        catch (FormatException)
        {
            await JSRuntime.InvokeVoidAsync("alert", "Day and month must be numbers");
        }
        catch (ArgumentException)
        {
            await JSRuntime.InvokeVoidAsync("alert", "Name already exists");
        }
        catch (Exception e)
        {
            await JSRuntime.InvokeVoidAsync("alert", "An error occurred:\n" + e.GetType().ToString() + "\n" + e.Message);
        }
    }

    async void DelBirthday()
    {
        try
        {
            // read in the file
            Dictionary<String, List<int>> items;
            using (StreamReader r = new StreamReader(birthdayListFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<Dictionary<String, List<int>>>(json); // The json should be {"Person name":[month, day],}
            }
            items.Remove(name);
            using (StreamWriter file = File.CreateText(birthdayListFile))
            {
                String json = JsonConvert.SerializeObject(items);
                file.Write(json);
            }

            await JSRuntime.InvokeVoidAsync("alert", "Birthday deleted successfully!");
        }
        catch(KeyNotFoundException)
        {
            await JSRuntime.InvokeVoidAsync("alert", "Name not found");
        } catch(Exception e)
        {
            await JSRuntime.InvokeVoidAsync("alert", "An error occurred:\n" + e.GetType().ToString() + "\n" + e.Message);
        }
    }

    /*
    This function gets a number of birthdays equal to count
    It will return them preformatted as "name: date"
    */
    List<String> getBirthdays(int count)
    {
        Dictionary<String, DateTime> birthday_dict = readBirthdays();
        List<String> all_birthdays = birthday_dict.Keys.ToList();
        all_birthdays.Sort((a, b) => ((birthday_dict[a] - DateTime.Today).Days - (birthday_dict[b] - DateTime.Today).Days));
        // after sorting all_birthdays, the nest step is to add the dates to it so the list is useable
        all_birthdays = (from name in all_birthdays select name + ": " + birthday_dict[name].Month.ToString() + "/" + birthday_dict[name].Day.ToString()).ToList();

        if (all_birthdays.Count < count) { count = all_birthdays.Count; } //if you ask for more birthdays than we have, just give them all of them

        List<string> birthdays = all_birthdays.Take(count).ToList();

        return birthdays;
    }

    /*
    This function reads the excel file birthdayListFile and create a dictionary of names to DateTime objects
    For simplicity off comparisons late, the DateTime objects will represent the person's next birthday this year
    */
    Dictionary<String, DateTime> readBirthdays()
    {
        Dictionary<String, DateTime> birthdays = new Dictionary<String, DateTime>();
        DateTime today = DateTime.Today;

        // read in the file
        Dictionary<String, List<int>> items;
        using (StreamReader r = new StreamReader(birthdayListFile))
        {
            string json = r.ReadToEnd();
            items = JsonConvert.DeserializeObject<Dictionary<String, List<int>>>(json); // The json should be {"Person name":[month, day],}
        }

        foreach (String name in items.Keys)
        {
            DateTime date = new DateTime(today.Year, items[name][0], items[name][1]);
            if (date < today) { date = date.AddYears(1); }
            birthdays[name] = date;
        }

        return birthdays;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
