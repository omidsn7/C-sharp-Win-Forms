using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
    public class HTMLMaker
    {
        public string MakeHtml()
        {
            PDatabase db = new PDatabase();
            string s;
            s = "<html>" +
                "<style>" +
                "table, th, td {" +
                "border: 1px solid black;" +
                           "}" +
                "</style>" +
                "<body>" +
                "<h2> A Basic HTML Table For My DataBase</h2>" +
                "<table style = 'width:100%'>" +
                "<tr>" +
                "<th> Id </th>" +
                "<th> Name </th>" +
                "<th> Age </th>" +
                "</tr>";

            string s1 = "";
            foreach (var item in db.People)
            {
                //s += "<tr>" +
                //      $"<td> {item.Id} </td>" +
                //      $"<td> {item.Name} </td>" +
                //      $"<td> {item.Age} </td>" +
                //     "</tr>";
                s1 = System.IO.File.ReadAllText(@"C:\Users\O_sorayaee\source\repos\HTML\HTML\People.html");
                s1 = s1.Replace("Id", $"{item.Id}");
                s1 = s1.Replace("Name", $"{item.Name}");
                s1 = s1.Replace("Age", $"{item.Age}");
                s += s1;
            }

            s += "</table>" +
                 "</body>" +
                 "</html>";

            return s;

        }
    }
}
