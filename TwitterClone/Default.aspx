<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwitterClone.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<asp:Repeater ID="PostRepeater" runat="server">
                <ItemTemplate>
                    <p><%#Eval("Content")%></p>
                </ItemTemplate>
            </asp:Repeater>--%>
            <%if (currentPost.PostBy == "joelim") %>
            <% { %>
                <p> <%=currentPost.Content %>
                <p> <%=currentPost.PostBy %>
            <% } %>
            <%foreach (var item in posts)%>
            <%    { %>
                <p> <%=item.Content %>
            <%    } %>
        </div>
    </form>
</body>
</html>
