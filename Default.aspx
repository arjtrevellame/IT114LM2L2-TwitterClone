<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwitterClone.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--For data repeater--%>
            <%--<asp:Repeater ID="PostRepeater" runat="server">
                <ItemTemplate>
                    <div>
                        <p><%#Eval ("Content") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>--%>

            <%--Control Structure - IF--%>
            <%--<%if (currentPost.PostedBy == "rane")%>
            <% { %>
                <p><%= currentPost.Content%></p>
                <p><%= currentPost.PostedBy%></p>
            <% } %> -- %>

            <%--Control Structure - Foreach--%>
            <%foreach (var currentPost in posts)%>
            <%{%>
            <%if (currentPost.PostedBy == "rane")%>
            <% { %>
                <p><%= currentPost.Content%></p>
                <p><%= currentPost.PostedBy%></p>
            <% } %>
            <%}%>
        </div>
    </form>
</body>
</html>
