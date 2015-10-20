﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="CDRSportsStore.Pages.Listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SportsStore</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%foreach (CDRSportsStore.Models.Product prod in GetProducts())
              {
                  Response.Write("<div class='item'>");
                  Response.Write(string.Format("<h3>{0}</h3>", prod.Name));
                  Response.Write(prod.Description);
                  Response.Write(string.Format("<h4>{0:c}<h4>", prod.Price));
                  Response.Write("</div");
              }
            %>
        
        </div>
    </form>
</body>
</html>
