<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student | Home</title>
</head>
<body style="margin:0; padding:5px">
    <form id="form1" runat="server">
        <div style="background-color:bisque">
            <table>     
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Roll"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRoll" runat="server" style="margin-left: 37px" Width="312px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" style="margin-left: 37px" Width="312px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> 
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 37px" Width="312px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtAge" runat="server" style="margin-left: 37px" Width="312px"></asp:TextBox>
                     </td>
                 </tr>
                <tr>
                    <td>
                         <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click"/>
                    </td>
                    <td>

                         <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
                         <asp:Button ID="BtnUpdate" runat="server" Text="Update" />
                         <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />

                         <asp:Button ID="BtnReset" runat="server" Text="Reset" OnClick="BtnReset_Click" />
                    </td>
                </tr>
            </table>
            <hr />
            <asp:Label Text="" ID="lblResult" runat ="server" />
            <h2>Student Details:</h2>
            <asp:GridView ID="gvStudentDeatils" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
