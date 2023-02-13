

using System.Data;

var table = new DataTable();
table.Columns.Add("ID", typeof(string));
table.Columns.Add("First Name", typeof(string));
table.Columns.Add("Last Name", typeof(string));
table.Columns.Add("Phone", typeof(string));
table.Columns.Add("Email", typeof(string));
table.Columns.Add ("Age", typeof(int));


Console.WriteLine(table);

static string Actions()
    {
        Console.WriteLine("New    - (N)");
        Console.WriteLine("View   - (V)");
        Console.WriteLine("Edit   - (E)");
        Console.WriteLine("Remove - (R)");

        string result = Console.ReadLine();
        return result;
    }

